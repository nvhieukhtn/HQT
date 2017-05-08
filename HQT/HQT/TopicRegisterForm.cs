using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Model;

namespace HQT
{
    public partial class TopicRegisterForm : BaseForm
    {
        public List<Student> ListStudents { get; set; }
        public List<MemberUserControl> ListMemberControls { get; set; }
        private Topic _data;

        public Topic Data
        {
            get => _data;
            set
            {
                _data = value;
                txtTitle.Text = _data.Title;
                txtContent.Text = _data.Detail;
            }
        }
        public TopicRegisterForm()
        {
            InitializeComponent();
            ListStudents  = new List<Student>();
            ListMemberControls = new List<MemberUserControl>();
            var student = Student.Default;
            ListStudents.Add(student);
            var memberControl = AddMemberControl(0);
            gbGroupInformation.Controls.Add(memberControl);
            ListMemberControls.Add(memberControl);
        }

        private MemberUserControl AddMemberControl(int index)
        {
            if (index < 10)
            {
                var memberControl = new MemberUserControl();
                var y = 15 + index * 30;
                var x = 20;
                if (index >= 5)
                {
                    x = 320;
                    y = 15 + (index - 5) * 30;
                }
                memberControl.Location = new Point(x, y);

                return memberControl;
            }
            return null;
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            var index = ListStudents.Count;
            var student = Student.Default;
            
            var memberControl = AddMemberControl(index);
            if (memberControl != null)
            {
                ListStudents.Add(student);
                gbGroupInformation.Controls.Add(memberControl);
                ListMemberControls.Add(memberControl);
            }
            
        }

        private void TopicRegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsClose)
                LoginForm.Instance.Close();
        }
    }
}
