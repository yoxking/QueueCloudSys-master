using EntFrm.Business.Model;
using EntFrm.Business.Model.Collections;
using EntFrm.Framework.Utility;

namespace EntFrm.Business.IDAL
{
  public interface IAppsInfo
  {
        AppsInfoCollections GetAllRecords();
        AppsInfoCollections GetRecordsByClassNo(string sClassNo);
        AppsInfoCollections GetRecordsByNo(string sNo);
        string GetRecordNameByNo(string sNo);
        int AddNewRecord(AppsInfo info);
        int UpdateRecord(AppsInfo info); 
        int HardDeleteRecord(string sNo);
        int SoftDeleteRecord(string sNo);
        int HardDeleteByCondition(string sCondition);
        int SoftDeleteByCondition(string sCondition);
        AppsInfoCollections GetRecords_Paging(SqlModel s_model);
        int GetCountByCondition(string sCondition);
    }
  }

