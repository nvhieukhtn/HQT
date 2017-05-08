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
    public partial class TopicUserControl : UserControl
    {
        public delegate void TopicClickedEventHandler(object sender, EventArgs e);

        public event TopicClickedEventHandler TopicClicked;
        public event TopicClickedEventHandler TopicRegister;

        private bool _collapse = false;

        private int _index;

        public int Index
        {
            get => _index;
            set
            {
                _index = value;
                grbPractice.Text = $"Đề bài {_index}";
            }
        }

        private bool _allowRegister;

        public bool AllowRegister
        {
            get => _allowRegister;
            set
            {
                _allowRegister = value;
                btnRegister.Visible = _allowRegister;
            }
        }

        public Group GroupForProject { get; set; }

        private Topic _data;

        public Topic Data
        {
            get => _data;
            set
            {
                _data = value;
                btnTitle.Text = _data.Title;
                txtDetail.Text = _data.Detail;
                var numberOfLines = txtDetail.Text.ToLineNumber(120);
                txtDetail.Height = 15 * numberOfLines;
                grbDetail.Height = txtDetail.Height + 20;
            }
        }
        
        public TopicUserControl()
        {
            InitializeComponent();
            InitDefaultControl();
            _allowRegister = true;
        }

        private void InitDefaultControl()
        {
            btnTitle.FlatAppearance.MouseOverBackColor = btnTitle.BackColor;
            btnTitle.FlatAppearance.MouseDownBackColor = btnTitle.BackColor;
            btnRegister.FlatAppearance.MouseOverBackColor = btnTitle.BackColor;
            btnRegister.FlatAppearance.MouseDownBackColor = btnRegister.BackColor;
            grbDetail.Visible = false;
            grbPractice.Height = 60;
            Height = 60;
            btnTitle.Click += new EventHandler(Topic_OnClick);
            lbTitle.Click += new EventHandler(Topic_OnClick);
            grbDetail.Click += new EventHandler(Topic_OnClick);
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

        private void Topic_OnClick(object sender, EventArgs e)
        {
            if (TopicClicked != null)
            {
                Collapse();
                TopicClicked(this, e);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (TopicRegister != null)
            {
                Collapse();
                TopicRegister(this, e);
            }
        }
    }
}
