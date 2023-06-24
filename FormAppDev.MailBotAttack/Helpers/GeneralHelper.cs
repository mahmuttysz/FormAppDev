using FormAppDev.MailBotAttack.Models;
using System.Text;

namespace FormAppDev.MailBotAttack.Helpers
{
    public static class GeneralHelper
    {
        public static bool IsValidNumber(string txt)
        {
            bool isValid = false;
            char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            for (int i = 0; i < numbers.Length; i++)
            {
                if (txt.Contains(numbers[i].ToString()))
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                }
            }
            return isValid;
        }

        public static void ConfigSave(MailServerInfoModel info)
        {
            var currentPath = Directory.GetCurrentDirectory();
            var sw = new StreamWriter($"{Path.Combine(currentPath, "mailServerConfig.conf")}");

            sw.WriteLine($"MailServerUrl={info.MailServerUrl}");
            sw.WriteLine($"Port={info.Port}");
            sw.WriteLine($"UserName={info.UserName}");
            sw.WriteLine($"Password={info.Password}");

            sw.Close();
        }

        public static MailServerInfoModel ConfigLoad()
        {
            var info = new MailServerInfoModel();
            var currentPath = Directory.GetCurrentDirectory();

            var sr = new StreamReader($"{Path.Combine(currentPath, "mailServerConfig.conf")}");

            string? line = sr.ReadLine();

            while (line != null)
            {
                var lineSplit = line.Split("=");
                if (lineSplit[0] == "MailServerUrl")
                {
                    info.MailServerUrl = lineSplit[1];
                }
                if (lineSplit[0] == "Port")
                {
                    info.Port = Convert.ToInt32(lineSplit[1] ?? "0");
                }
                if (lineSplit[0] == "UserName")
                {
                    info.UserName = lineSplit[1];
                }
                if (lineSplit[0] == "Password")
                {
                    info.Password = lineSplit[1];
                }

                line = sr.ReadLine();
            }

            sr.Close();

            return info;
        }

        public static void LogSave(string logTxt)
        {
            var currentPath = Directory.GetCurrentDirectory();

            if (!File.Exists($"{Path.Combine(currentPath, "logs.log")}"))
            {
                File.Create($"{Path.Combine(currentPath, "logs.log")}").Close();
            }
            var sw = new StreamWriter($"{Path.Combine(currentPath, "logs.log")}", true);
            sw.WriteLine(logTxt);

            sw.Close();
        }
    }
}