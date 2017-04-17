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
        public delegate void PracticeClickedEventHandler(object sender, EventArgs e);

        public event PracticeClickedEventHandler PracticeClicked;

        private bool _collapse = false;
        public string Title
        {
            get => btnTitle.Text;
            set => btnTitle.Text = value;
        }

        public string Detail
        {
            get => txtDetail.Text;
            set
            {
                txtDetail.Text = value;
                var numberOfLines = txtDetail.Text.ToLineNumber();
                txtDetail.Height = 15 * numberOfLines;
                grbDetail.Height = txtDetail.Height + 20;

            }
        }
        
        public Practice()
        {
            InitializeComponent();
            grbDetail.Visible = false;
            grbPractice.Height = 65;
            Height = 65;
            btnTitle.Click += new EventHandler(Practice_OnClick);
            grbPractice.Click += new EventHandler(Practice_OnClick);
            lbTitle.Click += new EventHandler(Practice_OnClick);
            grbDetail.Click += new EventHandler(Practice_OnClick);
            grbPractice.MouseHover += (sender, args) =>
            {
                Cursor = Cursors.Hand;
            };
        }

        public void Collapse()
        {
            if (_collapse == false)
            {
                Height += grbDetail.Height;
                grbPractice.Height += grbDetail.Height;
                grbDetail.Visible = true;
            }
            else
            {
                grbDetail.Visible = false;
                grbPractice.Height -= grbDetail.Height;
                Height -= grbDetail.Height;
            }
            _collapse = !_collapse;
        }

        private void Practice_OnClick(object sender, EventArgs e)
        {
            if (PracticeClicked != null)
            {
                Collapse();
                PracticeClicked(this, e);
            }
        }
    }
}
