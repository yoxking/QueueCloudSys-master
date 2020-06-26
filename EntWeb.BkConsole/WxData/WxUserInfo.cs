using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntWeb.BkConsole.WxData
{
    public class WxUserInfo:WeixinBase
    {
        public string subscribe { set; get; }
        public string openid { set; get; } 
        public string nickname { set; get; }
        public int sex { set; get; }
        public string language { set; get; }
        public string city { set; get; }
        public string province { set; get; }
        public string country { set; get; }
        public string headimgurl { set; get; }
        public string subscribe_time { set; get; }
        public string unionid { set; get; }
        public string remark { set; get; }
        public int groupid { set; get; }
        public int[] tagid_list { set; get; }
        public string subscribe_scene { set; get; }
        public int qr_scene { set; get; }
        public string qr_scene_str { set; get; }
    }
}