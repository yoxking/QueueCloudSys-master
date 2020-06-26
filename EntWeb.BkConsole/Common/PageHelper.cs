using EntFrm.Business.BLL;
using EntFrm.Business.Model;
using EntFrm.Business.Model.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntWeb.BkConsole
{
    public class PageHelper
    {
        public static string getAppsClassNameByNo(string sNo)
        {
            try
            {
                AppsClassBLL infoBLL = new AppsClassBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordNameByNo(sNo);
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public static string getAppsInfoNameByNo(string sNo)
        {
            try
            {
                AppsInfoBLL infoBLL = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordNameByNo(sNo);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static AppsInfo getAppsInfoByNo(string sNo)
        {
            try
            {
                AppsInfoBLL infoBLL = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordByNo(sNo);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static AppsInfo getAppsInfoByCode(string sCode)
        {
            try
            {
                int count = 0;
                AppsInfoBLL infoBLL = new AppsInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                AppsInfoCollections infoColl = infoBLL.GetRecordsByPaging(ref count, 1, 1, "AppCode='"+sCode+"'");

                if (infoColl != null && infoColl.Count > 0)
                {
                    return infoColl.GetFirstOne();
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string getOrganizInfoNameByNo(string sNo)
        {
            try
            {
                OrganizInfoBLL infoBLL = new OrganizInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordNameByNo(sNo);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static OrganizInfo getOrganizInfoByNo(string sNo)
        {
            try
            {
                OrganizInfoBLL infoBLL = new OrganizInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordByNo(sNo);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
         
        public static string getRoleInfoNameByNo(string sNo)
        {
            try
            {
                RoleInfoBLL infoBLL = new RoleInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordNameByNo(sNo);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static RoleInfo getRoleInfoByNo(string sNo)
        {
            try
            {
                RoleInfoBLL infoBLL = new RoleInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordByNo(sNo);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string getPermitNameByNo(string sNo)
        {
            try
            {
                PermitInfoBLL infoBLL = new PermitInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordNameByNo(sNo);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static PermitInfo getPermitInfoByNo(string sNo)
        {
            try
            {
                PermitInfoBLL infoBLL = new PermitInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordByNo(sNo);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
         
        public static string getSUsersInfoNameByNo(string sNo)
        {
            try
            {
                SUsersInfoBLL infoBLL = new SUsersInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordNameByNo(sNo);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static SUsersInfo getSUsersInfoByNo(string sNo)
        {
            try
            {
                SUsersInfoBLL infoBLL = new SUsersInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordByNo(sNo);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static string getRUsersInfoNameByNo(string sNo)
        {
            try
            {
                RUsersInfoBLL infoBLL = new RUsersInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordNameByNo(sNo);
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public static RUsersInfo getRUsersInfoByNo(string sNo)
        {
            try
            {
                RUsersInfoBLL infoBLL = new RUsersInfoBLL(PublicHelper.Get_ConnStr(), PublicHelper.Get_AppCode());
                return infoBLL.GetRecordByNo(sNo);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}