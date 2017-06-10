using System;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Core.Model;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class TabTopicContentUserControl : UserControl
    {
        private readonly ITopicService _topicService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
        public string Title
        {
            get
            {
                if (ckAddNew.Checked)
                    return txtTitle.Text;
                return ((Topic) cbTitle.SelectedItem).Title;
            }
        }

        public string Content => txtContent.Text;

        public TabTopicContentUserControl()
        {
            InitializeComponent();
            _topicService = _container.Resolve<ITopicService>();
        }

        public Topic GetTopic()
        {
            var topic = new Topic(Title, Content);
            if (ckAddNew.Checked == false)
                topic.Id = ((Topic) cbTitle.SelectedItem).Id;
            return topic;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var target = (CheckBox) sender;
            txtTitle.Visible = target.Checked;
            cbTitle.Visible = !target.Checked;
            txtContent.Enabled = target.Checked;
            if (ckAddNew.Checked == false)
            {
                var topic = ((Topic)cbTitle.SelectedItem);
                txtContent.Text = topic.Detail;
            }
        }

        private async void TabTopicContentUserControl_Load(object sender, EventArgs e)
        {
            var listTopics = await _topicService.GetListTopicsAsync();
            cbTitle.DataSource = listTopics;
            cbTitle.DisplayMember = "Title";
        }

        private void cbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ckAddNew.Checked == false)
            {
                var target = ((Topic) cbTitle.SelectedItem);
                txtContent.Text = target.Detail;
            }
        }
    }
}
