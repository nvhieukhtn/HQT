using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Core.Model;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class CreateTopicForm : BaseForm
    {
        private readonly Guid _projectId;
        private readonly ITopicService _topicService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
        public CreateTopicForm(Guid projectId)
        {
            InitializeComponent();
            _topicService = _container.Resolve<ITopicService>();
            _projectId = projectId;
            var topic = new TabTopicContentUserControl(){Location =  new Point(20,55), BackColor = Color.Transparent, Name = "topic"};
            Controls.Add(topic);
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            var topic = (TabTopicContentUserControl)Controls.Find("topic", false).FirstOrDefault();
            if(topic == null)
                 return;

            var topicObj = topic.GetTopic();
            var result = await _topicService.CreateTopicAsync(topicObj, _projectId);
            if (result)
            {
                var act = MessageBox.Show(this, "Thêm đề tài thành công", "Thông báo", MessageBoxButtons.OK);
                if (act == DialogResult.OK)
                {
                    IsClose = false;
                    var projectDetail = new ProjectDetailForm(_projectId);
                    projectDetail.Show();
                    this.Close();
                }
            }
            else
            {
                var act = MessageBox.Show(this, "Thêm đề tài thất bại\nThử lại!", "Thông báo", MessageBoxButtons.RetryCancel);
                if (act == DialogResult.Cancel)
                {
                    IsClose = false;
                    var projectDetailForm = new ProjectDetailForm(_projectId);
                    projectDetailForm.Show();
                    Close();
                }
                else
                {
                    IsClose = false;
                    var createTopic = new CreateTopicForm(_projectId);
                    createTopic.Show();
                    this.Close();
                }
            }
        }

        private void CreateTopicForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsClose)
                LoginForm.Instance.Close();
        }
    }
}
