using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HQT.Core.Interface.Service;
using HQT.Core.Model;
using Microsoft.Practices.Unity;

namespace HQT
{
    public partial class AccountManagerForm : BaseForm
    {
        private readonly IAccountService _accountService;
        private readonly IUnityContainer _container = DependencyResolution.Container;
        public List<AccountUserControl> ListAccountUserControls;
        private List<User> _data;
        public List<User> Data
        {
            get => _data;
            set
            {
                _data = value;
                foreach (var user in _data)
                {
                    var index = ListAccountUserControls.Count;
                    var userControl = CreateAccountUsercontrol(index);
                    Controls.Add(userControl);
                    ListAccountUserControls.Add(userControl);
                }
            }
        }

        private AccountUserControl CreateAccountUsercontrol(int index)
        {
            var userControl = new AccountUserControl();
            if(index < Data.Count)
                userControl.Data = Data[index];
            userControl.Location = new Point(60, 60 + index * 30);
            userControl.SaveAccountEvent += new AccountUserControl.AccountClickedEventHandler(SaveAccount);
            userControl.DeleteAccountEvent  += new AccountUserControl.AccountClickedEventHandler(DeleteAccount);
            return userControl;
        }

        public AccountManagerForm()
        {
            InitializeComponent();
            _accountService = _container.Resolve<IAccountService>();
            ListAccountUserControls = new List<AccountUserControl>();
            Data = new List<User>();
        }

        private void AccountManagerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsClose)
                LoginForm.Instance.Close();
        }

        private async void AccountManagerForm_Load(object sender, EventArgs e)
        {
            Data = await _accountService.GetListAccountAsync(Guid.NewGuid());
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            var user = Student.Default;
            var index = Data.Count;

            var newAccount = CreateAccountUsercontrol(index);
            newAccount.Data = user;
            newAccount.IsEdit = true;
            Controls.Add(newAccount);
            ListAccountUserControls.Add(newAccount);
        }

        private void SaveAccount(object sender, EventArgs e)
        {
            
        }

        private void DeleteAccount(object sender, EventArgs e)
        {
                
        }
    }
}
