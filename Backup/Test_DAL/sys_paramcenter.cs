/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: sys_paramcenter
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
using System.Data.SqlClient;
using System.Text;
using Test_DBUtility;

namespace Maticsoft.DAL
{
    /// <summary>
    /// 数据访问类:sys_paramcenter
    /// </summary>
    public partial class sys_paramcenter
    {
        protected readonly string connectionString = SqlHelper.LocalSqlServer;

        public sys_paramcenter()
        { }
        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Test_Model.sys_paramcenter model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_sys_paramcenter(");
            strSql.Append("name,value,typeTag,addUserId,addUserName,addTime)");
            strSql.Append(" values (");
            strSql.Append("@name,@value,@typeTag,@addUserId,@addUserName,@addTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@value", SqlDbType.Int,4),
					new SqlParameter("@typeTag", SqlDbType.NVarChar,10),
					new SqlParameter("@addUserId", SqlDbType.Int,4),
					new SqlParameter("@addUserName", SqlDbType.NVarChar,15),
					new SqlParameter("@addTime", SqlDbType.DateTime)};
            parameters[0].Value = model.name;
            parameters[1].Value = model.value;
            parameters[2].Value = model.typeTag;
            parameters[3].Value = model.addUserId;
            parameters[4].Value = model.addUserName;
            parameters[5].Value = model.addTime;

            object obj = SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            if (obj == null)
                return 0;
            else
                return Convert.ToInt32(obj);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Test_Model.sys_paramcenter model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_sys_paramcenter set ");
            strSql.Append("name=@name,");
            strSql.Append("value=@value,");
            strSql.Append("typeTag=@typeTag,");
            strSql.Append("addUserId=@addUserId,");
            strSql.Append("addUserName=@addUserName,");
            strSql.Append("addTime=@addTime");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@name", SqlDbType.NVarChar,50),
					new SqlParameter("@value", SqlDbType.Int,4),
					new SqlParameter("@typeTag", SqlDbType.NVarChar,10),
					new SqlParameter("@addUserId", SqlDbType.Int,4),
					new SqlParameter("@addUserName", SqlDbType.NVarChar,15),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.name;
            parameters[1].Value = model.value;
            parameters[2].Value = model.typeTag;
            parameters[3].Value = model.addUserId;
            parameters[4].Value = model.addUserName;
            parameters[5].Value = model.addTime;
            parameters[6].Value = model.id;

            int rows = SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            return rows > 0;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Test_Model.sys_paramcenter GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,name,value,typeTag,addUserId,addUserName,addTime from tb_sys_paramcenter ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Test_Model.sys_paramcenter model = new Test_Model.sys_paramcenter();
            DataSet ds = SqlHelper.ExecuteDataSet(connectionString, strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["name"] != null)
                {
                    model.name = ds.Tables[0].Rows[0]["name"].ToString();
                }
                if (ds.Tables[0].Rows[0]["value"].ToString() != "")
                {
                    model.value = int.Parse(ds.Tables[0].Rows[0]["value"].ToString());
                }
                if (ds.Tables[0].Rows[0]["typeTag"] != null)
                {
                    model.typeTag = ds.Tables[0].Rows[0]["typeTag"].ToString();
                }
                if (ds.Tables[0].Rows[0]["addUserId"].ToString() != "")
                {
                    model.addUserId = int.Parse(ds.Tables[0].Rows[0]["addUserId"].ToString());
                }
                if (ds.Tables[0].Rows[0]["addUserName"] != null)
                {
                    model.addUserName = ds.Tables[0].Rows[0]["addUserName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["addTime"].ToString() != "")
                {
                    model.addTime = DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
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
            strSql.Append("select id,name,value,typeTag,addUserId,addUserName,addTime ");
            strSql.Append(" FROM tb_sys_paramcenter ");
            if (strWhere.Trim() != "")
                strSql.Append(" where " + strWhere);

            return SqlHelper.ExecuteDataSet(connectionString, strSql.ToString());
        }

        #endregion  Method
    }
}