using EntFrm.Business.IDAL;
using EntFrm.Business.Model;
using EntFrm.Business.Model.Collections;
using EntFrm.Framework.Utility;
using System;
using System.Data;
using System.Data.SqlClient;

namespace EntFrm.Business.SQLServerDAL
{
  public class AppsInfoDAL: IAppsInfo
  {
        #region sql
        private const string SQL_GET_ALL_RECORDS = @"Select *  From AppsInfo Where  ValidityState=1";
        private const string SQL_GET_RECORDS_BY_NO = @"Select * From AppsInfo Where    ValidityState=1 And AppNo=@AppNo";
        private const string SQL_GET_NAME_BY_NO = @"Select AppCnName From AppsInfo Where     ValidityState=1 And AppNo=@AppNo";
        private const string SQL_ADD_RECORD = @"Insert into AppsInfo
                                              (AppNo,AppClassNo,AppCnName,AppEnName,AppURL,AppVersion,GuestName,GuestEMail,GuestPhone,EncType,EncKeySize,EncKey,EncIV,DogId,DogType,RegistDate,ActiveDate,ActiveCount,ActiveCode,AddOptor,AddDate,ModOptor,ModDate,ValidityState,Comments,AppCode)
                                              values(@AppNo,@AppClassNo,@AppCnName,@AppEnName,@AppURL,@AppVersion,@GuestName,@GuestEMail,@GuestPhone,@EncType,@EncKeySize,@EncKey,@EncIV,@DogId,@DogType,@RegistDate,@ActiveDate,@ActiveCount,@ActiveCode,@AddOptor,@AddDate,@ModOptor,@ModDate,@ValidityState,@Comments,@AppCode)";
        private const string SQL_UPDATE_RECORD = @"Update AppsInfo set
                                                 AppNo=@AppNo,AppClassNo=@AppClassNo,AppCnName=@AppCnName,AppEnName=@AppEnName,AppURL=@AppURL,AppVersion=@AppVersion,GuestName=@GuestName,GuestEMail=@GuestEMail,GuestPhone=@GuestPhone,EncType=@EncType,EncKeySize=@EncKeySize,EncKey=@EncKey,EncIV=@EncIV,DogId=@DogId,DogType=@DogType,RegistDate=@RegistDate,ActiveDate=@ActiveDate,ActiveCount=@ActiveCount,ActiveCode=@ActiveCode,AddOptor=@AddOptor,AddDate=@AddDate,ModOptor=@ModOptor,ModDate=@ModDate,ValidityState=@ValidityState,Comments=@Comments,AppCode=@AppCode 
                                                 Where    ValidityState=1 And AppNo=@AppNo  And Version=@Version";
        private const string SQL_HARD_DELETE_RECORD = @"Delete From AppsInfo Where    AppNo=@AppNo ";
        private const string SQL_SOFT_DELETE_RECORD = @"Update AppsInfo set ValidityState=0 Where   ValidityState=1 And AppNo=@AppNo";
        private const string SQL_HARD_DELETE_BY_CONDTION = @"Delete From AppsInfo Where   1=1 ";
        private const string SQL_SOFT_DELETE_BY_CONDTION = @"Update AppsInfo set ValidityState=0 Where     ValidityState=1 ";
        private const string SQL_GET_RECORDS_BY_CLASSNO = @"Select * From AppsInfo Where      ValidityState=1 And AppClassNo=@AppClassNo";
        private const string SQL_GET_COUNT_BY_CONDITION = @"Select Count(*) From AppsInfo Where      ValidityState=1 ";
        #endregion

        #region param
        private const string PARAM_ID = "@ID";
        private const string PARAM_APPNO = "@AppNo";
        private const string PARAM_APPCLASSNO = "@AppClassNo";
        private const string PARAM_APPCNNAME = "@AppCnName";
        private const string PARAM_APPENNAME = "@AppEnName";
        private const string PARAM_APPURL = "@AppURL";
        private const string PARAM_APPVERSION = "@AppVersion";
        private const string PARAM_GUESTNAME = "@GuestName";
        private const string PARAM_GUESTEMAIL = "@GuestEMail";
        private const string PARAM_GUESTPHONE = "@GuestPhone";
        private const string PARAM_ENCTYPE = "@EncType";
        private const string PARAM_ENCKEYSIZE = "@EncKeySize";
        private const string PARAM_ENCKEY = "@EncKey";
        private const string PARAM_ENCIV = "@EncIV";
        private const string PARAM_DOGID = "@DogId";
        private const string PARAM_DOGTYPE = "@DogType";
        private const string PARAM_REGISTDATE = "@RegistDate";
        private const string PARAM_ACTIVEDATE = "@ActiveDate";
        private const string PARAM_ACTIVECOUNT = "@ActiveCount";
        private const string PARAM_ACTIVECODE = "@ActiveCode";
        private const string PARAM_ADDOPTOR = "@AddOptor";
        private const string PARAM_ADDDATE = "@AddDate";
        private const string PARAM_MODOPTOR = "@ModOptor";
        private const string PARAM_MODDATE = "@ModDate";
        private const string PARAM_VALIDITYSTATE = "@ValidityState";
        private const string PARAM_COMMENTS = "@Comments";
        private const string PARAM_APPCODE = "@AppCode";
        private const string PARAM_VERSION = "@Version";
        #endregion

