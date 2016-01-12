/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: sys_admin
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
//Please add references
using Test_DBUtility;

namespace Test_DAL
{
    /// <summary>
    /// 数据访问类:sys_admin
    /// </summary>
    public partial class sys_admin
    {
        public readonly string connectionString = SqlHelper.LocalSqlServer;
        public sys_admin()
        { }
        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Test_Model.sys_admin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_sys_admin(");
            strSql.Append("count,password,loginIP,loginTime,telephone,email,sex,birthday,createTime,roleid,adminTag,AccountState,PowerLeave)");
            strSql.Append(" values (");
            strSql.Append("@count,@password,@loginIP,@loginTime,@telephone,@email,@sex,@birthday,@createTime,@roleid,@adminTag,@AccountState,@PowerLeave)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@count", SqlDbType.NVarChar,10),
					new SqlParameter("@password", SqlDbType.NVarChar,40),
					new SqlParameter("@loginIP", SqlDbType.NVarChar,15),
					new SqlParameter("@loginTime", SqlDbType.DateTime),
					new SqlParameter("@telephone", SqlDbType.NVarChar,11),
					new SqlParameter("@email", SqlDbType.NVarChar,30),
					new SqlParameter("@sex", SqlDbType.Bit,1),
					new SqlParameter("@birthday", SqlDbType.DateTime),
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@roleid", SqlDbType.TinyInt,1),
					new SqlParameter("@adminTag", SqlDbType.TinyInt,1),
					new SqlParameter("@AccountState", SqlDbType.TinyInt,1),
					new SqlParameter("@PowerLeave", SqlDbType.NVarChar,5)};
            parameters[0].Value = model.count;
            parameters[1].Value = model.password;
            parameters[2].Value = model.loginIP;
            parameters[3].Value = model.loginTime;
            parameters[4].Value = model.telephone;
            parameters[5].Value = model.email;
            parameters[6].Value = model.sex;
            parameters[7].Value = model.birthday;
            parameters[8].Value = model.createTime;
            parameters[9].Value = model.roleid;
            parameters[10].Value = model.adminTag;
            parameters[11].Value = model.AccountState;
            parameters[12].Value = model.PowerLeave;

            object obj = Test_DBUtility.SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
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
        public bool Update(Test_Model.sys_admin model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_sys_admin set ");
            strSql.Append("count=@count,");
            strSql.Append("telephone=@telephone,");
            strSql.Append("email=@email,");
            strSql.Append("sex=@sex,");
            strSql.Append("birthday=@birthday,");
            strSql.Append("createTime=@createTime,");
            strSql.Append("roleid=@roleid,");
            strSql.Append("adminTag=@adminTag,");
            strSql.Append("AccountState=@AccountState,");
            strSql.Append("PowerLeave=@PowerLeave");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@count", SqlDbType.NVarChar,10),					
					new SqlParameter("@telephone", SqlDbType.NVarChar,11),
					new SqlParameter("@email", SqlDbType.NVarChar,30),
					new SqlParameter("@sex", SqlDbType.Bit,1),
					new SqlParameter("@birthday", SqlDbType.DateTime),
					new SqlParameter("@createTime", SqlDbType.DateTime),
					new SqlParameter("@roleid", SqlDbType.TinyInt,1),
					new SqlParameter("@adminTag", SqlDbType.TinyInt,1),
					new SqlParameter("@AccountState", SqlDbType.TinyInt,1),
					new SqlParameter("@id", SqlDbType.Int,4),
                    new SqlParameter("@PowerLeave", SqlDbType.NVarChar,5)};
            parameters[0].Value = model.count;
            parameters[1].Value = model.telephone;
            parameters[2].Value = model.email;
            parameters[3].Value = model.sex;
            parameters[4].Value = model.birthday;
            parameters[5].Value = model.createTime;
            parameters[6].Value = model.roleid;
            parameters[7].Value = model.adminTag;
            parameters[8].Value = model.AccountState;
            parameters[9].Value = model.id;
            parameters[10].Value = model.PowerLeave;

