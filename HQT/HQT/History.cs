using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQT
{
    public partial class History : Form
    {
        public List<string> ListSubject;
        public List<string> ListAction;
        public List<string> ListType;
        public History()
        {
            InitializeComponent();
            ListSubject = new List<string>
            {
                "HQT",
                "Data mining",
                "Algorithms"
            };
            ListAction = new List<string>
            {
                "Đăng ký",
                "Hủy"
            };

            ListType = new List<string>
            {
                "Cộng điểm",
                "Giữa kỳ",
                "Cuối kỳ"
            };

            cbAction.DataSource = ListAction;
            cbAction.SelectedIndex = -1;
            cbSubject.DataSource = ListSubject;
            cbSubject.SelectedIndex = -1;
            cbType.DataSource = ListType;
            cbType.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length > 0)
                btnSearch.Enabled = true;
            else
                btnSearch.Enabled = false;
        }
    }
}
