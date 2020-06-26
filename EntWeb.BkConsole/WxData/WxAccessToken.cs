using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntWeb.BkConsole.WxData
{
    public class WxAccessToken:WeixinBase
    {
        public string access_token { set; get; }
        public int expires_in { set; get; }
    }
}