            int rows = Test_DBUtility.SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            return rows > 0;
        }
        /// <summary>
        /// 更新登录信息
        /// </summary>
        /// <param name="count">用户名</param>
        /// <param name="ip">ip</param>
        /// <param name="datetime">登录时间</param>
        /// <returns></returns>
        public bool UpdateLogin(string count, string ip, DateTime datetime)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_sys_admin set ");
            strSql.Append("loginIP=@loginIP,");
            strSql.Append("loginTime=@loginTime");
            strSql.Append(" where count=@count");
            SqlParameter[] parameters = {                    
					new SqlParameter("@loginIP", SqlDbType.NVarChar,15),					
					new SqlParameter("@loginTime", SqlDbType.DateTime),
                    new SqlParameter("@count", SqlDbType.NVarChar,10)};
            parameters[0].Value = ip;
            parameters[1].Value = datetime;
            parameters[2].Value = count;

            int rows = Test_DBUtility.SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            return rows > 0;
        }

        /// <summary>
        /// 更新管理员密码
        /// </summary>
        /// <param name="userid"0>系统用户id</param>
        /// <param name="oldpassword">用户原始密码</param>
        /// <param name="password">用户当前密码</param>
        public bool UpdatePwd(int userid, string oldpassword, string password)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_sys_admin set ");
            strSql.Append("password=@password ");
            strSql.Append(" where id=@id and password=@password ");
            SqlParameter[] parameters = { 
                new SqlParameter("@password", SqlDbType.NVarChar, 40),
                new SqlParameter("@id", SqlDbType.Int,4),
                new SqlParameter("@oldpassword", SqlDbType.NVarChar, 40)};
            parameters[0].Value = password;
            parameters[1].Value = userid;
            parameters[2].Value = oldpassword;

            int rows = Test_DBUtility.SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            return rows > 0;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Test_Model.sys_admin GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,count,password,loginIP,loginTime,telephone,email,sex,birthday,createTime,roleid,adminTag,AccountState,PowerLeave from tb_sys_admin ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Test_Model.sys_admin model = new Test_Model.sys_admin();
            DataSet ds = Test_DBUtility.SqlHelper.ExecuteDataSet(connectionString, strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["count"] != null)
                {
                    model.count = ds.Tables[0].Rows[0]["count"].ToString();
                }
                if (ds.Tables[0].Rows[0]["password"] != null)
                {
                    model.password = ds.Tables[0].Rows[0]["password"].ToString();
                }
                if (ds.Tables[0].Rows[0]["loginIP"] != null)
                {
                    model.loginIP = ds.Tables[0].Rows[0]["loginIP"].ToString();
                }
                if (ds.Tables[0].Rows[0]["loginTime"].ToString() != "")
                {
                    model.loginTime = DateTime.Parse(ds.Tables[0].Rows[0]["loginTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["telephone"] != null)
                {
                    model.telephone = ds.Tables[0].Rows[0]["telephone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["email"] != null)
                {
                    model.email = ds.Tables[0].Rows[0]["email"].ToString();
                }
                if (ds.Tables[0].Rows[0]["sex"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["sex"].ToString() == "1") || (ds.Tables[0].Rows[0]["sex"].ToString().ToLower() == "true"))
                    {
                        model.sex = true;
                    }
                    else
                    {
                        model.sex = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["birthday"].ToString() != "")
                {
                    model.birthday = DateTime.Parse(ds.Tables[0].Rows[0]["birthday"].ToString());
                }
                if (ds.Tables[0].Rows[0]["createTime"].ToString() != "")
                {
                    model.createTime = DateTime.Parse(ds.Tables[0].Rows[0]["createTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["roleid"].ToString() != "")
                {
                    model.roleid = int.Parse(ds.Tables[0].Rows[0]["roleid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["adminTag"].ToString() != "")
                {
                    model.adminTag = int.Parse(ds.Tables[0].Rows[0]["adminTag"].ToString());
                }
                if (ds.Tables[0].Rows[0]["AccountState"].ToString() != "")
                {
                    model.AccountState = int.Parse(ds.Tables[0].Rows[0]["AccountState"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PowerLeave"].ToString() != "")
                {
                    model.PowerLeave = ds.Tables[0].Rows[0]["PowerLeave"].ToString();
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