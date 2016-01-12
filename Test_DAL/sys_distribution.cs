/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: sys_distribution
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
    /// 数据访问类:sys_distribution
    /// </summary>
    public partial class sys_distribution
    {
        public readonly string connectionString = SqlHelper.LocalSqlServer;

        public sys_distribution()
        { }
        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Test_Model.sys_distribution model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_sys_distribution(");
            strSql.Append("userid,receiveName,postAddress,province,city,telephone,phone,zipCode,addtime)");
            strSql.Append(" values (");
            strSql.Append("@userid,@receiveName,@postAddress,@province,@city,@telephone,@phone,@zipCode,@addtime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@userid", SqlDbType.Int,4),
					new SqlParameter("@receiveName", SqlDbType.NVarChar,15),
					new SqlParameter("@postAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@province", SqlDbType.NVarChar,8),
					new SqlParameter("@city", SqlDbType.NVarChar,8),
					new SqlParameter("@telephone", SqlDbType.NVarChar,11),
					new SqlParameter("@phone", SqlDbType.NVarChar,15),
					new SqlParameter("@zipCode", SqlDbType.NVarChar,6),
					new SqlParameter("@addtime", SqlDbType.DateTime)};
            parameters[0].Value = model.userid;
            parameters[1].Value = model.receiveName;
            parameters[2].Value = model.postAddress;
            parameters[3].Value = model.province;
            parameters[4].Value = model.city;
            parameters[5].Value = model.telephone;
            parameters[6].Value = model.phone;
            parameters[7].Value = model.zipCode;
            parameters[8].Value = model.addtime;

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
        public bool Update(Test_Model.sys_distribution model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_sys_distribution set ");
            strSql.Append("userid=@userid,");
            strSql.Append("receiveName=@receiveName,");
            strSql.Append("postAddress=@postAddress,");
            strSql.Append("province=@province,");
            strSql.Append("city=@city,");
            strSql.Append("telephone=@telephone,");
            strSql.Append("phone=@phone,");
            strSql.Append("zipCode=@zipCode,");
            strSql.Append("addtime=@addtime");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@userid", SqlDbType.Int,4),
					new SqlParameter("@receiveName", SqlDbType.NVarChar,15),
					new SqlParameter("@postAddress", SqlDbType.NVarChar,100),
					new SqlParameter("@province", SqlDbType.NVarChar,8),
					new SqlParameter("@city", SqlDbType.NVarChar,8),
					new SqlParameter("@telephone", SqlDbType.NVarChar,11),
					new SqlParameter("@phone", SqlDbType.NVarChar,15),
					new SqlParameter("@zipCode", SqlDbType.NVarChar,6),
					new SqlParameter("@addtime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.userid;
            parameters[1].Value = model.receiveName;
            parameters[2].Value = model.postAddress;
            parameters[3].Value = model.province;
            parameters[4].Value = model.city;
            parameters[5].Value = model.telephone;
            parameters[6].Value = model.phone;
            parameters[7].Value = model.zipCode;
            parameters[8].Value = model.addtime;
            parameters[9].Value = model.id;

            int rows = SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            return rows > 0;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Test_Model.sys_distribution GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,userid,receiveName,postAddress,province,city,telephone,phone,zipCode,addtime from tb_sys_distribution ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Test_Model.sys_distribution model = new Test_Model.sys_distribution();
            DataSet ds = SqlHelper.ExecuteDataSet(connectionString, strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["userid"].ToString() != "")
                {
                    model.userid = int.Parse(ds.Tables[0].Rows[0]["userid"].ToString());
                }
                if (ds.Tables[0].Rows[0]["receiveName"] != null)
                {
                    model.receiveName = ds.Tables[0].Rows[0]["receiveName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["postAddress"] != null)
                {
                    model.postAddress = ds.Tables[0].Rows[0]["postAddress"].ToString();
                }
                if (ds.Tables[0].Rows[0]["province"] != null)
                {
                    model.province = ds.Tables[0].Rows[0]["province"].ToString();
                }
                if (ds.Tables[0].Rows[0]["city"] != null)
                {
                    model.city = ds.Tables[0].Rows[0]["city"].ToString();
                }
                if (ds.Tables[0].Rows[0]["telephone"] != null)
                {
                    model.telephone = ds.Tables[0].Rows[0]["telephone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["phone"] != null)
                {
                    model.phone = ds.Tables[0].Rows[0]["phone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["zipCode"] != null)
                {
                    model.zipCode = ds.Tables[0].Rows[0]["zipCode"].ToString();
                }
                if (ds.Tables[0].Rows[0]["addtime"].ToString() != "")
                {
                    model.addtime = DateTime.Parse(ds.Tables[0].Rows[0]["addtime"].ToString());
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
            strSql.Append("select id,userid,receiveName,postAddress,province,city,telephone,phone,zipCode,addtime ");
            strSql.Append(" FROM tb_sys_distribution ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SqlHelper.ExecuteDataSet(connectionString, strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        /// <param name="Top">数据行数
        /// <remarks>top小于0时进行全部筛选</remarks>
        /// </param>
        /// <param name="strWhere">过滤条件</param>
        /// <param name="filedOrder">排序字段</param>
        /// <returns></returns>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,userid,receiveName,postAddress,province,city,telephone,phone,zipCode,addtime ");
            strSql.Append(" FROM tb_sys_distribution ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return SqlHelper.ExecuteDataSet(connectionString, strSql.ToString());
        }

        #endregion  Method
    }
}