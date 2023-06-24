using FormAppDev.MailBotAttack.Models;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MailKit.Security;

namespace FormAppDev.MailBotAttack.Helpers
{
    public static class MailHelper
    {
        public static async Task<string> ConnectSmtpMailServer(MailServerInfoModel info)
        {
            string response = "";
            var client = new SmtpClient()
            {
                CheckCertificateRevocation = true,
                ServerCertificateValidationCallback = (s, c, h, e) => true
            };
            try
            {
                await client.ConnectAsync(info.MailServerUrl, info.Port, SecureSocketOptions.Auto);
                await client.AuthenticateAsync(info.UserName, info.Password);
                response = client.IsConnected.ToString();
                client.Disconnect(true);
            }
            catch (Exception ex)
            {
                GeneralHelper.LogSave($"{ex.Message} - {DateTime.Now}");
            }

            return response ?? "";
        }

        public static async Task<string> ConnectImapMailServer(MailServerInfoModel info)
        {
            string response = "";
            var client = new ImapClient()
            {
                CheckCertificateRevocation = true,
                ServerCertificateValidationCallback = (s, c, h, e) => true
            };
            try
            {
                await client.ConnectAsync(info.MailServerUrl, info.Port, SecureSocketOptions.Auto);
                await client.AuthenticateAsync(info.UserName, info.Password);
                response = client.IsConnected.ToString();
                client.Disconnect(true);
            }
            catch (Exception ex)
            {
                GeneralHelper.LogSave($"{ex.Message} - {DateTime.Now}");
            }

            return response ?? "";
        }

        public static async Task<string> ConnectPopMailServer(MailServerInfoModel info)
        {
            string response = "";
            var client = new Pop3Client()
            {
                CheckCertificateRevocation = true,
                ServerCertificateValidationCallback = (s, c, h, e) => true
            };
            try
            {
                await client.ConnectAsync(info.MailServerUrl, info.Port, SecureSocketOptions.Auto);
                await client.AuthenticateAsync(info.UserName, info.Password);
                response = client.IsConnected.ToString();
                client.Disconnect(true);
            }
            catch (Exception ex)
            {
                GeneralHelper.LogSave($"{ex.Message} - {DateTime.Now}");
            }

            return response ?? "";
        }
    }
}