using EntFrm.Business.Model;
using EntFrm.Business.Model.Collections;
using EntFrm.Framework.Utility;

namespace EntFrm.Business.IDAL
{
  public interface ILogsInfo
  {
        LogsInfoCollections GetAllRecords();
        LogsInfoCollections GetRecordsByClassNo(string sClassNo);
        LogsInfoCollections GetRecordsByNo(string sNo);
        string GetRecordNameByNo(string sNo);
        int AddRecord(LogsInfo info);
        int UpdateRecord(LogsInfo info); 
        int HardDeleteRecord(string sNo);
        int SoftDeleteRecord(string sNo);
        LogsInfoCollections GetRecords_Paging(SqlModel s_model);
        int GetCountByCondition(string sCondition);
    }
  }

