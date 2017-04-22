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
    public partial class Topic : UserControl
    {
        public delegate void TopicClickedEventHandler(object sender, EventArgs e);

        public event TopicClickedEventHandler TopicClicked;

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
                
                var numberOfLines = txtDetail.Text.ToLineNumber(120);
                txtDetail.Height = 15 * numberOfLines;
                grbDetail.Height = txtDetail.Height + 20;

            }
        }
        
        public Topic()
        {
            InitializeComponent();
            InitDefaultControl();
        }

        private void InitDefaultControl()
        {
            btnTitle.FlatAppearance.MouseOverBackColor = btnTitle.BackColor;
            btnTitle.FlatAppearance.MouseDownBackColor = btnTitle.BackColor;
            btnRegister.FlatAppearance.MouseOverBackColor = btnTitle.BackColor;
            btnRegister.FlatAppearance.MouseDownBackColor = btnRegister.BackColor;
            grbDetail.Visible = false;
            grbPractice.Height = 65;
            Height = 65;
            btnTitle.Click += new EventHandler(Practice_OnClick);
            lbTitle.Click += new EventHandler(Practice_OnClick);
            grbDetail.Click += new EventHandler(Practice_OnClick);
            btnTitle.MouseHover += (sender, args) =>
            {
                Cursor = Cursors.Hand;
            };
            lbTitle.MouseHover += (sender, args) =>
            {
                Cursor = Cursors.Hand;
            };
            grbDetail.MouseHover += (sender, args) =>
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
            if (TopicClicked != null)
            {
                Collapse();
                TopicClicked(this, e);
            }
        }
    }
}
