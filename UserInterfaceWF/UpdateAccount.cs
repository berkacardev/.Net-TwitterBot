using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Concreate;
using UserInterfaceWF.Utilities;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceWF
{
    public partial class UpdateAccount : Form
    {
        ITwitterAccountService _twitterAccountService;
        public TwitterAccount twitterAccount { get; set; }
        public UpdateAccount(TwitterAccount twitterAccount)
        {
            _twitterAccountService = NinjectInstanceFactory.GetInstance<ITwitterAccountService>();
            this.twitterAccount = twitterAccount;
            InitializeComponent();
            string accountUserName = twitterAccount.AccountUserName;
            string accountPassword = twitterAccount.AccountPassword;
            DateTime accountDate = twitterAccount.AccountDate;
            if (twitterAccount != null)
            {
                lbl_AccountUserName.Text = accountUserName;
                lbl_AccountPassword.Text = accountPassword;
                lbl_AccountDate.Text = accountDate.ToString();
                txt_AccountUserName.Text = accountUserName;
                txt_AccountPassword.Text = accountPassword;
            }
        }
        private void UpdateTwitterAccount(TwitterAccount twitterAccount)
        {
            string accountUserName = txt_AccountUserName.Text;
            string accountPassword = txt_AccountPassword.Text;
            TwitterAccount _twitterAccount = new TwitterAccount();
            _twitterAccount.AccountId = twitterAccount.AccountId;
            _twitterAccount.AccountUserName = accountUserName;
            _twitterAccount.AccountPassword = accountPassword;
            _twitterAccount.AccountDate = twitterAccount.AccountDate;
            bool result = _twitterAccountService.Update(_twitterAccount);
            if (result)
            {
                lbl_AccountUserName.Text = accountUserName;
                lbl_AccountPassword.Text = accountPassword;
                this.twitterAccount = _twitterAccount;
                MessageBox.Show("Düzenleme İşlemi Başarılı");
                TwitterBot twitterBot = (TwitterBot)Application.OpenForms["TwitterBot"];
                twitterBot.FillAccountListBox();
            }
            else
            {
                MessageBox.Show("Bir Hata Oluştu");
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            UpdateTwitterAccount(this.twitterAccount);
        }
    }
}
