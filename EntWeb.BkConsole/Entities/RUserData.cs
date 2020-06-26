using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntWeb.BkConsole.Entities
{
    public class RUserData
    {
        public string UserNo { set; get; }
        public string UserName { set; get; }
        public string UserSex { set; get; }
        public string Telephone { set; get; }
        public string IdCardNo { set; get; } 
        public string HeadPhoto { set; get; }
        public string Resume { set; get; }
    }
}