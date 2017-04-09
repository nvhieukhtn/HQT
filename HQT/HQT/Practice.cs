using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQT
{
    public partial class Practice : UserControl
    {

        private bool _collapse = false;
        public string Title
        {
            get
            {
                return btnTitle.Text;
            }
            set
            {
                btnTitle.Text = value;
            }
        }
        
        public Practice()
        {
            InitializeComponent();
            grbDetail.Visible = false;
            grbPractice.Height = 65;
            Height = 65;
        }

        public void Collapse()
        {
            if (_collapse == false)
            {
                Height += grbDetail.Height;
                grbDetail.Visible = true;
            }
            else
            {
                grbDetail.Visible = false;
                Height -= grbDetail.Height;
            }
            _collapse = !_collapse;
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            
        }

        private void grbPractice_MouseHover(object sender, EventArgs e)
        {
            Collapse();
        }
    }
}
