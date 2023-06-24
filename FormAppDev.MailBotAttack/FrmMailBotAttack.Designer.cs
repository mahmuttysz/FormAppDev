namespace FormAppDev.MailBotAttack
{
    partial class FrmMailBotAttack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMailBotAttack));
            label5 = new Label();
            RdPopSrv = new RadioButton();
            RdImapSrv = new RadioButton();
            RdSmtpSrv = new RadioButton();
            ListResult = new ListBox();
            BtnAttackCancel = new Button();
            BtnAttackStart = new Button();
            TxtPassword = new TextBox();
            TxtUserName = new TextBox();
            TxtPort = new TextBox();
            TxtServerUrl = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            TxtConnectionTry = new TextBox();
            label6 = new Label();
            LblStatus = new Label();
            prgStatus = new ProgressBar();
            BtnConfigLoad = new Button();
            BtnConfigSave = new Button();
            label8 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 12);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 65;
            label5.Text = "Sunucu Tipi : ";
            // 
            // RdPopSrv
            // 
            RdPopSrv.AutoSize = true;
            RdPopSrv.Location = new Point(258, 10);
            RdPopSrv.Name = "RdPopSrv";
            RdPopSrv.Size = new Size(48, 19);
            RdPopSrv.TabIndex = 64;
            RdPopSrv.TabStop = true;
            RdPopSrv.Text = "POP";
            RdPopSrv.UseVisualStyleBackColor = true;
            RdPopSrv.CheckedChanged += RdPopSrv_CheckedChanged;
            // 
            // RdImapSrv
            // 
            RdImapSrv.AutoSize = true;
            RdImapSrv.Location = new Point(183, 10);
            RdImapSrv.Name = "RdImapSrv";
            RdImapSrv.Size = new Size(54, 19);
            RdImapSrv.TabIndex = 63;
            RdImapSrv.TabStop = true;
            RdImapSrv.Text = "IMAP";
            RdImapSrv.UseVisualStyleBackColor = true;
            RdImapSrv.CheckedChanged += RdImapSrv_CheckedChanged;
            // 
            // RdSmtpSrv
            // 
            RdSmtpSrv.AutoSize = true;
            RdSmtpSrv.Location = new Point(105, 10);
            RdSmtpSrv.Name = "RdSmtpSrv";
            RdSmtpSrv.Size = new Size(55, 19);
            RdSmtpSrv.TabIndex = 62;
            RdSmtpSrv.TabStop = true;
            RdSmtpSrv.Text = "SMTP";
            RdSmtpSrv.UseVisualStyleBackColor = true;
            RdSmtpSrv.CheckedChanged += RdSmtpSrv_CheckedChanged;
            // 
            // ListResult
            // 
            ListResult.FormattingEnabled = true;
            ListResult.ItemHeight = 15;
            ListResult.Location = new Point(33, 285);
            ListResult.Name = "ListResult";
            ListResult.Size = new Size(273, 184);
            ListResult.TabIndex = 61;
            // 
            // BtnAttackCancel
            // 
            BtnAttackCancel.BackColor = SystemColors.Control;
            BtnAttackCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAttackCancel.ForeColor = SystemColors.ControlText;
            BtnAttackCancel.Location = new Point(33, 231);
            BtnAttackCancel.Name = "BtnAttackCancel";
            BtnAttackCancel.Size = new Size(94, 34);
            BtnAttackCancel.TabIndex = 60;
            BtnAttackCancel.Text = "İptal Et";
            BtnAttackCancel.UseVisualStyleBackColor = false;
            BtnAttackCancel.Click += BtnAttackCancel_Click;
            // 
            // BtnAttackStart
            // 
            BtnAttackStart.BackColor = SystemColors.Control;
            BtnAttackStart.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            BtnAttackStart.Location = new Point(212, 231);
            BtnAttackStart.Name = "BtnAttackStart";
            BtnAttackStart.Size = new Size(94, 34);
            BtnAttackStart.TabIndex = 59;
            BtnAttackStart.Text = "Atak Başlat";
            BtnAttackStart.UseVisualStyleBackColor = false;
            BtnAttackStart.Click += BtnAttackStart_Click;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(105, 122);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(201, 23);
            TxtPassword.TabIndex = 58;
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // TxtUserName
            // 
            TxtUserName.Location = new Point(105, 93);
            TxtUserName.Name = "TxtUserName";
            TxtUserName.Size = new Size(201, 23);
            TxtUserName.TabIndex = 57;
            TxtUserName.TextChanged += TxtUserName_TextChanged;
            // 
            // TxtPort
            // 
            TxtPort.Location = new Point(105, 64);
            TxtPort.Name = "TxtPort";
            TxtPort.Size = new Size(201, 23);
            TxtPort.TabIndex = 56;
            TxtPort.TextChanged += TxtPort_TextChanged;
            // 
            // TxtServerUrl
            // 
            TxtServerUrl.Location = new Point(105, 35);
            TxtServerUrl.Name = "TxtServerUrl";
            TxtServerUrl.Size = new Size(201, 23);
            TxtServerUrl.TabIndex = 55;
            TxtServerUrl.TextChanged += TxtServerUrl_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 130);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 54;
            label4.Text = "Şifre : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 101);
            label3.Name = "label3";
            label3.Size = new Size(82, 15);
            label3.TabIndex = 53;
            label3.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 71);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 52;
            label2.Text = "Port : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 38);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 51;
            label1.Text = "Server Url : ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 193);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 68;
            label7.Text = "Atak Sayısı : ";
            // 
            // TxtConnectionTry
            // 
            TxtConnectionTry.Location = new Point(102, 185);
            TxtConnectionTry.Name = "TxtConnectionTry";
            TxtConnectionTry.Size = new Size(204, 23);
            TxtConnectionTry.TabIndex = 69;
            TxtConnectionTry.TextChanged += TxtConnectionTry_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 521);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 70;
            label6.Text = "Durum : ";
            // 
            // LblStatus
            // 
            LblStatus.AutoSize = true;
            LblStatus.Location = new Point(88, 521);
            LblStatus.Name = "LblStatus";
            LblStatus.Size = new Size(34, 15);
            LblStatus.TabIndex = 71;
            LblStatus.Text = "Hazır";
            // 
            // prgStatus
            // 
            prgStatus.Location = new Point(33, 485);
            prgStatus.Name = "prgStatus";
            prgStatus.Size = new Size(273, 23);
            prgStatus.TabIndex = 72;
            // 
            // BtnConfigLoad
            // 
            BtnConfigLoad.Location = new Point(33, 156);
            BtnConfigLoad.Name = "BtnConfigLoad";
            BtnConfigLoad.Size = new Size(93, 23);
            BtnConfigLoad.TabIndex = 73;
            BtnConfigLoad.Text = "Ayarları Yükle";
            BtnConfigLoad.UseVisualStyleBackColor = true;
            BtnConfigLoad.Click += BtnConfigLoad_Click;
            // 
            // BtnConfigSave
            // 
            BtnConfigSave.Location = new Point(212, 156);
            BtnConfigSave.Name = "BtnConfigSave";
            BtnConfigSave.Size = new Size(94, 23);
            BtnConfigSave.TabIndex = 74;
            BtnConfigSave.Text = "Ayarları Kaydet";
            BtnConfigSave.UseVisualStyleBackColor = true;
            BtnConfigSave.Click += BtnConfigSave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(223, 546);
            label8.Name = "label8";
            label8.Size = new Size(104, 15);
            label8.TabIndex = 75;
            label8.Text = "Created © ByNeo";
            // 
            // FrmMailBotAttack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 570);
            Controls.Add(label8);
            Controls.Add(BtnConfigSave);
            Controls.Add(BtnConfigLoad);
            Controls.Add(prgStatus);
            Controls.Add(LblStatus);
            Controls.Add(label6);
            Controls.Add(TxtConnectionTry);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(RdPopSrv);
            Controls.Add(RdImapSrv);
            Controls.Add(RdSmtpSrv);
            Controls.Add(ListResult);
            Controls.Add(BtnAttackCancel);
            Controls.Add(BtnAttackStart);
            Controls.Add(TxtPassword);
            Controls.Add(TxtUserName);
            Controls.Add(TxtPort);
            Controls.Add(TxtServerUrl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMailBotAttack";
            Text = "Mail Bot Attack v1.0";
            Load += FrmMailBotAttack_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private RadioButton RdPopSrv;
        private RadioButton RdImapSrv;
        private RadioButton RdSmtpSrv;
        private ListBox ListResult;
        private Button BtnAttackCancel;
        private Button BtnAttackStart;
        private TextBox TxtPassword;
        private TextBox TxtUserName;
        private TextBox TxtPort;
        private TextBox TxtServerUrl;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox TxtConnectionTry;
        private Label label6;
        private Label LblStatus;
        private ProgressBar prgStatus;
        private Button BtnConfigLoad;
        private Button BtnConfigSave;
        private Label label8;
    }
}