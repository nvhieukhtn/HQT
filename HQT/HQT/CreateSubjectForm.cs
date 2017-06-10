using System;
using System.Linq;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Core.Model;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class CreateSubjectForm : BaseForm
    {
        private readonly IAccountService _accountService;
        private readonly ISubjectService _subjectService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
        public CreateSubjectForm()
        {
            InitializeComponent();
            _subjectService = _container.Resolve<ISubjectService>();
            _accountService = _container.Resolve<IAccountService>();
        }

        private async void CreateSubjectForm_Load(object sender, EventArgs e)
        {
            var listTeacher = await _accountService.GetListTeachersAsync();
            var listStudents = await _accountService.GetListStudentsAsync();
            var listStudentItems = listStudents.Select(x=>new ListViewItem(){Text = x.FullName, Tag = x}).ToArray();
            var listTeacherItems = listTeacher.Select(x => new ListViewItem() { Text = x.FullName, Tag = x }).ToArray();
            lvStudent.Items.AddRange(listStudentItems);
            lvTeacher.Items.AddRange(listTeacherItems);
        }

        private Subject GetSubjectFromUi()
        {
            var subjectName = txtSubjectName.Text;
            var subjectContent = txtContent.Text;
            var listTeachers = lvTeacher.CheckedItems.Cast<ListViewItem>().Select(x => x.Tag).Cast<Teacher>().ToList();
            var listStudents = lvStudent.CheckedItems.Cast<ListViewItem>().Select(x => x.Tag).Cast<Student>().ToList();
            var subject = new Subject(subjectName)
            {
                ListTeachers =  listTeachers,
                ListStudents =  listStudents
            };
            return subject;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var subject = GetSubjectFromUi();
            var result = await _subjectService.CreateSubjectAsync(subject);
            if (result)
            {
                var act = MessageBox.Show(this, "Thêm khóa học thành công", "Thông báo", MessageBoxButtons.OK);
                if (act == DialogResult.OK)
                {
                    IsClose = false;
                    var subjectForm = new SubjectManagerForm();
                    subjectForm.Show();
                    Close();
                }
            }
            else
            {
                var act = MessageBox.Show(this, "Thêm khóa học thất bại\nThử lại!", "Thông báo", MessageBoxButtons.RetryCancel);
                if (act == DialogResult.Cancel)
                {
                    IsClose = false;
                    var createSubjectForm = new CreateSubjectForm();
                    createSubjectForm.Show();
                    Close();
                }
                else
                {
                    IsClose = false;
                    var subjectForm = new SubjectManagerForm();
                    subjectForm.Show();
                    Close();
                }
            }
        }
    }
}
