using EntFrm.Framework.RabbitMq;
using EntFrm.Framework.RabbitMq.Config;
using EntFrm.Framework.RabbitMq.Model;
using EntFrm.Framework.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntWeb.BkConsole.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Login", "Auth", new { Area = "System" });
        }

        public ActionResult Test(string appcode,string branchno)
        {
            string result = "";
            string queuename = "Qbab9e6478cc8";

            result = RabbitMqUtil.requestMq(queuename, "helloMessage");

            ViewBag.Result = result.ToString();
            ViewBag.Test = "test";

            return View();
        }

        public ActionResult Encrypt()
        {
            return View();
        }

        public string EncryptText(string text)
        {
            return EnconfigHelper.Encrypt(text);
        }

        public string DecryptText(string text)
        {
            return EnconfigHelper.Decrypt(text);
        }
    }
}