        private string connStr;
        private string appCode;

        public AppsInfoDAL(string sConnStr,string sAppCode)
        {
           this.connStr = sConnStr;
           this.appCode = sAppCode;
        }

        public AppsInfoCollections GetAllRecords()
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;
            AppsInfoCollections infos = null;
            AppsInfo info = null;

            try
            {  
                connection = SqlHelper.GetConnection(connStr);
                reader = SqlHelper.ExecuteReader(connection, CommandType.Text, SQL_GET_ALL_RECORDS,null);

                if (reader.HasRows)
                {
                    infos = new AppsInfoCollections();
                    while (reader.Read())
                    {
                        info = new AppsInfo();
                        // 设置对象属性
                        PutObjectProperty(info, reader);
                        infos.Add(info);
                    }
                }
                return infos;
            }
            catch (Exception ex)
            {
                throw new Exception(" 查询所有记录(DAL层|GetAllRecords)时出错;" + ex.Message);
            }
            finally
            {
                if (reader != null)
                    ((IDisposable)reader).Dispose();
                if (connection != null)
                    connection.Dispose();
            }
        }

        public AppsInfoCollections GetRecordsByClassNo(string sClassNo)
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;
            AppsInfoCollections infos = null;
            AppsInfo info = null;

            try
            {
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter(PARAM_APPCLASSNO,SqlDbType.NVarChar,20) 
                };
                paras[0].Value = sClassNo; 

                connection = SqlHelper.GetConnection(connStr);
                reader = SqlHelper.ExecuteReader(connection, CommandType.Text, SQL_GET_RECORDS_BY_CLASSNO,paras);

