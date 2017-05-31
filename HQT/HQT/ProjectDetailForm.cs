using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Model;

namespace HQT
{
    public partial class ProjectDetailForm : BaseForm
    {
        public static ProjectDetailForm Instance { get; private set; }

        private List<TopicUserControl> _listPracticeControl;
        private BaseProject _data;
        public BaseProject Data
        {
            get => _data;
            set 
            {
                _data = value;
                var status = Status.GetStatusProperty(_data.From, _data.To);
                btnStatus.Text = status.Description;
                btnStatus.BackColor = status.StatusColor;
                timeFrom.Value = _data.From;
                timeTo.Value = _data.To;
                var team = _data as ProjectForTeam;
                if (team != null)
                {
                    numberTo.Value = team.UpperThreshold;
                    numberFrom.Value = 1;
                }
                else
                {
                    numberFrom.Value = 1;
                    numberTo.Value = 1;
                }
                numberGroup.Value = _data.Limit;
            }
        }
        public ProjectDetailForm(BaseProject data)
        {
            InitializeComponent();
            Data = data;
            Instance = this;
            InitSubjects();
        }
        private void ShowDetail(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)UpdateSubjects);
        }

        private void Register(object sender, EventArgs e)
        {
            var target = (TopicUserControl) sender;
            if (target != null)
            {
                var topicRegister = new TopicRegisterForm
                {
                    Data = target.Data
                };
                IsClose = false;
                topicRegister.Show();
                Close();
            }
        }

        private void UpdateSubjects()
        {
            var marginTop = 140;
            foreach (var practiceControl in _listPracticeControl)
            {
                practiceControl.Location = new Point(5, marginTop);
                marginTop += practiceControl.Height;
            }
        }
        
        private void InitSubjects()
        {
            var index = 0;
            var status = Status.GetStatusProperty(_data.From, _data.To);
            var allowRegister = status.Description == "Processing";
            _listPracticeControl = new List<TopicUserControl>();
            foreach (var topic in Data.ListTopics)
            {
                var topicControl = new TopicUserControl()
                {
                    Data = topic,
                    Index = index + 1
                };
                topicControl.AllowRegister = allowRegister;
                topicControl.Location = new Point(10, 140 + index * topicControl.Height);
                topicControl.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                index++;
                topicControl.TopicClicked += new TopicUserControl.TopicClickedEventHandler(ShowDetail);
                topicControl.TopicRegister += new TopicUserControl.TopicClickedEventHandler(Register);
                _listPracticeControl.Add(topicControl);
                Controls.Add(topicControl);
            }
        }



        private void ProjectDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsClose)
                LoginForm.Instance.Close();
        }
    }
}
