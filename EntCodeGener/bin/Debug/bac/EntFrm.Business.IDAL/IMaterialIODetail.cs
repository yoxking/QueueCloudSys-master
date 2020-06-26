using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntFrm.System.Model;
using EntFrm.System.Model.Collections;
using EntFrm.Framework.Utility;

namespace EntFrm.Business.IDAL
{
  public interface IMaterialIODetail
  {
        MaterialIODetailCollections GetAllRecords();
        MaterialIODetailCollections GetRecordsByClassNo(string sClassNo);
        MaterialIODetailCollections GetRecordsByNo(string sNo);
        string GetRecordNameByNo(string sNo);
        int AddRecord(MaterialIODetail info);
        int UpdateRecord(MaterialIODetail info); 
        int HardDeleteRecord(string sNo);
        int SoftDeleteRecord(string sNo);
        MaterialIODetailCollections GetRecords_Paging(SqlModel s_model);
        int GetCountByCondition(string sCondition);
    }
  }

