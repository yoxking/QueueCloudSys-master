using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntWeb.BkConsole.WxData
{
    public class WeixinConst
    {

        /**
     * 用于获取当前与微信公众号交互的用户信息的接口（一般是用第一个接口地址）
     */ 
        public static string GET_WEIXIN_USER_URL = "https://api.weixin.qq.com/cgi-bin/user/info?access_token=ACCESS_TOKEN&openid=OPENID&lang=zh_CN";

        /**
         * 用于进行网页授权验证的接口URL，通过这个才可以得到opendID等字段信息
         */
                                                 
        public static string GET_WEBAUTH_URL = "https://api.weixin.qq.com/sns/oauth2/access_token?appid=APPID&secret=SECRET&code=CODE&grant_type=authorization_code";

        /**
        * 获取access_token的URL
        */ 
        public static string ACCESS_TOKEN_URL = "https://api.weixin.qq.com/cgi-bin/token?grant_type=client_credential&appid=APPID&secret=APPSECRET";

        /**
         * 向指定用户发送消息
         */
        public static string POST_WEIXIN_MESSAGE_URL = "https://api.weixin.qq.com/cgi-bin/message/custom/send?access_token=ACCESS_TOKEN";
    }
}