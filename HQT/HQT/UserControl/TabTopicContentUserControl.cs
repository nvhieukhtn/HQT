using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQT
{
    public partial class TabTopicContentUserControl : UserControl
    {
        public string Title
        {
            get => txtTitle.Text;
            set => txtTitle.Text = value;
        }

        public string Content
        {
            get => txtContent.Text;
            set => txtContent.Text = value;
        }
        public TabTopicContentUserControl()
        {
            InitializeComponent();
        }
    }
}
