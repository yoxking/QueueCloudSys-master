using EntFrm.Business.BLL;
using EntFrm.Business.Model;
using EntFrm.Business.Model.Collections;
using EntFrm.Framework.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntWeb.BkConsole
{
    public class IBusinessHelper
    {
        public static bool InsertRUserInfo(string sAppCode, string sRUserNo, string sRUserName, string sRUserSex, string sTelephone, string sIdCardNo, string sRemark,bool bUpdateFlag=true)
        {
            bool bResult = false;
            try
            {
                RUsersInfoBLL infoBoss = new RUsersInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                RUsersInfo info = infoBoss.GetRecordByNo(sRUserNo);

                if (info != null)
                {
                    if (bUpdateFlag)
                    {
                        info.sCnName = sRUserName;
                        info.iSex = sRUserSex.Equals("男") ? 1 : 0;
                        info.sTelphone = sTelephone;
                        info.sIdCardNo = sIdCardNo;
                        info.sSummary = sRemark;
                    }

                    info.sAppCode = sAppCode + ";";
                    info.dModDate = DateTime.Now;

                    bResult = infoBoss.UpdateRecord(info);
                }
                else
                {
                    if (string.IsNullOrEmpty(sRUserNo))
                    {
                        sRUserNo = CommonHelper.Get_New12ByteGuid();
                    }
                    info = new RUsersInfo();

                    info.sRUserNo = sRUserNo;
                    info.sCnName = sRUserName;
                    info.sEnName = "";
                    info.iAge = 0;
                    info.iSex = sRUserSex.Equals("男") ? 1 : 0;
                    info.sNation = "汉";
                    info.iCardType = 1;
                    info.sIdCardNo =sIdCardNo;
                    info.sRiCardNo = "";
                    info.sAddress = "";
                    info.sPostCode = "";
                    info.sTelphone = sTelephone;
                    info.sHeadPhoto = "";
                    info.sSummary = sRemark;

                    info.sBranchNo = "";
                    info.sComments = "";
                    info.sAddOptor = "00000000";
                    info.dAddDate = DateTime.Now;
                    info.sModOptor = "00000000";
                    info.dModDate = DateTime.Now;
                    info.iValidityState = 1;
                    info.sAppCode = sAppCode + ";";

                    bResult = infoBoss.AddNewRecord(info);
                } 
            }
            catch (Exception ex)
            {
                bResult = false;
            }
            return bResult;
        }

        public static RUsersInfo GetRUserInfo(string sRUserNo)
        { 
            RUsersInfoBLL infoBoss = new RUsersInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
            return infoBoss.GetRecordByNo(sRUserNo);
        } 
    }
}