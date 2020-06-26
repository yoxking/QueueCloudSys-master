using EntFrm.Business.Model;
using EntFrm.Business.Model.Collections;
using EntFrm.Framework.Utility;

namespace EntFrm.Business.IDAL
{
  public interface IAppsClass
  {
        AppsClassCollections GetAllRecords();
        AppsClassCollections GetRecordsByClassNo(string sClassNo);
        AppsClassCollections GetRecordsByNo(string sNo);
        string GetRecordNameByNo(string sNo);
        int AddNewRecord(AppsClass info);
        int UpdateRecord(AppsClass info); 
        int HardDeleteRecord(string sNo);
        int SoftDeleteRecord(string sNo);
        int HardDeleteByCondition(string sCondition);
        int SoftDeleteByCondition(string sCondition);
        AppsClassCollections GetRecords_Paging(SqlModel s_model);
        int GetCountByCondition(string sCondition);
    }
  }

