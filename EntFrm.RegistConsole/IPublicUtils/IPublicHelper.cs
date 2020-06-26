using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EntFrm.RegistConsole
{
    public class IPublicHelper
    {
        public static void SetConfigValue(string Name, string Value)
        {
            ConfigurationManager.AppSettings.Set(Name, Value);

            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
            config.AppSettings.Settings[Name].Value = Value;
            config.Save(ConfigurationSaveMode.Modified);
            config = null;
        }

        public static string GetConfigValue(string Name)
        {
            try
            {
                return ConfigurationManager.AppSettings[Name].ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
}
