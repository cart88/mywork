/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: sys_sysmenu
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
    /// 数据访问类:sys_sysmenu
    /// </summary>
    public partial class sys_sysmenu
    {
        public readonly string connectionString = SqlHelper.LocalSqlServer;

        public sys_sysmenu()
        { }

        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Test_Model.sys_sysmenu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_sys_sysmenu(");
            strSql.Append("menuName,menuOrder,imgUrl,addName,addTime)");
            strSql.Append(" values (");
            strSql.Append("@menuName,@menuOrder,@imgUrl,@addName,@addTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@menuName", SqlDbType.NVarChar,10),
					new SqlParameter("@menuOrder", SqlDbType.Int,4),
					new SqlParameter("@imgUrl", SqlDbType.NVarChar,50),
					new SqlParameter("@addName", SqlDbType.NVarChar,10),
					new SqlParameter("@addTime", SqlDbType.DateTime)};
            parameters[0].Value = model.menuName;
            parameters[1].Value = model.menuOrder;
            parameters[2].Value = model.imgUrl;
            parameters[3].Value = model.addName;
            parameters[4].Value = model.addTime;

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
        public bool Update(Test_Model.sys_sysmenu model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_sys_sysmenu set ");
            strSql.Append("menuName=@menuName,");
            strSql.Append("menuOrder=@menuOrder,");
            strSql.Append("imgUrl=@imgUrl,");
            strSql.Append("addName=@addName,");
            strSql.Append("addTime=@addTime");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@menuName", SqlDbType.NVarChar,10),
					new SqlParameter("@menuOrder", SqlDbType.Int,4),
					new SqlParameter("@imgUrl", SqlDbType.NVarChar,50),
					new SqlParameter("@addName", SqlDbType.NVarChar,10),
					new SqlParameter("@addTime", SqlDbType.DateTime),
					new SqlParameter("@id", SqlDbType.Int,4)};
            parameters[0].Value = model.menuName;
            parameters[1].Value = model.menuOrder;
            parameters[2].Value = model.imgUrl;
            parameters[3].Value = model.addName;
            parameters[4].Value = model.addTime;
            parameters[5].Value = model.id;

            int rows = Test_DBUtility.SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            return rows > 0;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Test_Model.sys_sysmenu GetModel(int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 id,menuName,menuOrder,imgUrl,addName,addTime from tb_sys_sysmenu ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            Test_Model.sys_sysmenu model = new Test_Model.sys_sysmenu();
            DataSet ds = Test_DBUtility.SqlHelper.ExecuteDataSet(connectionString, strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["id"].ToString() != "")
                {
                    model.id = int.Parse(ds.Tables[0].Rows[0]["id"].ToString());
                }
                if (ds.Tables[0].Rows[0]["menuName"] != null)
                {
                    model.menuName = ds.Tables[0].Rows[0]["menuName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["menuOrder"].ToString() != "")
                {
                    model.menuOrder = int.Parse(ds.Tables[0].Rows[0]["menuOrder"].ToString());
                }
                if (ds.Tables[0].Rows[0]["imgUrl"] != null)
                {
                    model.imgUrl = ds.Tables[0].Rows[0]["imgUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["addName"] != null)
                {
                    model.addName = ds.Tables[0].Rows[0]["addName"].ToString();
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
            strSql.Append("select id,menuName,menuOrder,imgUrl,addName,addTime ");
            strSql.Append(" FROM tb_sys_sysmenu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by menuOrder asc ");
            return Test_DBUtility.SqlHelper.ExecuteDataSet(connectionString, strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" id,menuName,menuOrder,imgUrl,addName,addTime ");
            strSql.Append(" FROM tb_sys_sysmenu ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return Test_DBUtility.SqlHelper.ExecuteDataSet(connectionString, strSql.ToString());
        }

        #endregion  Method
    }
}