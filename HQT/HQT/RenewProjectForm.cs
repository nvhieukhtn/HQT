using System;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class RenewProjectForm : Form
    {
        private readonly IProjectService _projectService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
        private readonly Guid _projectId;
        public RenewProjectForm(Guid projectId)
        {
            InitializeComponent();
            _projectId = projectId;
            _projectService = _container.Resolve<IProjectService>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnRenew_Click(object sender, EventArgs e)
        {
            var renewRegisterDays = 0;
            Int32.TryParse(txtRenewRegisterDays.Text, out renewRegisterDays);
            var renewSubmitDays = 0;
            Int32.TryParse(txtRenewSubmitDays.Text, out renewSubmitDays);

            var result = true;
            result &= await _projectService.RenewEndRegisterDays(_projectId, renewRegisterDays);
            if (result)
                result &= await _projectService.RenewEndSubmitDays(_projectId, renewSubmitDays);
            if (result)
            {
                var act = MessageBox.Show(this, "Gia hạn đồ án thành công", "Thông báo", MessageBoxButtons.OK);
                if (act == DialogResult.OK)
                {
                    Close();
                }
            }
            else
            {
                var act = MessageBox.Show(this, "Gia hạn đồ án thất bại\nThử lại!", "Thông báo", MessageBoxButtons.RetryCancel);
                if (act == DialogResult.Cancel)
                {
                    Close();
                }
                else
                {
                    var createProjectForm = new RenewProjectForm(_projectId);
                    createProjectForm.Show();
                    Close();
                }
            }

        }
    }
}
