using EntFrm.Business.Model;
using EntFrm.Business.Model.Collections;
using EntFrm.Framework.Utility;

namespace EntFrm.Business.IDAL
{
  public interface ISUsersInfo
  {
        SUsersInfoCollections GetAllRecords();
        SUsersInfoCollections GetRecordsByClassNo(string sClassNo);
        SUsersInfoCollections GetRecordsByNo(string sNo);
        string GetRecordNameByNo(string sNo);
        int AddRecord(SUsersInfo info);
        int UpdateRecord(SUsersInfo info); 
        int HardDeleteRecord(string sNo);
        int SoftDeleteRecord(string sNo);
        SUsersInfoCollections GetRecords_Paging(SqlModel s_model);
        int GetCountByCondition(string sCondition);
    }
  }

