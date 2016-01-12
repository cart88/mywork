/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: sys_Common
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
using System.Collections.Generic;
using System.Data;
using Test_DBUtility;
using System.Text;
using System.Data.SqlClient;

namespace Test_DAL
{
    public class sys_Common
    {
        public readonly string connectionString = SqlHelper.LocalSqlServer;

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int id, string tablename)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from " + tablename + " ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            return SqlHelper.ExistsRecord(connectionString, strSql.ToString(), parameters);
        }

        #region 删除数据
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string tableName, int id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + tableName + " ");
            strSql.Append(" where id=@id");
            SqlParameter[] parameters = {
					new SqlParameter("@id", SqlDbType.Int,4)
            };
            parameters[0].Value = id;

            int rows = SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            return rows > 0;
        }

        public bool Delete(string tableName, string where)
        {
            if (string.IsNullOrEmpty(where.Trim()))
                return false;

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + tableName + " ");
            strSql.Append(" where " + where);

            int rows = SqlHelper.ExecuteSql(connectionString, strSql.ToString());
            return rows > 0;
        }
        /// <summary>
        /// 删除一组数据
        /// </summary>
        public bool DeleteList(string tableName, string idlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from " + tableName + " ");
            strSql.Append(" where id in (" + idlist + ")  ");
            int rows = Test_DBUtility.SqlHelper.ExecuteSql(connectionString, strSql.ToString());

            return rows > 0;
        }
        #endregion

        /// <summary>
        /// 执行简单的SQL语句,返回受影响的行数
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句,select语句不行</param>
        /// <returns></returns>
        public int ExecuteSql(string strSQL)
        {
            return SqlHelper.ExecuteSql(connectionString, strSQL);
        }

        /// <summary>
        /// 执行多条SQL语句，实现数据库事务
        /// </summary>
        /// <param name="list">多条SQL语句</param>
        /// <returns>执行事务影响的行数</returns>
        public bool ExecuteManySqlTran(List<String> list)
        {
            return SqlHelper.ExecuteSqlTran(connectionString, list) > 0;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strsql)
        {
            return SqlHelper.ExecuteDataSet(connectionString, strsql.ToString());
        }
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="table">表或者视图名</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="filedName">要取的字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pagesize">每页显示数</param>
        /// <param name="pageindex">当前页码</param>
        /// <param name="orderBy">排序规则</param>
        /// <returns></returns>
        public DataSet Up2PageInfo(string table, string orderField, string filedName, string strWhere, int pagesize, int pageindex, int orderBy)
        {
            return SqlHelper.PageList(connectionString, table, filedName, orderField, pagesize, pageindex, 0, orderBy, strWhere);
        }
        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="table">表或者视图名</param>
        /// <param name="orderField">排序字段</param>
        /// <param name="filedName">要取的字段</param>
        /// <param name="strWhere">查询条件</param>
        /// <param name="pagesize">每页显示数</param>
        /// <param name="pageindex">当前页码</param>
        /// <returns></returns>
        public DataSet Up2PageInfo(string table, string orderField, string filedName, string strWhere, int pagesize, int pageindex)
        {
            return SqlHelper.PageList(connectionString, table, filedName, orderField, pagesize, pageindex, 0, 1, strWhere);
        }
    }
}