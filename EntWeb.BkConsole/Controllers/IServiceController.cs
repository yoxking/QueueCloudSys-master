using EntFrm.Business.BLL;
using EntFrm.Business.Model;
using EntFrm.Business.Model.Collections;
using EntFrm.Framework.Utility;
using EntWeb.BkConsole.Entities;
using EntWeb.BkConsole.Models;
using EntWeb.BkConsole.WxData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntWeb.BkConsole.Controllers
{
    public class IServiceController : Controller
    {
        public string getServTime()
        {
            CodeData codeData = new CodeData();
            codeData.msg = "success";
            codeData.code = "200";
            codeData.data = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            return JsonConvert.SerializeObject(codeData);
        }

        #region 程序授权接口

        public string getLoginUser(string userName, string password)
        {
            int count = 0;
            string result = "false";
            SUsersInfoBLL infoBoss = new SUsersInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode()); //业务逻辑层实例 
            SUsersInfoCollections infoColl = infoBoss.GetRecordsByPaging(ref count, 1, 1, " LoginID='" + userName + "' ");

            if (infoColl != null && infoColl.Count > 0)
            {
                SUsersInfo info = infoColl.GetFirstOne();
                if (info.sPassword.Equals(password))
                {
                    result = "true";
                }
            }

            return result;
        }

        public string getAllAppClasses()
        {
            List<AppClassData> infoList = new List<AppClassData>();
            AppClassData data = null;

            AppsClassBLL infoBoss = new AppsClassBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode()); //业务逻辑层实例 
            AppsClassCollections infoColl = infoBoss.GetAllRecords();

            if (infoColl != null && infoColl.Count > 0)
            {
                foreach (AppsClass info in infoColl)
                {
                    data = new AppClassData();
                    data.ClassNo = info.sClassNo;
                    data.ClassName = info.sClassName;

                    infoList.Add(data);
                }
            }
            return JsonConvert.SerializeObject(infoList);
        }

        public string getAppClassesByPaging(string pageIndex, string pageSize, string condition)
        {
            List<AppClassData> infoList = new List<AppClassData>();
            AppClassData data = null;

            int count = 0;
            AppsClassBLL infoBoss = new AppsClassBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode()); //业务逻辑层实例 
            AppsClassCollections infoColl = infoBoss.GetRecordsByPaging(ref count, int.Parse(pageIndex), int.Parse(pageSize), condition);

            if (infoColl != null && infoColl.Count > 0)
            {
                foreach (AppsClass info in infoColl)
                {
                    data = new AppClassData();
                    data.ClassNo = info.sClassNo;
                    data.ClassName = info.sClassName;

                    infoList.Add(data);
                }
            }
            return JsonConvert.SerializeObject(infoList);
        }

        public string getAppClass(string classId)
        {
            AppClassData data = null;

            int count = 0;
            AppsClassBLL infoBoss = new AppsClassBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode()); //业务逻辑层实例 
            AppsClass info = infoBoss.GetRecordByNo(classId);

            if (info != null)
            {
                data = new AppClassData();
                data.ClassNo = info.sClassNo;
                data.ClassName = info.sClassName;
            }
            return JsonConvert.SerializeObject(data);
        }
        public string getAllAppInfos()
        {
            List<AppInfoData> infoList = new List<AppInfoData>();
            AppInfoData data = null;

            AppsInfoBLL infoBoss = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode()); //业务逻辑层实例 
            AppsInfoCollections infoColl = infoBoss.GetAllRecords();

            if (infoColl != null && infoColl.Count > 0)
            {
                foreach (AppsInfo info in infoColl)
                {
                    data = new AppInfoData();
                    data.AppCode = info.sAppCode;
                    data.AppClassNo = info.sAppClassNo;
                    data.AppClassName = PageHelper.getAppsClassNameByNo(info.sAppClassNo);
                    data.AppName = info.sAppCnName;
                    data.AppVersion = info.iAppVersion.ToString();
                    data.GuestName = info.sGuestName;
                    data.GuestEMail = info.sGuestEMail;
                    data.GuestPhone = info.sGuestPhone;
                    data.DogId = info.sDogId;
                    data.RegistDate = info.dRegistDate.ToString("yyyy-MM-dd");
                    data.ActiveDate = info.dActiveDate.ToString("yyyy-MM-dd");
                    data.ActiveCount = info.iActiveCount.ToString();
                    data.ActiveCode = info.sActiveCode;

                    infoList.Add(data);
                }
            }
            return JsonConvert.SerializeObject(infoList);
        }

        public string getAppInfosByPaging(string pageIndex, string pageSize, string condition)
        {
            List<AppInfoData> infoList = new List<AppInfoData>();
            AppInfoData data = null;

            int count = 0;
            AppsInfoBLL infoBoss = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode()); //业务逻辑层实例 
            AppsInfoCollections infoColl = infoBoss.GetRecordsByPaging(ref count, int.Parse(pageIndex), int.Parse(pageSize), condition);

            if (infoColl != null && infoColl.Count > 0)
            {
                foreach (AppsInfo info in infoColl)
                {
                    data = new AppInfoData();
                    data.AppCode = info.sAppCode;
                    data.AppClassNo = info.sAppClassNo;
                    data.AppClassName = PageHelper.getAppsClassNameByNo(info.sAppClassNo);
                    data.AppName = info.sAppCnName;
                    data.AppVersion = info.iAppVersion.ToString();
                    data.GuestName = info.sGuestName;
                    data.GuestEMail = info.sGuestEMail;
                    data.GuestPhone = info.sGuestPhone;
                    data.DogId = info.sDogId;
                    data.RegistDate = info.dRegistDate.ToString("yyyy-MM-dd");
                    data.ActiveDate = info.dActiveDate.ToString("yyyy-MM-dd");
                    data.ActiveCount = info.iActiveCount.ToString();
                    data.ActiveCode = info.sActiveCode;

                    infoList.Add(data);
                }
            }
            return JsonConvert.SerializeObject(infoList);
        }

        public string getAppInfo(string appCode)
        {
            AppInfoData data = null;

            int count = 0;
            AppsInfoBLL infoBoss = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode()); //业务逻辑层实例 
            AppsInfoCollections infoColl = infoBoss.GetRecordsByPaging(ref count, 1, 1, " AppCode='" + appCode + "'");

            if (infoColl != null && infoColl.Count > 0)
            {
                AppsInfo info = infoColl.GetFirstOne();
                data = new AppInfoData();
                data.AppCode = info.sAppCode;
                data.AppClassNo = info.sAppClassNo;
                data.AppClassName = PageHelper.getAppsClassNameByNo(info.sAppClassNo);
                data.AppName = info.sAppCnName;
                data.AppVersion = info.iAppVersion.ToString();
                data.GuestName = info.sGuestName;
                data.GuestEMail = info.sGuestEMail;
                data.GuestPhone = info.sGuestPhone;
                data.DogId = info.sDogId;
                data.RegistDate = info.dRegistDate.ToString("yyyy-MM-dd");
                data.ActiveDate = info.dActiveDate.ToString("yyyy-MM-dd");
                data.ActiveCount = info.iActiveCount.ToString();
                data.ActiveCode = info.sActiveCode;


            }
            return JsonConvert.SerializeObject(data);
        }

        public string getAppInfoByDogId(string dogId)
        {
            AppInfoData data = null;

            int count = 0;
            AppsInfoBLL infoBoss = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode()); //业务逻辑层实例 
            AppsInfoCollections infoColl = infoBoss.GetRecordsByPaging(ref count, 1, 1, " DogId='" + dogId + "'");

            if (infoColl != null && infoColl.Count > 0)
            {
                AppsInfo info = infoColl.GetFirstOne();
                data = new AppInfoData();
                data.AppCode = info.sAppCode;
                data.AppClassNo = info.sAppClassNo;
                data.AppClassName = PageHelper.getAppsClassNameByNo(info.sAppClassNo);
                data.AppName = info.sAppCnName;
                data.AppVersion = info.iAppVersion.ToString();
                data.GuestName = info.sGuestName;
                data.GuestEMail = info.sGuestEMail;
                data.GuestPhone = info.sGuestPhone;
                data.DogId = info.sDogId;
                data.RegistDate = info.dRegistDate.ToString("yyyy-MM-dd");
                data.ActiveDate = info.dActiveDate.ToString("yyyy-MM-dd");
                data.ActiveCount = info.iActiveCount.ToString();
                data.ActiveCode = info.sActiveCode;


            }
            return JsonConvert.SerializeObject(data);
        }

        [HttpPost]
        public string postAppInfo(AppInfoData appdata)
        {
            string result = "error";
            int count = 0;
            AppsInfo info = null;
            //AppInfoData data = JsonConvert.DeserializeObject<AppInfoData>(appdata);
            AppsInfoBLL infoBoss = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode()); //业务逻辑层实例
            AppsInfoCollections infoColl = infoBoss.GetRecordsByPaging(ref count, 1, 1, "DogId='" + appdata.DogId + "'");

            if (infoColl != null && infoColl.Count > 0)
            {
                info = infoColl.GetFirstOne();

                info.sAppCode = appdata.AppCode;
                info.sAppClassNo = appdata.AppClassNo;
                info.sAppCnName = appdata.AppName;
                info.iAppVersion = int.Parse(appdata.AppVersion);
                info.sGuestName = appdata.GuestName;
                info.sGuestEMail = appdata.GuestEMail;
                info.sGuestPhone = appdata.GuestPhone;
                info.sDogId = appdata.DogId;
                info.dRegistDate = DateTime.Parse(appdata.RegistDate);
                info.dActiveDate = DateTime.Parse(appdata.ActiveDate);
                info.iActiveCount = int.Parse(appdata.ActiveCount);
                info.sActiveCode = appdata.ActiveCode;

                if (infoBoss.UpdateRecord(info))
                {
                    result = "success";
                }

            }
            else
            {
                info = new AppsInfo();
                info.sAppNo = CommonHelper.Get_New12ByteGuid();
                info.sAppCode = appdata.AppCode;
                info.sAppClassNo = appdata.AppClassNo;
                info.sAppCnName = appdata.AppName;
                info.sAppEnName = "";
                info.sAppURL = "";
                info.iAppVersion = int.Parse(appdata.AppVersion);
                info.sGuestName = appdata.GuestName;
                info.sGuestEMail = appdata.GuestEMail;
                info.sGuestPhone = appdata.GuestPhone;
                info.iEncType = 1;
                info.iEncKeySize = 128;
                info.sEncKey = "";
                info.sEncIV = "";
                info.sDogId = appdata.DogId;
                info.iDogType = 1;
                info.dRegistDate = DateTime.Parse(appdata.RegistDate);
                info.dActiveDate = DateTime.Parse(appdata.ActiveDate);
                info.iActiveCount = int.Parse(appdata.ActiveCount);
                info.sActiveCode = appdata.ActiveCode;

                info.sAddOptor = "";
                info.dAddDate = DateTime.Now;
                info.sModOptor = "";
                info.dModDate = DateTime.Now;
                info.iValidityState = 1;
                info.sComments = "";

                if (infoBoss.AddNewRecord(info))
                {
                    result = "success";
                }
            }
            return result;
        }

        #endregion

        #region 网上预约取票
          
        public string getWxUserInfo(string code, string state)
        {
            CodeData codeData = new CodeData();
            codeData.msg = "success";
            codeData.code = "200";
            codeData.data = "";

            string appCode = state;
            RUsersInfo ruserInfo = null;
            RUserData ruserData = null;
            AppsInfo appsInfo = null;
            WxUserInfo wxuserInfo = null;

            //从微信公众号获取用户信息
            string userOpenId = WeixinHelper.getUserId(code);
            string accessToken = WeixinHelper.getAccessToken();
            wxuserInfo = WeixinHelper.getUserInfo(accessToken, userOpenId);

            if (wxuserInfo != null)
            {
                appsInfo = PageHelper.getAppsInfoByCode(appCode);
                ruserInfo = PageHelper.getRUsersInfoByNo(wxuserInfo.openid);
                if (appsInfo == null && ruserInfo != null)
                {
                    appsInfo = PageHelper.getAppsInfoByCode(ruserInfo.sAppCode);
                }

                if (appsInfo != null)
                {
                    ruserData = new RUserData();
                    if (ruserInfo != null)
                    {
                        ruserData.UserNo = ruserInfo.sRUserNo;
                        ruserData.UserName = ruserInfo.sCnName;
                        ruserData.UserSex = ruserInfo.iSex == 1 ? "男" : "女";
                        ruserData.Telephone = ruserInfo.sTelphone;
                        ruserData.IdCardNo = ruserInfo.sIdCardNo;
                        ruserData.HeadPhoto = ruserInfo.sHeadPhoto;
                        ruserData.Resume = ruserInfo.sSummary;
                    }
                    else
                    {
                        IBusinessHelper.InsertRUserInfo(appsInfo.sAppCode, wxuserInfo.openid, wxuserInfo.nickname, wxuserInfo.sex == 1 ? "男" : "女", "188", "", wxuserInfo.city, false);

                        ruserData.UserNo = wxuserInfo.openid;
                        ruserData.UserName = wxuserInfo.nickname;
                        ruserData.UserSex = wxuserInfo.sex == 1 ? "男" : "女";
                        ruserData.Telephone = "";
                        ruserData.IdCardNo = "";
                        ruserData.HeadPhoto = "";
                        ruserData.Resume = wxuserInfo.city;
                    }
                    codeData.data = JsonConvert.SerializeObject(ruserData);
                }
            }

            return JsonConvert.SerializeObject(codeData);
       }

        public string postWxMessage(string userOpenId, string message)
        {
            CodeData codeData = new CodeData();
            codeData.msg = "success";
            codeData.code = "200";
            codeData.data = "{\"result\":\"success\"}";

            string accessToken = WeixinHelper.getAccessToken();
            //向微信用户发送消息
            WeixinHelper.doSendMessage(accessToken, userOpenId, message);

            return JsonConvert.SerializeObject(codeData);
        }

        public string getRUserInfo(string userId)
        {
            CodeData codeData = new CodeData();
            codeData.msg = "success";
            codeData.code = "200";
            codeData.data = "";

            RUsersInfo ruserInfo = PageHelper.getRUsersInfoByNo(userId);

            if (ruserInfo != null)
            {
                RUserData ruserData = new RUserData();
                ruserData.UserNo = ruserInfo.sRUserNo;
                ruserData.UserName = ruserInfo.sCnName;
                ruserData.UserSex = ruserInfo.iSex == 1 ? "男" : "女";
                ruserData.Telephone = ruserInfo.sTelphone;
                ruserData.IdCardNo = ruserInfo.sIdCardNo;
                ruserData.HeadPhoto = ruserInfo.sHeadPhoto;
                ruserData.Resume = ruserInfo.sSummary;
                codeData.data = JsonConvert.SerializeObject(ruserData);
            }

            return JsonConvert.SerializeObject(codeData);
        }

        public string getRegbranchs(string appcode)
        { 
            return RabbitMqUtil.requestMq("Q" + appcode, "getRegbranchs"); 
        }
        public string getAdvertises(string appcode,string pageSize)
        {
            return RabbitMqUtil.requestMq("Q" + appcode, "getAdvertises|"+pageSize);
        }
        public string getDeptProfile(string appcode)
        {
            return RabbitMqUtil.requestMq("Q" + appcode, "getDeptProfile");
        } 
        public string getRegServices(string appcode, string branchNo, string registDate)
        {
            return RabbitMqUtil.requestMq("Q" + appcode, "getRegServices|"+branchNo+"|"+registDate);
        }
        public string getRegHistories(string appcode, string userNo, string pageSize)
        {
            return RabbitMqUtil.requestMq("Q" + appcode, "getRegHistories|" + userNo + "|" + pageSize);
        }

        public string postRegistInfo(string appcode, string branchNo, string serviceNo, string regDate, string regType, string workTime, string userNo, string userName, string sex, string telephone, string idcardNo, string remark)
        {
            IBusinessHelper.InsertRUserInfo(appcode,userNo, userName, sex, telephone, idcardNo,remark);

            //CodeData codeData = new CodeData();
            //codeData.msg = "success";
            //codeData.code = "200";
            //codeData.data = "{\"result\":1}";

            //return JsonConvert.SerializeObject(codeData);
            return RabbitMqUtil.requestMq("Q" + appcode, "postRegistInfo|" + branchNo + "|" + serviceNo + "|" + regDate + "|" + regType + "|" + workTime + "|" + userNo + "|" + userName + "|" + sex + "|" + telephone + "|" + idcardNo + "|" + remark);
        }

        #endregion
    }
}