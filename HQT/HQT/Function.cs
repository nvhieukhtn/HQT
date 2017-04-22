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
    public partial class Function : UserControl
    {
        public delegate void FunctionClickedEventHandler(object sender, EventArgs e);

        public event FunctionClickedEventHandler FunctionClicked;
        public Bitmap Avatar
        {
            set => picAvatar.Image = value;
        }

        public string Title
        {
            set => txtTitle.Text = value;
        }
        public Function()
        {
            InitializeComponent();
            gbFunction.Click += new EventHandler(Function_OnClicked);
            picAvatar.Click += new EventHandler(Function_OnClicked);
            txtTitle.Click += new EventHandler(Function_OnClicked);
            gbFunction.MouseHover += new EventHandler(Function_Hover);
            picAvatar.MouseHover += new EventHandler(Function_Hover);
            txtTitle.MouseHover += new EventHandler(Function_Hover);
        }

        private void Function_Hover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void Function_OnClicked(object sender, EventArgs e)
        {
            if (FunctionClicked != null)
            {
                FunctionClicked(this, e);
            }
        }
    }
}
