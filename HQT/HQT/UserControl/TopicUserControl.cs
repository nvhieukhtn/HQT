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
using HQT.Shared;

namespace HQT
{
    public partial class TopicUserControl : UserControl
    {
        public delegate void TopicClickedEventHandler(object sender, EventArgs e);

        public event TopicClickedEventHandler TopicClicked;
        public event TopicClickedEventHandler TopicRegister;
        public event TopicClickedEventHandler TopicDelete;
        public event TopicClickedEventHandler DisplayMember;

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

        private bool _isRegister;
        public bool IsRegister
        {
            get => _isRegister;
            set
            {
                _isRegister = value;
                if (_isRegister)
                {
                    btnRegister.Visible = false;
                    btnMembers.Visible = true;
                }
                else
                {
                    btnRegister.Visible = true;
                    btnMembers.Visible = false;
                }
            }
        }

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
            btnTitle.Click += Topic_OnClick;
            lbTitle.Click += Topic_OnClick;
            grbDetail.Click += Topic_OnClick;
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (TopicDelete != null)
                TopicDelete(this, e);
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            if (DisplayMember != null)
                DisplayMember(this, e);
        }

        private void TopicUserControl_Load(object sender, EventArgs e)
        {
            if (ApplicationSetting.CurrentUser is Student)
            {
                btnRemove.Visible = false;
                btnRegister.Visible = false;
            }
            else
            {
                btnRegister.Visible = true;
                btnRemove.Visible = true;
            }
        }
    }
}
