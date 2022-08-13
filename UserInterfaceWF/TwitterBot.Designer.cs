
namespace UserInterfaceWF
{
    partial class TwitterBot
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TwitterBot));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstbox_Accounts = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_AccountListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddTwitterAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_UserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.txt_TwitterAccountToFollow = new System.Windows.Forms.TextBox();
            this.btn_AddTwitterAccountToFollow = new System.Windows.Forms.Button();
            this.lstbox_TwitterAccountsToFollow = new System.Windows.Forms.ListBox();
            this.contextMenuStrip_AccountToFollowListBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.silToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Following_Account_Number = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaxValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MinValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MainLogs = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chck_AllowRebootModem = new System.Windows.Forms.CheckBox();
            this.cmb_ModemBrandModel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_RebootModem = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip_AccountListBox.SuspendLayout();
            this.contextMenuStrip_AccountToFollowListBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstbox_Accounts);
            this.groupBox1.Controls.Add(this.btn_AddTwitterAccount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_UserPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hesaplar";
            // 
            // lstbox_Accounts
            // 
            this.lstbox_Accounts.ContextMenuStrip = this.contextMenuStrip_AccountListBox;
            this.lstbox_Accounts.FormattingEnabled = true;
            this.lstbox_Accounts.Location = new System.Drawing.Point(9, 111);
            this.lstbox_Accounts.Name = "lstbox_Accounts";
            this.lstbox_Accounts.Size = new System.Drawing.Size(234, 264);
            this.lstbox_Accounts.TabIndex = 5;
            this.lstbox_Accounts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbox_Accounts_MouseDoubleClick);
            // 
            // contextMenuStrip_AccountListBox
            // 
            this.contextMenuStrip_AccountListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip_AccountListBox.Name = "contextMenuStrip_AccountListBox";
            this.contextMenuStrip_AccountListBox.Size = new System.Drawing.Size(117, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // btn_AddTwitterAccount
            // 
            this.btn_AddTwitterAccount.Location = new System.Drawing.Point(9, 77);
            this.btn_AddTwitterAccount.Name = "btn_AddTwitterAccount";
            this.btn_AddTwitterAccount.Size = new System.Drawing.Size(234, 28);
            this.btn_AddTwitterAccount.TabIndex = 4;
            this.btn_AddTwitterAccount.Text = "Hesabı Ekle";
            this.btn_AddTwitterAccount.UseVisualStyleBackColor = true;
            this.btn_AddTwitterAccount.Click += new System.EventHandler(this.btn_AddAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kullanıcı Şifre";
            // 
            // txt_UserPassword
            // 
            this.txt_UserPassword.Location = new System.Drawing.Point(76, 51);
            this.txt_UserPassword.Name = "txt_UserPassword";
            this.txt_UserPassword.Size = new System.Drawing.Size(167, 20);
            this.txt_UserPassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(76, 25);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(167, 20);
            this.txt_UserName.TabIndex = 0;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Start.Location = new System.Drawing.Point(12, 498);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(85, 23);
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "Başlat";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(103, 498);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Duraklat";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Stop.Location = new System.Drawing.Point(184, 498);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(77, 23);
            this.btn_Stop.TabIndex = 4;
            this.btn_Stop.Text = "Durdur";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // txt_TwitterAccountToFollow
            // 
            this.txt_TwitterAccountToFollow.Location = new System.Drawing.Point(669, 12);
            this.txt_TwitterAccountToFollow.Multiline = true;
            this.txt_TwitterAccountToFollow.Name = "txt_TwitterAccountToFollow";
            this.txt_TwitterAccountToFollow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_TwitterAccountToFollow.Size = new System.Drawing.Size(237, 105);
            this.txt_TwitterAccountToFollow.TabIndex = 5;
            // 
            // btn_AddTwitterAccountToFollow
            // 
            this.btn_AddTwitterAccountToFollow.Location = new System.Drawing.Point(669, 120);
            this.btn_AddTwitterAccountToFollow.Name = "btn_AddTwitterAccountToFollow";
            this.btn_AddTwitterAccountToFollow.Size = new System.Drawing.Size(237, 32);
            this.btn_AddTwitterAccountToFollow.TabIndex = 6;
            this.btn_AddTwitterAccountToFollow.Text = "Hesapları Ekle";
            this.btn_AddTwitterAccountToFollow.UseVisualStyleBackColor = true;
            this.btn_AddTwitterAccountToFollow.Click += new System.EventHandler(this.btn_AddTwitterAccountToFollow_Click);
            // 
            // lstbox_TwitterAccountsToFollow
            // 
            this.lstbox_TwitterAccountsToFollow.ContextMenuStrip = this.contextMenuStrip_AccountToFollowListBox;
            this.lstbox_TwitterAccountsToFollow.FormattingEnabled = true;
            this.lstbox_TwitterAccountsToFollow.Location = new System.Drawing.Point(669, 155);
            this.lstbox_TwitterAccountsToFollow.Name = "lstbox_TwitterAccountsToFollow";
            this.lstbox_TwitterAccountsToFollow.Size = new System.Drawing.Size(237, 238);
            this.lstbox_TwitterAccountsToFollow.TabIndex = 6;
            this.lstbox_TwitterAccountsToFollow.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstbox_TwitterAccountsToFollow_MouseDoubleClick);
            // 
            // contextMenuStrip_AccountToFollowListBox
            // 
            this.contextMenuStrip_AccountToFollowListBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem1,
            this.silToolStripMenuItem1});
            this.contextMenuStrip_AccountToFollowListBox.Name = "contextMenuStrip_AccountToFollowListBox";
            this.contextMenuStrip_AccountToFollowListBox.Size = new System.Drawing.Size(117, 48);
            // 
            // düzenleToolStripMenuItem1
            // 
            this.düzenleToolStripMenuItem1.Name = "düzenleToolStripMenuItem1";
            this.düzenleToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.düzenleToolStripMenuItem1.Text = "Düzenle";
            this.düzenleToolStripMenuItem1.Click += new System.EventHandler(this.düzenleToolStripMenuItem1_Click);
            // 
            // silToolStripMenuItem1
            // 
            this.silToolStripMenuItem1.Name = "silToolStripMenuItem1";
            this.silToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.silToolStripMenuItem1.Text = "Sil";
            this.silToolStripMenuItem1.Click += new System.EventHandler(this.silToolStripMenuItem1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Following_Account_Number);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_MaxValue);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_MinValue);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 397);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 95);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Takip Ayarları";
            // 
            // txt_Following_Account_Number
            // 
            this.txt_Following_Account_Number.Location = new System.Drawing.Point(342, 15);
            this.txt_Following_Account_Number.Name = "txt_Following_Account_Number";
            this.txt_Following_Account_Number.Size = new System.Drawing.Size(64, 20);
            this.txt_Following_Account_Number.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(245, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Takip Etme Sayısı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(202, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(202, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Verilen iki değer aralğındaki sürelerde rastgele \r\ntakip eder. (1Saniye = 1000Ms)" +
    "";
            // 
            // txt_MaxValue
            // 
            this.txt_MaxValue.Location = new System.Drawing.Point(125, 39);
            this.txt_MaxValue.Name = "txt_MaxValue";
            this.txt_MaxValue.Size = new System.Drawing.Size(71, 20);
            this.txt_MaxValue.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Takip Et Bitiş Ms";
            // 
            // txt_MinValue
            // 
            this.txt_MinValue.Location = new System.Drawing.Point(125, 15);
            this.txt_MinValue.Name = "txt_MinValue";
            this.txt_MinValue.Size = new System.Drawing.Size(71, 20);
            this.txt_MinValue.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Takip Et Başlangıç Ms";
            // 
            // txt_MainLogs
            // 
            this.txt_MainLogs.BackColor = System.Drawing.Color.White;
            this.txt_MainLogs.Location = new System.Drawing.Point(267, 12);
            this.txt_MainLogs.Multiline = true;
            this.txt_MainLogs.Name = "txt_MainLogs";
            this.txt_MainLogs.ReadOnly = true;
            this.txt_MainLogs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_MainLogs.Size = new System.Drawing.Size(396, 381);
            this.txt_MainLogs.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.chck_AllowRebootModem);
            this.groupBox3.Controls.Add(this.cmb_ModemBrandModel);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(430, 397);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 95);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "IP Resetleme Ayarları";
            // 
            // chck_AllowRebootModem
            // 
            this.chck_AllowRebootModem.AutoSize = true;
            this.chck_AllowRebootModem.Location = new System.Drawing.Point(6, 74);
            this.chck_AllowRebootModem.Name = "chck_AllowRebootModem";
            this.chck_AllowRebootModem.Size = new System.Drawing.Size(216, 17);
            this.chck_AllowRebootModem.TabIndex = 2;
            this.chck_AllowRebootModem.Text = "Her Hesap Değişiminde Modemi Resetle";
            this.chck_AllowRebootModem.UseVisualStyleBackColor = true;
            // 
            // cmb_ModemBrandModel
            // 
            this.cmb_ModemBrandModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ModemBrandModel.FormattingEnabled = true;
            this.cmb_ModemBrandModel.Items.AddRange(new object[] {
            "Keenetic Modems"});
            this.cmb_ModemBrandModel.Location = new System.Drawing.Point(54, 15);
            this.cmb_ModemBrandModel.Name = "cmb_ModemBrandModel";
            this.cmb_ModemBrandModel.Size = new System.Drawing.Size(204, 21);
            this.cmb_ModemBrandModel.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Modem";
            // 
            // btn_RebootModem
            // 
            this.btn_RebootModem.Location = new System.Drawing.Point(430, 498);
            this.btn_RebootModem.Name = "btn_RebootModem";
            this.btn_RebootModem.Size = new System.Drawing.Size(264, 23);
            this.btn_RebootModem.TabIndex = 11;
            this.btn_RebootModem.Text = "Modem Resetle";
            this.btn_RebootModem.UseVisualStyleBackColor = true;
            this.btn_RebootModem.Click += new System.EventHandler(this.btn_RebootModem_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(4, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 26);
            this.label10.TabIndex = 3;
            this.label10.Text = "Telnet ile resetler. \r\nŞimdilik sadece kenetic modem destekler.";
            // 
            // TwitterBot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 535);
            this.Controls.Add(this.btn_RebootModem);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txt_MainLogs);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lstbox_TwitterAccountsToFollow);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.btn_AddTwitterAccountToFollow);
            this.Controls.Add(this.txt_TwitterAccountToFollow);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TwitterBot";
            this.Text = "Twitter Bot V 1.00";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TwitterBot_FormClosed);
            this.Load += new System.EventHandler(this.TwitterBot_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.contextMenuStrip_AccountListBox.ResumeLayout(false);
            this.contextMenuStrip_AccountToFollowListBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstbox_Accounts;
        private System.Windows.Forms.Button btn_AddTwitterAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_UserPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_Stop;
        private System.Windows.Forms.TextBox txt_TwitterAccountToFollow;
        private System.Windows.Forms.Button btn_AddTwitterAccountToFollow;
        private System.Windows.Forms.ListBox lstbox_TwitterAccountsToFollow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_MaxValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MinValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_AccountListBox;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_AccountToFollowListBox;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem1;
        private System.Windows.Forms.TextBox txt_MainLogs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chck_AllowRebootModem;
        private System.Windows.Forms.ComboBox cmb_ModemBrandModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Following_Account_Number;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_RebootModem;
        private System.Windows.Forms.Label label10;
    }
}