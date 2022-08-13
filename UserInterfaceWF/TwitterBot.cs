using BusinessLogicLayer.Abstract;
using BusinessLogicLayer.Concreate;
using BusinessLogicLayer.Concreate.Selenium;
using Entity.Concreate;
using Entity.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterfaceWF.Utilities;

namespace UserInterfaceWF
{
    public partial class TwitterBot : Form
    {
        ITwitterAccountService _twitterAccountService;
        ITwitterAccountToFollowService _twitterAccountToFollowService;
        ITwitterService _twitterService;
        IConfugrateService _confugrateService;
        IFollowedAccountService _followedAccountService;
        IModemService _modemService;

        public TwitterBot()
        {

            _twitterAccountService = NinjectInstanceFactory.GetInstance<ITwitterAccountService>();
            _twitterAccountToFollowService = NinjectInstanceFactory.GetInstance<ITwitterAccountToFollowService>();
            _confugrateService = NinjectInstanceFactory.GetInstance<IConfugrateService>();
            _followedAccountService = NinjectInstanceFactory.GetInstance<IFollowedAccountService>();
            _modemService = NinjectInstanceFactory.GetInstance<IModemService>();
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        private void TwitterBot_Load(object sender, EventArgs e)
        {
            FillAccountListBox();
            FillTwitterAccountsToFollowListBox();
            FillModemList();
            SetStartingValues();
        }
        private void AddAccount()
        {
            string userName = txt_UserName.Text;
            string userPassword = txt_UserPassword.Text;
            TwitterAccount twitterAccount = new TwitterAccount(userName, userPassword);
            _twitterAccountService.Add(twitterAccount);

            txt_UserName.Text = string.Empty;
            txt_UserPassword.Text = string.Empty;
            FillAccountListBox();
        }
        private void AddTwitterAccountToFollow()
        {
            List<TwitterAccountToFollow> twitterAccountsToFollow = new List<TwitterAccountToFollow>();
            for (int i = 0; i < txt_TwitterAccountToFollow.Lines.Length; i++)
            {
                string twitterAccount = txt_TwitterAccountToFollow.Lines[i];
                if (twitterAccount.StartsWith("@"))
                {
                    string[] resultOfTwitterAccountUserName = twitterAccount.Split('@');
                    twitterAccount = resultOfTwitterAccountUserName[1];
                }
                TwitterAccountToFollow twitterAccountToFollow = new TwitterAccountToFollow(twitterAccount);
                twitterAccountsToFollow.Add(twitterAccountToFollow);
            }
            bool result = _twitterAccountToFollowService.Add(twitterAccountsToFollow);
            if (result)
            {
                txt_TwitterAccountToFollow.Text = string.Empty;
                FillTwitterAccountsToFollowListBox();
            }
        }
        private void DeleteTwitterAccount(object sender)
        {
            ListBox listBox = (ListBox)sender;
            TwitterAccount twitterAccount = (TwitterAccount)listBox.SelectedItem;
            string message = "Kullanıcı Adı: " + twitterAccount.AccountUserName + "\nŞifre: " + twitterAccount.AccountPassword + "\nSilmek istediğinize eminmisiniz ?";
            DialogResult dialogResultDelete = MessageBox.Show(message, "Silmek İstediğinize Eminmisiniz", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResultDelete == DialogResult.Yes)
            {
                bool result = _twitterAccountService.Delete(twitterAccount);
                if (result)
                {
                    FillAccountListBox();
                    MessageBox.Show("Hesap Başarıyla Silindi", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hata Hesap Silinirken Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void DeleteTwitterAccountToFollow(object sender)
        {
            ListBox listBox = (ListBox)sender;
            TwitterAccountToFollow twitterAccountToFollow = (TwitterAccountToFollow)listBox.SelectedItem;
            string message = "Takip edileckler listesindeki" + " @" + twitterAccountToFollow.AccountToFollowUserName + "kullanıcıyı listeden çıkarmak istiyormusunuz ?";
            DialogResult dialogResultDelete = MessageBox.Show(message, "Silmek İstediğinize Eminmisiniz", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dialogResultDelete == DialogResult.Yes)
            {
                bool result = _twitterAccountToFollowService.Delete(twitterAccountToFollow);
                if (result)
                {
                    FillTwitterAccountsToFollowListBox();
                    MessageBox.Show("Kullanıcı Başarıyla Silindi", "Silme Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hata Kullanıcı Silinirken Bir Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void FillAccountListBox()
        {
            _twitterAccountService = NinjectInstanceFactory.GetInstance<ITwitterAccountService>();
            List<TwitterAccount> twitterAccounts = _twitterAccountService.List();
            lstbox_Accounts.DataSource = twitterAccounts;
        }
        public void FillTwitterAccountsToFollowListBox()
        {
            _twitterAccountToFollowService = NinjectInstanceFactory.GetInstance<ITwitterAccountToFollowService>();
            List<TwitterAccountToFollow> twitterAccountToFollows = _twitterAccountToFollowService.List();
            lstbox_TwitterAccountsToFollow.DataSource = twitterAccountToFollows;
        }
        private void FillModemList()
        {
            List<Modems> modems = Enum.GetValues(typeof(Modems)).Cast<Modems>().ToList();
            cmb_ModemBrandModel.DataSource = modems;
        }
        private void SetStartingValues()
        {
            txt_MinValue.Text = _confugrateService.GetMinValue().ToString();
            txt_MaxValue.Text = _confugrateService.GetMaxValue().ToString();
            cmb_ModemBrandModel.SelectedIndex = (int)_confugrateService.GetModem();
            chck_AllowRebootModem.Checked = _confugrateService.GetRebootModeStatus();
            txt_Following_Account_Number.Text = _confugrateService.GetFollowingAccountNumberValue().ToString();
        }
        private void FormClosingProcess()
        {
            try
            {
                if (_twitterService != null)
                {
                    _twitterService.LogOut();
                }
                int minValue = Convert.ToInt32(txt_MinValue.Text);
                int maxValue = Convert.ToInt32(txt_MaxValue.Text);
                _confugrateService.SetMinValue(minValue);
                _confugrateService.SetMaxValue(maxValue);
                Modems modem = (Modems)cmb_ModemBrandModel.SelectedIndex;
                _confugrateService.SetModem(modem);
                bool allowRebootModemStatus = chck_AllowRebootModem.Checked;
                _confugrateService.SetRebootModeStatus(allowRebootModemStatus);
                int followingAccountNumber = Convert.ToInt32(txt_Following_Account_Number.Text);
                _confugrateService.SetFollowingAccountNumberValue(followingAccountNumber);
            }
            catch
            {

            }
        }
        private void AddLog(Log log)
        {
            string logMessage = log.LogMessage;
            string logDateTime = log.LogDateTime.ToString();
            string logMessageToLogger = "-" + logDateTime + " " + logMessage;
            txt_MainLogs.AppendText(logMessageToLogger);
            txt_MainLogs.AppendText(Environment.NewLine);
        }
        int followingAccountNumer = 0;
        private bool LoginToAccount(TwitterAccount twitterAccount)
        {
            try
            {
                followingAccountNumer = Convert.ToInt32(txt_Following_Account_Number.Text);
            }
            catch
            {
                throw new Exception("Lütfen Takip Edilecek Kişi Saysını Tam Sayı Seçiniz ! Örneğin: 1 3 15...");
            }
            try
            {
                _twitterService = NinjectInstanceFactory.GetInstance<ITwitterService>();
                _twitterService.Login(twitterAccount);
                if (_twitterService.IsLogin())
                {
                    string message = "-" + "@" + twitterAccount.AccountUserName + " Kullanıcı adlı hesaba başarıyla giriş yapıldı";
                    Log log = new Log(message);
                    AddLog(log);

                    return true;
                }
                else
                {
                    string message = "-" + "@" + twitterAccount.AccountUserName + " Hata giriş yapılamadı. Kullanıcı Adı veya Şifrenin doğru olduğundan emin olun veya hesap engellenmiş olabailir!";
                    Log log = new Log(message);
                    AddLog(log);
                    return false;
                }
            }
            catch
            {
                string message = "-" + "@" + twitterAccount.AccountUserName + " Hata giriş yapılamadı. Kullanıcı Adı veya Şifrenin doğru olduğundan emin olun veya hesap engellenmiş olabailir!";
                Log log = new Log(message);
                AddLog(log);
                return false;
            }
        }
        private void Follow(int minValue = 0, int maxValue = 0)
        {
            for (int i = 0; i < followingAccountNumer; i++)
            {
                if (Helper.IsConnected() != true)
                {
                    break;
                }
                int J = 0;
                while (true)
                {
                    lstbox_TwitterAccountsToFollow.SelectedIndex = J;
                    lstbox_TwitterAccountsToFollow.Select();
                    TwitterAccountToFollow twitterAccountToFollow2 = lstbox_TwitterAccountsToFollow.SelectedItem as TwitterAccountToFollow;
                    if (_followedAccountService.IsAccountFollowed(twitterAccountToFollow2))
                    {
                        J++;
                        continue;
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(2500);
                        break;
                    }
                }
                TwitterAccountToFollow twitterAccountToFollow = lstbox_TwitterAccountsToFollow.SelectedItem as TwitterAccountToFollow;
                if (_twitterService.FollowingAccountExistOrBlocked(twitterAccountToFollow))
                {
                    bool result = _twitterService.Follow(twitterAccountToFollow, minValue, maxValue);
                    if (result)
                    {
                        string message = "-" + "@" + twitterAccountToFollow.AccountToFollowUserName + " Hesap başarıyla takip edildi";
                        TwitterAccount twitterAccount = lstbox_Accounts.SelectedItem as TwitterAccount;
                        FollowedAccount followedAccount = new FollowedAccount();
                        followedAccount.FollowingAccountId = twitterAccount.AccountId;
                        followedAccount.FollowedAccountId = twitterAccountToFollow.AccountToFollowId;
                        followedAccount.FollowingDate = DateTime.Now;
                        _followedAccountService.Add(followedAccount);
                        Log log = new Log(message);
                        AddLog(log);
                    }
                    else
                    {
                        string message = "-" + "@" + twitterAccountToFollow.AccountToFollowUserName + " Hesap Takipedilirken bir hata oluştu !";
                        Log log = new Log(message);
                        AddLog(log);
                        continue;
                    }
                }
                else
                {
                    string message = "-" + "@" + twitterAccountToFollow.AccountToFollowUserName + " Bu Twitter hesabı yok veya askıya alınmış ! - Bu hesap listeden kaldırıldı";
                    Log log = new Log(message);
                    AddLog(log);
                    if (_twitterAccountToFollowService.Delete(twitterAccountToFollow))
                    {
                        FillTwitterAccountsToFollowListBox();
                    }
                    continue;
                }
                System.Threading.Thread.Sleep(1500);
            }
        }
        private void StartToProcess()
        {
            try
            {
                string minValue = txt_MinValue.Text;
                string maxValue = txt_MaxValue.Text;
                for (; ; )
                {
                    if (Helper.IsConnected())
                    {
                        string message = "İnternet bağlantısı var.";
                        Log log = new Log(message);
                        AddLog(log);
                        for (int i = 0; i < lstbox_Accounts.Items.Count; i++)
                        {
                            if (Helper.IsConnected() != true)
                            {
                                break;
                            }
                            lstbox_Accounts.SelectedIndex = i;
                            lstbox_Accounts.Select();
                            TwitterAccount twitterAccount = lstbox_Accounts.SelectedItem as TwitterAccount;
                            bool result = LoginToAccount(twitterAccount);
                            if (result)
                            {
                                if (minValue != string.Empty && maxValue != string.Empty)
                                {
                                    if (Helper.IsNumber(minValue) && Helper.IsNumber(maxValue))
                                    {
                                        int firtTime = Convert.ToInt32(minValue);
                                        int lastTime = Convert.ToInt32(maxValue);
                                        Follow(firtTime, lastTime);
                                    }
                                }
                                else
                                {
                                    Follow();
                                }
                                _twitterService.LogOut();
                                if (chck_AllowRebootModem.Checked)
                                {
                                    _modemService.Reboot();
                                }
                                txt_MainLogs.AppendText("---------------------------------------------------------------------------------------");
                                txt_MainLogs.AppendText(Environment.NewLine);
                            }
                            else
                            {
                                _twitterService.LogOut();
                                if (chck_AllowRebootModem.Checked)
                                {
                                    _modemService.Reboot();
                                }
                                txt_MainLogs.AppendText("---------------------------------------------------------------------------------------");
                                txt_MainLogs.AppendText(Environment.NewLine);
                                continue;
                            }
                            if (i == lstbox_Accounts.Items.Count)
                            {
                                break;
                            }
                        }
                    }
                    else
                    {
                        string message = "İNTERNET BAĞLANTISI YOK ! 2000ms sonra tekrar bağlanmayı deneyecek.";
                        Log log = new Log(message);
                        AddLog(log);
                        System.Threading.Thread.Sleep(2000);
                        continue;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            AddAccount();
        }
        private void btn_AddTwitterAccountToFollow_Click(object sender, EventArgs e)
        {
            AddTwitterAccountToFollow();
        }

        private void lstbox_Accounts_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DeleteTwitterAccount(sender);
        }

        private void lstbox_TwitterAccountsToFollow_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DeleteTwitterAccountToFollow(sender);
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListBox listBox = lstbox_Accounts;
            TwitterAccount twitterAccount = (TwitterAccount)listBox.SelectedItem;
            UpdateAccount updateAccount = new UpdateAccount(twitterAccount);
            updateAccount.ShowDialog();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            object senderForDeleteTwitterAccount = lstbox_Accounts;
            DeleteTwitterAccount(senderForDeleteTwitterAccount);
        }
        private void düzenleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListBox listBox = lstbox_TwitterAccountsToFollow;
            TwitterAccountToFollow twitterAccountToFollow = (TwitterAccountToFollow)listBox.SelectedItem;
            UpdateAccountToFollow updateAccountToFollow = new UpdateAccountToFollow(twitterAccountToFollow);
            updateAccountToFollow.ShowDialog();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            object senderForDeleteTwitterAccountToFollow = lstbox_TwitterAccountsToFollow;
            DeleteTwitterAccountToFollow(senderForDeleteTwitterAccountToFollow);
        }
        private void btn_Start_Click(object sender, EventArgs e)
        {
            Task task = Task.Run(() => StartToProcess());
        }
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            _twitterService.LogOut();
        }
        private void TwitterBot_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormClosingProcess();
        }

        private void btn_RebootModem_Click(object sender, EventArgs e)
        {
            try
            {
                 _modemService.Reboot();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
