using FormAppDev.MailBotAttack.Helpers;
using FormAppDev.MailBotAttack.Models;

namespace FormAppDev.MailBotAttack
{
    public partial class FrmMailBotAttack : Form
    {
        private bool IsCancel { get; set; }
        private MailServerType _mailServerType;

        public FrmMailBotAttack()
        {
            InitializeComponent();
            IsCancel = false;
        }

        private void FrmMailBotAttack_Load(object sender, EventArgs e)
        {
            string currentPath = Directory.GetCurrentDirectory();

            if (!File.Exists($"{Path.Combine(currentPath, "mailServerConfig.conf")}"))
            {
                GeneralHelper.ConfigSave(new MailServerInfoModel());
            }
            RdSmtpSrv.Checked = true;
            TxtPort.Text = "587";
            TxtConnectionTry.Text = "1";
            BtnAttackCancel.Enabled = false;
            IsParameterNull();
            ChangeMailServerType();
        }

        private async void BtnAttackStart_Click(object sender, EventArgs e)
        {
            ListResult.Items.Clear();
            TxtServerUrl.Enabled = false;
            TxtPort.Enabled = false;
            TxtUserName.Enabled = false;
            TxtPassword.Enabled = false;
            TxtConnectionTry.Enabled = false;
            BtnAttackCancel.Enabled = true;
            BtnAttackStart.Enabled = false;
            int connectionTry = Convert.ToInt32(TxtConnectionTry.Text ?? "0");
            prgStatus.Visible = true;
            prgStatus.Minimum = 0;
            prgStatus.Maximum = connectionTry;
            prgStatus.Step = 1;
            var mailServerInfo = new MailServerInfoModel()
            {
                MailServerUrl = TxtServerUrl.Text,
                Port = Convert.ToInt32(TxtPort.Text ?? "0"),
                UserName = TxtUserName.Text,
                Password = TxtPassword.Text
            };

            for (int i = 0; i < connectionTry; i++)
            {
                string attack = _mailServerType switch
                {
                    MailServerType.Smtp => await MailHelper.ConnectSmtpMailServer(mailServerInfo),
                    MailServerType.Imap => await MailHelper.ConnectImapMailServer(mailServerInfo),
                    MailServerType.Pop => await MailHelper.ConnectPopMailServer(mailServerInfo),
                    _ => await MailHelper.ConnectSmtpMailServer(mailServerInfo)
                };

                string response = attack.Trim() == "True" ? "Başarılı" : "Hata!";
                ListResult.Items.Add($"{response} - {DateTime.Now}");
                LblStatus.Text = $"İşlem Yapılıyor... ({i + 1} / {connectionTry})";
                prgStatus.PerformStep();

                GeneralHelper.LogSave($"{TxtServerUrl} - {response} - {DateTime.Now}");
                if (IsCancel)
                {
                    break;
                }
            }
            IsParameterNull();
            BtnAttackCancel.Enabled = false;
            TxtServerUrl.Enabled = true;
            TxtPort.Enabled = true;
            TxtUserName.Enabled = true;
            TxtPassword.Enabled = true;
            TxtConnectionTry.Enabled = true;
            LblStatus.Text = "İşlem Tamamlandı.";
        }

        private void BtnAttackCancel_Click(object sender, EventArgs e)
        {
            IsCancel = true;
            BtnAttackCancel.Enabled = false;
            IsParameterNull();
            TxtServerUrl.Enabled = true;
            TxtPort.Enabled = true;
            TxtUserName.Enabled = true;
            TxtPassword.Enabled = true;
            TxtConnectionTry.Enabled = true;
            MessageBox.Show("İşlem İptal Edildi!");
            LblStatus.Text = "İşlem İptal Edildi.";
            prgStatus.Value = 0;
        }

        private void RdSmtpSrv_CheckedChanged(object sender, EventArgs e)
        {
            TxtPort.Text = "587";
            ChangeMailServerType();
        }

        private void RdImapSrv_CheckedChanged(object sender, EventArgs e)
        {
            TxtPort.Text = "993";
            ChangeMailServerType();
        }

        private void RdPopSrv_CheckedChanged(object sender, EventArgs e)
        {
            TxtPort.Text = "143";
            ChangeMailServerType();
        }

        private void TxtServerUrl_TextChanged(object sender, EventArgs e)
        {
            IsParameterNull();
        }

        private void TxtPort_TextChanged(object sender, EventArgs e)
        {
            IsParameterNull();
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            IsParameterNull();
        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            IsParameterNull();
        }

        private void TxtConnectionTry_TextChanged(object sender, EventArgs e)
        {
            IsParameterNull();
        }

        private void BtnConfigLoad_Click(object sender, EventArgs e)
        {
            var load = GeneralHelper.ConfigLoad();
            if (load != null)
            {
                TxtServerUrl.Text = load.MailServerUrl;
                TxtPort.Text = load.Port.ToString();
                TxtUserName.Text = load.UserName;
                TxtPassword.Text = load.Password;
            }

            MessageBox.Show("Ayarlar Yüklendi.");
        }

        private void BtnConfigSave_Click(object sender, EventArgs e)
        {
            var mailServerInfo = new MailServerInfoModel()
            {
                MailServerUrl = TxtServerUrl.Text,
                Port = Convert.ToInt32(TxtPort.Text ?? "0"),
                UserName = TxtUserName.Text,
                Password = TxtPassword.Text
            };
            GeneralHelper.ConfigSave(mailServerInfo);

            MessageBox.Show("Ayarlar Kaydedildi.");
        }

        private void IsParameterNull()
        {
            if (TxtServerUrl.Text == string.Empty || TxtPort.Text == string.Empty || TxtUserName.Text == string.Empty || TxtPassword.Text == string.Empty || TxtConnectionTry.Text == string.Empty)
            {
                BtnAttackStart.Enabled = false;
            }
            else
            {
                BtnAttackStart.Enabled = true;
            }
        }

        private void ChangeMailServerType()
        {
            if (RdSmtpSrv.Checked)
            {
                _mailServerType = MailServerType.Smtp;
            }
            else if (RdImapSrv.Checked)
            {
                _mailServerType = MailServerType.Imap;
            }
            else if (RdPopSrv.Checked)
            {
                _mailServerType = MailServerType.Pop;
            }
            else
            {
                _mailServerType = MailServerType.Smtp;
            }
        }
    }
}