using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Model;

namespace HQT
{
    public partial class OverviewAvailableTopicTabContentUserControl : OverviewTabContentUserControl
    {
        private List<Topic> _listTopics;
        public List<Topic> ListTopics
        {
            get => _listTopics;
            set
            {
                _listTopics = value;
                if (_listTopics != null)
                    RenderListTopics(_listTopics);
            }
        }

        public OverviewAvailableTopicTabContentUserControl()
        {
            InitializeComponent();
        }
        private void RenderListTopics(List<Topic> listTopics)
        {
            listView.Items.Clear();
            txtNumber.Text = listTopics.Count.ToString();
            var index = 1;
            foreach (var topic in listTopics)
            {
                var item = new ListViewItem(index.ToString());
                item.SubItems.Add(topic.Title);
                listView.Items.Add(item);
                index++;
            }
        }
    }
}
