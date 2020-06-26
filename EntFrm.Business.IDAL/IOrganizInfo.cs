using EntFrm.Business.Model;
using EntFrm.Business.Model.Collections;
using EntFrm.Framework.Utility;

namespace EntFrm.Business.IDAL
{
  public interface IOrganizInfo
  {
        OrganizInfoCollections GetAllRecords();
        OrganizInfoCollections GetRecordsByClassNo(string sClassNo);
        OrganizInfoCollections GetRecordsByNo(string sNo);
        string GetRecordNameByNo(string sNo);
        int AddRecord(OrganizInfo info);
        int UpdateRecord(OrganizInfo info); 
        int HardDeleteRecord(string sNo);
        int SoftDeleteRecord(string sNo);
        OrganizInfoCollections GetRecords_Paging(SqlModel s_model);
        int GetCountByCondition(string sCondition);
    }
  }

