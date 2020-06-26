using EntFrm.Business.BLL;
using EntFrm.Business.Model;
using EntFrm.Business.Model.Collections;
using EntFrm.Framework.Utility;
using EntFrm.Framework.Web;
using EntFrm.Framework.Web.Controls;

using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EntWeb.BkConsole.Areas.BussData.Controllers
{
    public class AppsInfoController : frmMainController
    {
        private string sWhere
        {
            set { TempData["Where_" + RouteData.Values["controller"].ToString()] = value; }
            get
            {
                var temp = TempData.Peek("Where_" + RouteData.Values["controller"].ToString());
                if (temp == null)
                {
                    return "";
                }
                return temp.ToString();
            }
        }

        //
        // GET: /System/Role/
        public override ActionResult Index()
        {
            return RedirectToAction("List");
        }


        public override ActionResult List()
        {
            try
            {
                PageIndex = int.Parse(Request.Form["pageIndex"] == null ? "1" : Request.Form["pageIndex"].ToString());
                Condition = sWhere;

                AppsInfoBLL infoBLL = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                AppsInfoCollections infoColl = infoBLL.GetRecordsByPaging(ref PageCount, PageIndex, this.PageSize, Condition);
                int totalCount = infoBLL.GetCountByCondition(Condition);

                PagerHelper pager = new PagerHelper(PageIndex, PageSize, totalCount);

                Dictionary<string, object> stackHolder = new Dictionary<string, object>();
                stackHolder.Add("infoList", infoColl);
                stackHolder.Add("pager", pager);
                ViewBag.StackHolder = stackHolder;
            }
            catch (Exception ex)
            { }
            return View();
        }

        public override ActionResult Search()
        {
            sWhere = "1=1 ";

            //if (!string.IsNullOrEmpty(sTrueName))
            //{
            //    sWhere += " And (TrueName like '%" + sTrueName + "%'  OR LoginId like '%" + sTrueName + "%' )";
            //}

            return RedirectToAction("List");
        }

        public override ActionResult Add()
        {
            try
            {
                AppsInfo info = new AppsInfo();
                info.sAppNo = CommonHelper.Get_New12ByteGuid();
                info.sAppCode = CommonHelper.Get_UniqueStringID();
                info.dRegistDate = DateTime.Now;
                info.dActiveDate = DateTime.Now.AddYears(5);

                ViewBag.StackHolder = info;
                ViewBag.ClassList = GetClassList();
            }
            catch (Exception ex)
            {
            }
            return View("Edit");
        }

        public override ActionResult Edit(string id)
        {
            try
            {
                AppsInfoBLL infoBLL = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                AppsInfo info = infoBLL.GetRecordByNo(id);

                ViewBag.StackHolder = info;
                ViewBag.ClassList = GetClassList();
            }
            catch (Exception ex)
            {
            }
            return View();
        }
         
        private AppsClassCollections GetClassList()
        {
            AppsClassBLL infoBLL = new AppsClassBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
            AppsClassCollections infoColl = infoBLL.GetAllRecords();

            return infoColl;
        }

        [HttpPost]
        public override ActionResult Save()
        {
            JsonxHelper json = new JsonxHelper() { Message = "保存失败", Status = "Failure" };
            try
            {
                string sSuNo = ((LoginerInfo)this.HttpContext.Session["loginUser"]).UserNo;

                string sNo = Request.Form["AppNo"].ToString();
                string AppCnName = Request.Form["AppCnName"].ToString();
                string AppClassNo = Request.Form["AppClassNo"].ToString();
                string AppCode = Request.Form["AppCode"].ToString();
                string AppVersion = Request.Form["AppVersion"].ToString();
                string GuestName = Request.Form["GuestName"].ToString();
                string GuestPhone = Request.Form["GuestPhone"].ToString();
                string GuestEMail = Request.Form["GuestEMail"].ToString();
                string DogId = Request.Form["DogId"].ToString();
                string ActiveCount = Request.Form["ActiveCount"].ToString();
                string RegistDate = Request.Form["RegistDate"].ToString();
                string ActiveDate = Request.Form["ActiveDate"].ToString();
                string ActiveCode = Request.Form["ActiveCode"].ToString();
                string Comments = Request.Form["Comments"].ToString();

                AppsInfoBLL infoBLL = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                AppsInfo info = infoBLL.GetRecordByNo(sNo);

                //新增操作
                if (info == null)
                {
                    info = new AppsInfo();
                    info.sAppNo = sNo;

                    info.sAppCode = AppCode;
                    info.sAppClassNo = AppClassNo;
                    info.sAppCnName = AppCnName;
                    info.sAppEnName = "";
                    info.sAppURL = "";
                    info.iAppVersion = int.Parse(AppVersion);
                    info.sGuestName = GuestName;
                    info.sGuestEMail = GuestEMail;
                    info.sGuestPhone = GuestPhone;
                    info.iEncType = 1;
                    info.iEncKeySize = 128;
                    info.sEncKey = "";
                    info.sEncIV = "";
                    info.sDogId = DogId;
                    info.iDogType = 1;
                    info.dRegistDate = DateTime.Parse(RegistDate);
                    info.dActiveDate = DateTime.Parse(ActiveDate);
                    info.iActiveCount = int.Parse(ActiveCount);
                    info.sActiveCode = ActiveCode;
                    info.sAddOptor = sSuNo;
                    info.dAddDate = DateTime.Now;
                    info.sModOptor = sSuNo;
                    info.dModDate = DateTime.Now;
                    info.iValidityState = 1;
                    info.sComments = Comments;

                    if (infoBLL.AddNewRecord(info))
                    {
                        json.Message = "保存成功";
                        json.Status = "Success";
                    }
                }
                //更新操作
                else
                {
                    info.sAppCode = AppCode;
                    info.sAppClassNo = AppClassNo;
                    info.sAppCnName = AppCnName;
                    info.iAppVersion = int.Parse(AppVersion);
                    info.sGuestName = GuestName;
                    info.sGuestEMail = GuestEMail;
                    info.sGuestPhone = GuestPhone;
                    info.sDogId = DogId;
                    info.dRegistDate = DateTime.Parse(RegistDate);
                    info.dActiveDate = DateTime.Parse(ActiveDate);
                    info.iActiveCount = int.Parse(ActiveCount);
                    info.sActiveCode = ActiveCode;
                    info.sComments = Comments;

                    info.sModOptor = sSuNo;
                    info.dModDate = DateTime.Now;

                    if (infoBLL.UpdateRecord(info))
                    {
                        json.Message = "保存成功";
                        json.Status = "Success";
                    }
                }
            }
            catch (Exception ex)
            {
                json.Message = "信息发生内部错误！" + ex.Message;
                json.Status = "Failure";
            }
            return Json(json);
        }

        public override ActionResult Delete(string ids)
        {
            JsonxHelper json = new JsonxHelper() { Message = "操作成功", Status = "Success" };
            try
            {
                string[] sNos = ids.Split(';');
                AppsInfoBLL infoBLL = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                infoBLL.SoftDeleteRecord(sNos);
            }
            catch (Exception ex)
            {
                json.Message = "操作时发生内部错误！" + ex.Message;
                json.Status = "Failure";
            }
            return Json(json);
        }
        public override ActionResult Detail(string id)
        {
            try
            {
                AppsInfoBLL infoBLL = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                AppsInfo info = infoBLL.GetRecordByNo(id);

                ViewBag.StackHolder = info;
            }
            catch (Exception ex)
            {
            }
            return View();
        }
    }
}