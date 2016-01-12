/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 ÿ�����һ���
** Name: sys_role
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
    /// ���ݷ�����:sys_role
    /// </summary>
    public partial class sys_role
    {
        public readonly string connectionString = SqlHelper.LocalSqlServer;
        public sys_role()
        { }
        #region  Method

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Test_Model.sys_role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_sys_role(");
            strSql.Append("roleName,pageId,addUser,addTime)");
            strSql.Append(" values (");
            strSql.Append("@roleName,@pageId,@addUser,@addTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@roleName", SqlDbType.NVarChar,10),
					new SqlParameter("@pageId", SqlDbType.NVarChar,150),
					new SqlParameter("@addUser", SqlDbType.NVarChar,15),
					new SqlParameter("@addTime", SqlDbType.DateTime)};
            parameters[0].Value = model.roleName;
            parameters[1].Value = model.pageId;
            parameters[2].Value = model.addUser;
            parameters[3].Value = model.addTime;

            object obj = SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            return obj == null ? 0 : Convert.ToInt32(obj);
        }
        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Update(Test_Model.sys_role model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_sys_role set ");
            strSql.Append("roleName=@roleName,");
            strSql.Append("pageId=@pageId,");
            strSql.Append("addUser=@addUser,");
            strSql.Append("addTime=@addTime");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@roleName", SqlDbType.NVarChar,10),
					new SqlParameter("@pageId", SqlDbType.NVarChar,150),
					new SqlParameter("@addUser", SqlDbType.NVarChar,15),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.roleName;
            parameters[1].Value = model.pageId;
            parameters[2].Value = model.addUser;
            parameters[3].Value = model.addTime;
            parameters[4].Value = model.id;

            int rows = SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            return rows > 0;
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Test_Model.sys_role GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,roleName,pageId,addUser,addTime from tb_sys_role ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Test_Model.sys_role model = new Test_Model.sys_role();
            DataSet ds = SqlHelper.ExecuteDataSet(connectionString, strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["roleName"] != null)
                {
                    model.roleName = ds.Tables[0].Rows[0]["roleName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["pageId"] != null)
                {
                    model.pageId = ds.Tables[0].Rows[0]["pageId"].ToString();
                }
                if (ds.Tables[0].Rows[0]["addUser"] != null)
                {
                    model.addUser = ds.Tables[0].Rows[0]["addUser"].ToString();
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

        #endregion  Method
    }
}