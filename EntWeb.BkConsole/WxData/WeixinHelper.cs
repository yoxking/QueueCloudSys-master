using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntWeb.BkConsole.WxData
{
    public class WeixinHelper
    {
        #region 微信公众号

        public static void doSendMessage(string access_token, string openId, string content)
        {
            string url = WeixinConst.POST_WEIXIN_MESSAGE_URL.Replace("ACCESS_TOKEN", access_token);
            string s = "{\"touser\":\""+ openId + "\",\"msgtype\":\"text\",\"text\":{\"content\":\""+ content + "\"}}";
            WhttpHelper.HttpPost("https://api.weixin.qq.com/cgi-bin/message/custom/send?access_token=ACCESS_TOKEN", s);

        }

        public static string getAccessToken()
        {
            try
            { 
                int iExpiresIn = 7200;
                TimeSpan ts = DateTime.Now - DateTime.Now.AddHours(-5);

                string wxAccessToken = PublicHelper.GetParamValue("AccessToken", "WxData");
                string wxAccessDTime = PublicHelper.GetParamValue("AccessDTime", "WxData");
                if (!string.IsNullOrEmpty(wxAccessDTime))
                {
                    ts = DateTime.Now - DateTime.Parse(wxAccessDTime);
                }

                if (ts.TotalSeconds >= iExpiresIn)
                {
                    string weixinAppId = PublicHelper.GetConfigValue("WeixinAppID");
                    string weixinSecret = PublicHelper.GetConfigValue("WeixinSecret");

                    string url = WeixinConst.ACCESS_TOKEN_URL.Replace("APPID", weixinAppId).Replace("APPSECRET", weixinSecret);

                    string s = WhttpHelper.HttpGet(url);

                    WxAccessToken accessToken = JsonConvert.DeserializeObject<WxAccessToken>(s);

                    if (accessToken.errcode == 0)
                    {
                        wxAccessToken = accessToken.access_token;

                        PublicHelper.SetParamValue("AccessToken", wxAccessToken, "WxData");
                        PublicHelper.SetParamValue("AccessDTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "WxData");
                    }
                }

                return wxAccessToken;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string getUserId(string code)
        {
            string weixinAppId = PublicHelper.GetConfigValue("WeixinAppID");
            string weixinSecret = PublicHelper.GetConfigValue("WeixinSecret");

            string url = WeixinConst.GET_WEBAUTH_URL.Replace("APPID", weixinAppId).Replace("SECRET", weixinSecret).Replace("CODE", code);

            string s = WhttpHelper.HttpGet(url);

            WxUserToken userToken = JsonConvert.DeserializeObject<WxUserToken>(s);

            if (userToken.errcode == 0)
            {
                //PublicHelper.SetParamValue("AccessToken", userToken.access_token, "WxData");
                //PublicHelper.SetParamValue("AccessDTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), "WxData");

                return userToken.openid;
            }
            return "";
        }

        public static WxUserInfo getUserInfo(string access_token,string openId)
        {
            string url = WeixinConst.GET_WEIXIN_USER_URL.Replace("ACCESS_TOKEN", access_token).Replace("OPENID", openId);
            string s = WhttpHelper.HttpGet(url);

            WxUserInfo userInfo = JsonConvert.DeserializeObject<WxUserInfo>(s);

            if (userInfo!=null&&userInfo.errcode == 0)
            {
                return userInfo;
            }
            return null;
        }
        #endregion
    }
}