                if (reader.HasRows)
                {
                    infos = new AppsInfoCollections();
                    while (reader.Read())
                    {
                        info = new AppsInfo();
                        // 设置对象属性
                        PutObjectProperty(info, reader);
                        infos.Add(info);
                    }
                }
                return infos;
            }
            catch (Exception ex)
            {
                throw new Exception(" 通过sClassNo查询记录(DAL层)时出错;" + ex.Message);
            }
            finally
            {
                if (reader != null)
                    ((IDisposable)reader).Dispose();
                if (connection != null)
                    connection.Dispose();
            }
        }

        public AppsInfoCollections GetRecordsByNo(string sNo)
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;
            AppsInfoCollections infos = null;
            AppsInfo info = null;

            try
            {
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter(PARAM_APPNO,SqlDbType.NVarChar,20) 
                };
                paras[0].Value = sNo; 

                connection = SqlHelper.GetConnection(connStr);
                reader = SqlHelper.ExecuteReader(connection, CommandType.Text, SQL_GET_RECORDS_BY_NO,paras);

                if (reader.HasRows)
                {
                    infos = new AppsInfoCollections();
                    while (reader.Read())
                    {
                        info = new AppsInfo();
                        //设置对象属性
                        PutObjectProperty(info, reader);
                        infos.Add(info);
                    }
                }
                return infos;
            }
            catch (Exception ex)
            {
                throw new Exception(" 通过No查询记录(DAL层)时出错;" + ex.Message);
            }
            finally
            {
                if (reader != null)
                    ((IDisposable)reader).Dispose();
                if (connection != null)
                    connection.Dispose();
            }
        }

        public string GetRecordNameByNo(string sNo)
        {
            SqlConnection connection = null;
            try
            {
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter(PARAM_APPNO,SqlDbType.NVarChar,20) 
                };
                paras[0].Value = sNo; 

                connection = SqlHelper.GetConnection(connStr);
                return (string)SqlHelper.ExecuteScalar(connection, CommandType.Text, SQL_GET_NAME_BY_NO, paras);
            }
            catch (Exception ex)
            {
                throw new Exception(" 通过No查询记录名称(DAL层)时出错;" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Dispose();
            }
        }

        public int AddNewRecord(AppsInfo info)
        {
            SqlConnection connection = null;

            try
            {
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter(PARAM_APPNO,SqlDbType.NVarChar,128),
                    new SqlParameter(PARAM_APPCLASSNO,SqlDbType.NVarChar,20),
                    new SqlParameter(PARAM_APPCNNAME,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_APPENNAME,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_APPURL,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_APPVERSION,SqlDbType.Int),
                    new SqlParameter(PARAM_GUESTNAME,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_GUESTEMAIL,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_GUESTPHONE,SqlDbType.NVarChar,50),
                    new SqlParameter(PARAM_ENCTYPE,SqlDbType.Int),
                    new SqlParameter(PARAM_ENCKEYSIZE,SqlDbType.Int),
                    new SqlParameter(PARAM_ENCKEY,SqlDbType.NVarChar,128),
                    new SqlParameter(PARAM_ENCIV,SqlDbType.NVarChar,128),
                    new SqlParameter(PARAM_DOGID,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_DOGTYPE,SqlDbType.Int),
                    new SqlParameter(PARAM_REGISTDATE,SqlDbType.DateTime),
                    new SqlParameter(PARAM_ACTIVEDATE,SqlDbType.DateTime),
                    new SqlParameter(PARAM_ACTIVECOUNT,SqlDbType.Int),
                    new SqlParameter(PARAM_ACTIVECODE,SqlDbType.NVarChar,500),
                    new SqlParameter(PARAM_ADDOPTOR,SqlDbType.NVarChar,20),
                    new SqlParameter(PARAM_ADDDATE,SqlDbType.DateTime),
                    new SqlParameter(PARAM_MODOPTOR,SqlDbType.NVarChar,20),
                    new SqlParameter(PARAM_MODDATE,SqlDbType.DateTime),
                    new SqlParameter(PARAM_VALIDITYSTATE,SqlDbType.Int),
                    new SqlParameter(PARAM_COMMENTS,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_APPCODE,SqlDbType.NVarChar,256)
                };
                paras[0].Value = info.sAppNo;
                paras[1].Value = info.sAppClassNo;
                paras[2].Value = info.sAppCnName;
                paras[3].Value = info.sAppEnName;
                paras[4].Value = info.sAppURL;
                paras[5].Value = info.iAppVersion;
                paras[6].Value = info.sGuestName;
                paras[7].Value = info.sGuestEMail;
                paras[8].Value = info.sGuestPhone;
                paras[9].Value = info.iEncType;
                paras[10].Value = info.iEncKeySize;
                paras[11].Value = info.sEncKey;
                paras[12].Value = info.sEncIV;
                paras[13].Value = info.sDogId;
                paras[14].Value = info.iDogType;
                paras[15].Value = info.dRegistDate;
                paras[16].Value = info.dActiveDate;
                paras[17].Value = info.iActiveCount;
                paras[18].Value = info.sActiveCode;
                paras[19].Value = info.sAddOptor;
                paras[20].Value = info.dAddDate;
                paras[21].Value = info.sModOptor;
                paras[22].Value = info.dModDate;
                paras[23].Value = info.iValidityState;
                paras[24].Value = info.sComments;
                paras[25].Value = info.sAppCode;

                connection = SqlHelper.GetConnection(connStr);
                return SqlHelper.ExecuteNonQuery(connection, CommandType.Text, SQL_ADD_RECORD, paras);
            }
            catch (Exception ex)
            {
                throw new Exception(" 添加(DAL层)记录时出错;" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Dispose();
            }
        }

        public int UpdateRecord(AppsInfo info)
        {
            SqlConnection connection = null;

            try
            {
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter(PARAM_APPNO,SqlDbType.NVarChar,128),
                    new SqlParameter(PARAM_APPCLASSNO,SqlDbType.NVarChar,20),
                    new SqlParameter(PARAM_APPCNNAME,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_APPENNAME,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_APPURL,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_APPVERSION,SqlDbType.Int),
                    new SqlParameter(PARAM_GUESTNAME,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_GUESTEMAIL,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_GUESTPHONE,SqlDbType.NVarChar,50),
                    new SqlParameter(PARAM_ENCTYPE,SqlDbType.Int),
                    new SqlParameter(PARAM_ENCKEYSIZE,SqlDbType.Int),
                    new SqlParameter(PARAM_ENCKEY,SqlDbType.NVarChar,128),
                    new SqlParameter(PARAM_ENCIV,SqlDbType.NVarChar,128),
                    new SqlParameter(PARAM_DOGID,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_DOGTYPE,SqlDbType.Int),
                    new SqlParameter(PARAM_REGISTDATE,SqlDbType.DateTime),
                    new SqlParameter(PARAM_ACTIVEDATE,SqlDbType.DateTime),
                    new SqlParameter(PARAM_ACTIVECOUNT,SqlDbType.Int),
                    new SqlParameter(PARAM_ACTIVECODE,SqlDbType.NVarChar,500),
                    new SqlParameter(PARAM_ADDOPTOR,SqlDbType.NVarChar,20),
                    new SqlParameter(PARAM_ADDDATE,SqlDbType.DateTime),
                    new SqlParameter(PARAM_MODOPTOR,SqlDbType.NVarChar,20),
                    new SqlParameter(PARAM_MODDATE,SqlDbType.DateTime),
                    new SqlParameter(PARAM_VALIDITYSTATE,SqlDbType.Int),
                    new SqlParameter(PARAM_COMMENTS,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_APPCODE,SqlDbType.NVarChar,256),
                    new SqlParameter(PARAM_VERSION,SqlDbType.Timestamp)
                };
                paras[0].Value = info.sAppNo;
                paras[1].Value = info.sAppClassNo;
                paras[2].Value = info.sAppCnName;
                paras[3].Value = info.sAppEnName;
                paras[4].Value = info.sAppURL;
                paras[5].Value = info.iAppVersion;
                paras[6].Value = info.sGuestName;
                paras[7].Value = info.sGuestEMail;
                paras[8].Value = info.sGuestPhone;
                paras[9].Value = info.iEncType;
                paras[10].Value = info.iEncKeySize;
                paras[11].Value = info.sEncKey;
                paras[12].Value = info.sEncIV;
                paras[13].Value = info.sDogId;
                paras[14].Value = info.iDogType;
                paras[15].Value = info.dRegistDate;
                paras[16].Value = info.dActiveDate;
                paras[17].Value = info.iActiveCount;
                paras[18].Value = info.sActiveCode;
                paras[19].Value = info.sAddOptor;
                paras[20].Value = info.dAddDate;
                paras[21].Value = info.sModOptor;
                paras[22].Value = info.dModDate;
                paras[23].Value = info.iValidityState;
                paras[24].Value = info.sComments;
                paras[25].Value = info.sAppCode;
                paras[26].Value = StringHelper.ConvertToBytes(info.sVersion);

                connection = SqlHelper.GetConnection(connStr);
                return SqlHelper.ExecuteNonQuery(connection, CommandType.Text, SQL_UPDATE_RECORD, paras);
            }
            catch (Exception ex)
            {
                throw new Exception(" 更新记录(DAL层)时出错;" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Dispose();
            }
        }

        public int HardDeleteRecord(string sNo)
        {
            SqlConnection connection = null;

            try
            {
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter(PARAM_APPNO,SqlDbType.NVarChar,20) 
                };
                paras[0].Value = sNo; 

                connection = SqlHelper.GetConnection(connStr);
                return SqlHelper.ExecuteNonQuery(connection, CommandType.Text, SQL_HARD_DELETE_RECORD, paras);
            }
            catch (Exception ex)
            {
                throw new Exception(" 硬删除记录(DAL层)时出错;" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Dispose();
            }
        }

        public int SoftDeleteRecord(string sNo)
        {
            SqlConnection connection = null;

            try
            {
                SqlParameter[] paras = new SqlParameter[]
                {
                    new SqlParameter(PARAM_APPNO,SqlDbType.NVarChar,20) 
                };
                paras[0].Value = sNo; 

                connection = SqlHelper.GetConnection(connStr);
                return SqlHelper.ExecuteNonQuery(connection, CommandType.Text, SQL_SOFT_DELETE_RECORD, paras);
            }
            catch (Exception ex)
            {
                throw new Exception(" 软删除记录(DAL层)时出错;" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Dispose();
            }
        }

public int HardDeleteByCondition(string sCondtion)
{
    SqlConnection connection = null;
    try
    {
        string sql = SQL_HARD_DELETE_BY_CONDTION;
        if (!string.IsNullOrEmpty(sCondtion))
        {
           sql += " And " + sCondtion;
       } 
      connection = SqlHelper.GetConnection(connStr);
       return SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql, null);
  }
  catch (Exception ex)
  {
      throw new Exception("硬删除记录(DAL层)时出错; " + ex.Message);
  }
  finally
  {
      if (connection != null)
          connection.Dispose();
  }
 }
        public int SoftDeleteByCondition(string sCondtion)
        {
            SqlConnection connection = null;
            try
            {
                string sql = SQL_SOFT_DELETE_BY_CONDTION;
                if (!string.IsNullOrEmpty(sCondtion))
                {
                    sql += " And " + sCondtion;
                } 
                connection = SqlHelper.GetConnection(connStr);
                return SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sql, null);
            }
            catch (Exception ex)
            {
                throw new Exception(" 硬删除记录(DAL层)时出错; " + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Dispose();
            }
        }
        public AppsInfoCollections GetRecords_Paging(SqlModel s_model)
        {
            SqlConnection connection = null;
            SqlDataReader reader = null;
            AppsInfoCollections infos = null;
            AppsInfo info = null;

            try
            {
                 if (s_model.sCondition.Length==0)
                {
                    s_model.sCondition = " Where    ValidityState=1";
                }
                else
                {
                    s_model.sCondition = " Where   ValidityState=1 And  " + s_model.sCondition;
                }

                string strSql = SqlHelper.GetSQL_Paging(s_model);
                connection = SqlHelper.GetConnection(connStr);
                reader = SqlHelper.ExecuteReader(connection, CommandType.Text, strSql);
                if (reader.HasRows)
                {
                    infos = new AppsInfoCollections();
                    while (reader.Read())
                    {
                        info = new AppsInfo();
                        // 设置对象属性
                        PutObjectProperty(info, reader);
                        infos.Add(info);
                    }
                }
                return infos;
            }
            catch (Exception ex)
            {
                throw new Exception(" 分页查询(DAL层)记录时出错;;" + ex.Message);
            }
            finally
            {
                if (reader != null)
                    ((IDisposable)reader).Dispose();
                if (connection != null)
                    connection.Dispose();
            }
        }

        public int GetCountByCondition(string sCondition)
        {
            SqlConnection connection = null;

            try
            {
                string strSql = SQL_GET_COUNT_BY_CONDITION;
                if(sCondition.Length>0)
                {
                    strSql +="  And " + sCondition;
                } 

                connection = SqlHelper.GetConnection(connStr);
                return Convert.ToInt32(SqlHelper.ExecuteScalar(connection, CommandType.Text, strSql, null));
            }
            catch (Exception ex)
            {
                throw new Exception(" 计算记录总数(DAL层)时出错;" + ex.Message);
            }
            finally
            {
                if (connection != null)
                    connection.Dispose();
            }
        }

        #region PutObjectProperty 设置对象属性
        /// <summary>
        /// 从 SqlDataReader 类对象中读取并设置对象属性
        /// </summary>
       /// <param name=" obj_info">主题对象</param>
        /// <param name="dr">读入数据</param>
        internal static void PutObjectProperty(AppsInfo obj_info, SqlDataReader reader)
        {
            obj_info.iID= int.Parse(reader["ID"].ToString());
            obj_info.sAppNo= reader["AppNo"].ToString();
            obj_info.sAppCode = reader["AppCode"].ToString();
            obj_info.sAppClassNo= reader["AppClassNo"].ToString();
            obj_info.sAppCnName= reader["AppCnName"].ToString();
            obj_info.sAppEnName= reader["AppEnName"].ToString();
            obj_info.sAppURL= reader["AppURL"].ToString();
            obj_info.iAppVersion= int.Parse(reader["AppVersion"].ToString());
            obj_info.sGuestName= reader["GuestName"].ToString();
            obj_info.sGuestEMail= reader["GuestEMail"].ToString();
            obj_info.sGuestPhone= reader["GuestPhone"].ToString();
            obj_info.iEncType= int.Parse(reader["EncType"].ToString());
            obj_info.iEncKeySize= int.Parse(reader["EncKeySize"].ToString());
            obj_info.sEncKey= reader["EncKey"].ToString();
            obj_info.sEncIV= reader["EncIV"].ToString();
            obj_info.sDogId= reader["DogId"].ToString();
            obj_info.iDogType= int.Parse(reader["DogType"].ToString());
            obj_info.dRegistDate= DateTime.Parse(reader["RegistDate"].ToString());
            obj_info.dActiveDate= DateTime.Parse(reader["ActiveDate"].ToString());
            obj_info.iActiveCount= int.Parse(reader["ActiveCount"].ToString());
            obj_info.sActiveCode= reader["ActiveCode"].ToString();
            obj_info.sAddOptor= reader["AddOptor"].ToString();
            obj_info.dAddDate= DateTime.Parse(reader["AddDate"].ToString());
            obj_info.sModOptor= reader["ModOptor"].ToString();
            obj_info.dModDate= DateTime.Parse(reader["ModDate"].ToString());
            obj_info.iValidityState= int.Parse(reader["ValidityState"].ToString());
            obj_info.sComments= reader["Comments"].ToString();
            obj_info.sVersion= StringHelper.ConvertToString((byte[])reader["Version"]);
        }
        #endregion
    }
}
