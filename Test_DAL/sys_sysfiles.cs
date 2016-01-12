/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: sys_sysfiles
** Remarks: 
** Varsion: 1.0
** Author:  Jon
** Contact: 573741776@qq.com
** Last Edit User: 
** Last Edit Time: 2013-01-10
** Statement: 
**-----------------------------------------------------------------
******************************************************************/

using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
//Please add references
using Test_DBUtility;

namespace Test_DAL
{
    /// <summary>
    /// 数据访问类:sys_sysfiles
    /// </summary>
    public partial class sys_sysfiles
    {
        public readonly string connectionString = SqlHelper.LocalSqlServer;
        public sys_sysfiles()
        { }
        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Test_Model.sys_sysfiles model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_sys_sysfiles(");
            strSql.Append("classId,fielsName,filesUrl,describe,showLeft,addTime,addUserId,addUser,filesOrder)");
            strSql.Append(" values (");
            strSql.Append("@classId,@fielsName,@filesUrl,@describe,@showLeft,@addTime,@addUserId,@addUser,@filesOrder)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@classId", SqlDbType.Int,4),
					new SqlParameter("@fielsName", SqlDbType.NChar,10),
					new SqlParameter("@filesUrl", SqlDbType.NVarChar,50),
					new SqlParameter("@describe", SqlDbType.NVarChar,20),
					new SqlParameter("@showLeft", SqlDbType.Bit,1),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@addUserId", SqlDbType.Int,4),
					new SqlParameter("@addUser", SqlDbType.NVarChar,15),
                    new SqlParameter("@filesOrder", SqlDbType.Int,4)
                    };
            parameters[0].Value = model.classId;
            parameters[1].Value = model.fielsName;
            parameters[2].Value = model.filesUrl;
            parameters[3].Value = model.describe;
            parameters[4].Value = model.showLeft;
            parameters[5].Value = model.addTime;
            parameters[6].Value = model.addUserId;
            parameters[7].Value = model.addUser;
            parameters[8].Value = model.filesOrder;

            object obj = SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Test_Model.sys_sysfiles model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_sys_sysfiles set ");
            strSql.Append("classId=@classId,");
            strSql.Append("fielsName=@fielsName,");
            strSql.Append("filesUrl=@filesUrl,");
            strSql.Append("describe=@describe,");
            strSql.Append("showLeft=@showLeft,");
            strSql.Append("addTime=@addTime,");
            strSql.Append("addUserId=@addUserId,");
            strSql.Append("addUser=@addUser,");
            strSql.Append("filesOrder=@filesOrder");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@classId", SqlDbType.Int,4),
					new SqlParameter("@fielsName", SqlDbType.NChar,10),
					new SqlParameter("@filesUrl", SqlDbType.NVarChar,50),
					new SqlParameter("@describe", SqlDbType.NVarChar,20),
					new SqlParameter("@showLeft", SqlDbType.Bit,1),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@addUserId", SqlDbType.Int,4),
					new SqlParameter("@addUser", SqlDbType.NVarChar,15),
					new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@filesOrder", SqlDbType.Int,4)};
            parameters[0].Value = model.classId;
            parameters[1].Value = model.fielsName;
            parameters[2].Value = model.filesUrl;
            parameters[3].Value = model.describe;
            parameters[4].Value = model.showLeft;
            parameters[5].Value = model.addTime;
            parameters[6].Value = model.addUserId;
            parameters[7].Value = model.addUser;
            parameters[8].Value = model.id;
            parameters[9].Value = model.filesOrder;

            int rows = SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            return rows > 0;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Test_Model.sys_sysfiles GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,classId,fielsName,filesUrl,describe,showLeft,addTime,addUserId,addUser,filesOrder from tb_sys_sysfiles ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Test_Model.sys_sysfiles model = new Test_Model.sys_sysfiles();
            DataSet ds = SqlHelper.ExecuteDataSet(connectionString, strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["classId"].ToString() != "")
                {
                    model.classId = int.Parse(ds.Tables[0].Rows[0]["classId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["fielsName"] != null)
                {
                    model.fielsName = ds.Tables[0].Rows[0]["fielsName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["filesUrl"] != null)
                {
                    model.filesUrl = ds.Tables[0].Rows[0]["filesUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["describe"] != null)
                {
                    model.describe = ds.Tables[0].Rows[0]["describe"].ToString();
                }
                if (ds.Tables[0].Rows[0]["showLeft"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["showLeft"].ToString() == "1") || (ds.Tables[0].Rows[0]["showLeft"].ToString().ToLower() == "true"))
                    {
                        model.showLeft = true;
                    }
                    else
                    {
                        model.showLeft = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["addTime"].ToString() != "")
                {
                    model.addTime = DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["addUserId"].ToString() != "")
                {
                    model.addUserId = int.Parse(ds.Tables[0].Rows[0]["addUserId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["addUser"] != null)
                {
                    model.addUser = ds.Tables[0].Rows[0]["addUser"].ToString();
                }
                if (ds.Tables[0].Rows[0]["filesOrder"] != null)
                {
                    model.filesOrder = int.Parse(ds.Tables[0].Rows[0]["filesOrder"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select id,classId,fielsName,filesUrl,describe,showLeft,addTime,addUserId,addUser,filesOrder ");
            strSql.Append(" FROM tb_sys_sysfiles ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SqlHelper.ExecuteDataSet(connectionString, strSql.ToString());
        }

        #endregion  Method
    }
}