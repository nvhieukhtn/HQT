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

namespace HQT
{
    public partial class ProjectDetail : Form
    {
        public static ProjectDetail Instance { get; private set; }

        public List<string> ListPractices;
        private List<Practice> _listPracticeControl;
        public ProjectDetail()
        {
            ListPractices = new List<string>
            {
                "Đây là đề bài demo",
                "Đây là đề bài demo",
                "Đây là đề bài demo",
                "Đây là đề bài demo"
            };
            InitializeComponent();
            Instance = this;
            InitSubjects();
        }
        private void ShowDetail(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)UpdateSubjects);
        }

        private void UpdateSubjects()
        {
            var marginTop = 10;
            foreach (var practiceControl in _listPracticeControl)
            {
                practiceControl.Location = new Point(5, marginTop);
                marginTop += practiceControl.Height;
            }
        }

        private void AdjustSubjectControlSize()
        {
            foreach (var practiceControl in _listPracticeControl)
            {
                practiceControl.Width = Width - 20;
            }
        }

        private void InitSubjects()
        {
            var index = 0;
            var detail = "Bầu trời chấn động, biển rộng gào thét, lớn vô cùng Chiến Ý Cự Long chiếm giữ không trung, khổng lồ trên Thân Khu, 68 triệu đạo chiến văn lóe ra đoạt ánh mắt huy, cái kia tản mát ra chiến ý, cơ hồ là làm cho mảnh không gian này đều đang run rẩy nhè nhẹ lấy...";
            _listPracticeControl = new List<Practice>();
            foreach (var practice in ListPractices)
            {
                var practiceBoard = new Practice()
                {
                    Title = practice,
                    Detail = detail
                };
                practiceBoard.Location = new Point(10, 10 + index * practiceBoard.Height);
                practiceBoard.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                index++;
                practiceBoard.PracticeClicked += new Practice.PracticeClickedEventHandler(ShowDetail);
                _listPracticeControl.Add(practiceBoard);
                Controls.Add(practiceBoard);
            }
        }

        private void ProjectDetail_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login.Instance.Close();
        }
    }
}
