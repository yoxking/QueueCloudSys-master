using EntFrm.Business.BLL;
using EntFrm.Business.Model;
using EntFrm.Business.Model.Collections;
using EntFrm.Framework.Utility; 
using EntFrm.Framework.Web;
using System;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace EntWeb.BkConsole
{
    public class PublicHelper
    {
        public static string Get_AppCode()
        {
            return GetConfigValue("AppCode");
        }

        public static string Get_ConnStr()
        {
            string connStr = ConfigurationManager.AppSettings["SqlServer"].ToString();

            return EnconfigHelper.Decrypt(connStr);

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

        public static void SetConfigValue(string Name, string Value)
        {
            try
            {
                Configuration config = WebConfigurationManager.OpenWebConfiguration(HttpContext.Current.Request.ApplicationPath);
                var appSetting = (AppSettingsSection)config.GetSection("appSettings");
                if (appSetting.Settings[Name] == null) //如果不存在此节点，则添加   
                {
                    appSetting.Settings.Add(Name, Value);
                }
                else //如果存在此节点，则修改   
                {
                    appSetting.Settings[Name].Value = Value;
                }
                config.Save(ConfigurationSaveMode.Modified);
                config = null;
            }
            catch (Exception ex) { }
        } 

        public static bool SetParamValue(string sName, string sValue, string sType = "2")
        {
            if (sName.Length > 0 && sValue.Length > 0)
            {
                try
                {
                    string sSuNo = "00000000";

                    int count = 0;
                    SysParams info = null;
                    SysParamsBLL infoBLL = new SysParamsBLL(Get_ConnStr(), Get_AppCode());
                    SysParamsCollections infoColl = infoBLL.GetRecordsByPaging(ref count, 1, 1, "  KeyName='" + sName + "' And KeyType='" + sType + "' ");

                    if (infoColl != null && infoColl.Count > 0)
                    {
                        info = infoColl.GetFirstOne();

                        info.sKeyValue = sValue;
                        info.sModOptor = sSuNo;
                        info.dModDate = DateTime.Now;

                        return infoBLL.UpdateRecord(info);
                    }
                    else
                    {
                        info = new SysParams();

                        info.sParamNo = CommonHelper.Get_New12ByteGuid();
                        info.sKeyName = sName;
                        info.sKeyValue = sValue;
                        info.sKeyType = sType;
                        info.sBranchNo = "";

                        info.sAddOptor = sSuNo;
                        info.dAddDate = DateTime.Now;
                        info.sModOptor = sSuNo;
                        info.dModDate = DateTime.Now;
                        info.iValidityState = 1;
                        info.sComments = "";

                        info.sAppCode = Get_AppCode() + ";";

                        return infoBLL.AddNewRecord(info);
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return false;
        }

        public static string GetParamValue(string sName, string sType = "2")
        {
            if (sName.Length > 0)
            {
                try
                {
                    int count = 0;
                    SysParamsBLL infoBLL = new SysParamsBLL(Get_ConnStr(), Get_AppCode());
                    SysParamsCollections infoColl = infoBLL.GetRecordsByPaging(ref count, 1, 1, "  KeyName='" + sName + "' And KeyType='" + sType + "' ");
                    if (infoColl != null && infoColl.Count > 0)
                    {
                        return infoColl.GetFirstOne().sKeyValue;
                    }

                    return "";
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
            return "";
        } 

        public static void AddLogRecord(string logtitle,string logcontent)
        {
            string sSuNo = "";

            LogsInfoBLL infoBLL = new LogsInfoBLL(Get_ConnStr(), Get_AppCode());
            LogsInfo info = new LogsInfo();

            info.sLogNo = CommonHelper.Get_New12ByteGuid();
            info.sLogTitle = logtitle;
            info.sClassNo = "";
            info.sGradeNo = "";
            info.sLContent = logcontent;
            info.sIpAddress = "";
            info.sLocation = "";
            info.iCheckState = 0;
            info.sBranchNo = "";

            info.sAddOptor = sSuNo;
            info.dAddDate = DateTime.Now;
            info.sModOptor = sSuNo;
            info.dModDate = DateTime.Now;
            info.iValidityState = 1;
            info.sAppCode = PublicHelper.Get_AppCode() + ";";


            infoBLL.AddNewRecord(info);
        }

    }
}