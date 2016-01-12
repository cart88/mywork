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
using System.Text;

namespace Test_BUL
{
    public class sys_Common
    {
        private readonly Test_DAL.sys_Common dal = new Test_DAL.sys_Common();

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Exists(int id, string tablename)
        {
            return dal.Exists(id, tablename);
        }

        #region 构建单表SQL查询语句

        /// <summary>
        /// 自定义SQL语句
        /// </summary>
        /// <param name="tbName">表名</param>
        /// <param name="colFiledName">字段名[可以为""]</param>
        /// <param name="where">查询条件[可以为""]</param>
        /// <returns>SQL语句</returns>
        public string GetCustomDSsql(string tbName, string colFiledName, string where)
        {
            return GetCustomDSsql(-1, tbName, colFiledName, where, "", "");
        }
        /// <summary>
        /// 自定义SQL语句
        /// </summary>
        /// <param name="tbName">表名</param>
        /// <param name="colFiledName">字段名[可以为""]</param>
        /// <param name="where">查询条件[可以为""]</param>
        /// <param name="orderBy">排序字段[可以为""]</param>
        /// <param name="orderTag">排序规则[DESC、ASC]</param>
        /// <returns>SQL语句</returns>
        public string GetCustomDSsql(string tbName, string colFiledName, string where, string orderBy, string orderTag)
        {
            return GetCustomDSsql(-1, tbName, colFiledName, where, orderBy, orderTag);
        }
        /// <summary>
        /// 自定义SQL语句
        /// </summary>
        /// <param name="count">数量[小于0时表示全部选出]</param>
        /// <param name="tbName">表名</param>
        /// <param name="colFiledName">列名字符串[可以为""]</param>
        /// <param name="where">查询条件[可以为""]</param>
        /// <param name="orderBy">排序字段[可以为""]</param>
        /// <param name="orderTag">排序规则[DESC、ASC]</param>
        /// <returns>SQL语句</returns>
        public string GetCustomDSsql(int count, string tbName, string colFiledName, string where, string orderBy, string orderTag)
        {
            StringBuilder strbld = new StringBuilder();
            strbld.Append(" select ");
            strbld.Append(count > 0 ? " top " + count.ToString() + " " : " ");
            strbld.Append(colFiledName.Trim().Length > 0 ? colFiledName : " * ");
            strbld.Append(" from " + tbName);
            strbld.Append(where.Trim().Length != 0 ? " where " + where : " ");
            strbld.Append(orderBy.Trim().Length != 0 ? " order by " + orderBy + " " : " ");
            strbld.Append(" " + orderTag);

            return strbld.ToString();
        }

        #endregion

        #region 删除数据
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string tableName, int id)
        {
            return dal.Delete(tableName, id);
        }

        public bool Delete(string tableName, string where)
        {
            return dal.Delete(tableName, where);
        }
        /// <summary>
        /// 删除一组数据
        /// </summary>
        public bool DeleteList(string tableName, string idlist)
        {
            return dal.DeleteList(tableName, idlist);
        }
        #endregion

        /// <summary>
        /// 执行简单的SQL语句,返回受影响的行数
        /// </summary>
        /// <param name="strSQL">要执行的SQL语句,select语句不行</param>
        /// <returns></returns>
        public int ExecuteSql(string strSQL)
        {
            return dal.ExecuteSql(strSQL);
        }
        /// <summary>
        /// 执行多条SQL语句，实现数据库事务
        /// </summary>
        /// <param name="list">多条SQL语句</param>
        /// <returns>执行事务影响的行数</returns>
        public bool ExecuteManySqlTran(List<String> list)
        {
            return dal.ExecuteManySqlTran(list);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strsql)
        {
            return dal.GetList(strsql);
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
        /// <param name="orderBy">排序规则<remarks>大于1为自定义排序</remarks></param>
        /// <returns></returns>
        public DataSet Up2PageInfo(string table, string orderField, string filedName, string strWhere, int pagesize, int pageindex, int orderBy)
        {
            return dal.Up2PageInfo(table, orderField, filedName, strWhere, pagesize, pageindex, orderBy);
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
            return dal.Up2PageInfo(table, orderField, filedName, strWhere, pagesize, pageindex);
        }

        /// <summary>
        /// 分页控件
        /// </summary>
        /// <param name="PageSize">每页显示</param>
        /// <param name="CurrentIndex">当前页</param>
        /// <param name="PageCount">总页数</param>
        /// <param name="Url">跳转的URL</param>
        /// <param name="paramType">URL的其他参数<remarks>注意：改参数前面有&符号</remarks></param>
        /// <returns></returns>
        public string HtmlPageBar(int PageSize, int CurrentIndex, int PageCount, string Url, string paramType)
        {
            StringBuilder strb = new StringBuilder("");
            strb.Append(" <div id=\"J_pagination\" class=\"med-pagination\"> ");
            strb.Append("   <div class=\"pages\"> ");

            if (CurrentIndex < 1 || CurrentIndex > PageCount)
            {
                strb.Append(" <a class=\"first-disabled\">首页</a><a class=\"prev-disabled\"><span><s class=\"prev_s\"></s><s class=\"prev_s2\"></s></span>上一页</a> ");
                strb.Append(" <a>亲，木有了</a> ");
                strb.Append(" <a class=\"next-disabled\"><span><s class=\"next_s\"></s><s class=\"next_s2\"></s></span>下一页</a><a class=\"last-disabled\">末页</a> ");
            }
            else
            {
                strb.Append(CurrentIndex == 1 ? " <a class=\"first-disabled\">首页</a> <a class=\"prev-disabled\"><span><s class=\"prev_s\"></s><s class=\"prev_s2\"></s></span>上一页</a> " :
                    " <a href=\"" + Url + "?p=1" + paramType + "\" title=\"首页\" class=\"first\">首页</a> <a href=\"" + Url + "?p=" + (CurrentIndex - 1).ToString() + paramType
                    + "\" title=\"上一页\" class=\"prev\"><span><s class=\"prev_s\"></s><s class=\"prev_s2\"></s></span>上一页</a> ");
                #region 只显示8个数字+...
                if ((CurrentIndex - 4) > 0)
                    strb.Append("<a href=\"" + Url + "?p=" + 1 + paramType + "\" title=\"第1页\">" + 1 + "</a>");
                if ((CurrentIndex - 5) > 0)
                    strb.Append("<a>...</a>");
                for (int i = (CurrentIndex - 3) > 0 ? (CurrentIndex - 3) : 1; i <= ((CurrentIndex + 3) <= PageCount ? (CurrentIndex + 3) : PageCount); i++)
                {
                    if (i == CurrentIndex)
                        strb.Append("<a class=\"current\" title=\"第" + i + "页\">" + i + "</a>");
                    else
                        strb.Append("<a href=\"" + Url + "?p=" + i + paramType + "\" title=\"第" + i + "页\">" + i + "</a>");
                }
                if ((CurrentIndex + 4) < PageCount)
                {
                    strb.Append("<a>...</a>");
                    strb.Append("<a href=\"" + Url + "?p=" + PageCount + paramType + "\" title=\"第" + PageCount + "页\">" + PageCount + "</a>");
                }
                #endregion
                strb.Append(CurrentIndex == PageCount ? " <a class=\"next-disabled\"><span><s class=\"next_s\"></s><s class=\"next_s2\"></s></span>下一页</a> <a class=\"last-disabled\">末页</a> " :
                    " <a href=\"" + Url + "?p=" + (CurrentIndex + 1).ToString() + paramType + "\" title=\"下一页\" class=\"next\"><span><s class=\"next_s\"></s><s class=\"next_s2\"></s></span>下一页</a> <a href=\""
                    + Url + "?p=" + PageCount.ToString() + paramType + "\" title=\"末页\" class=\"last\">末页</a>");
            }

            strb.Append("   </div> ");
            strb.Append("   <div style=\"clear:both;\"></div> ");
            strb.Append(" </div> ");
            return strb.ToString();
        }

        /// <summary>
        /// 生成分页控件HTML
        /// </summary>
        /// <param name="PageSize">每页显示数</param>
        /// <param name="CurrentIndex">当前页</param> 
        /// <param name="PageCount">总页数</param>
        /// <param name="TotalDataCount">总记录数</param>
        /// <param name="pageURL">跳转URL</param>
        /// <param name="pParamQueStr">Request.QueryString</param>
        /// <returns>Page Bar HTML</returns>
        public string CreatePageBar(int PageSize, int CurrentIndex, int PageCount, int TotalDataCount, string pageURL, string pParamQueStr)
        {
            StringBuilder strbu = new StringBuilder("");

            strbu.Append("<div class=\"left\">共有&nbsp;&nbsp;<b>" + TotalDataCount + "</b>&nbsp;&nbsp;条数据，当前第&nbsp;&nbsp;<b>" + CurrentIndex + "</b>&nbsp;&nbsp;页</div>");
            strbu.Append("<div class=\"right\">");
            //strbu.Append("<a href=\"" + pageURL + "?p=1" + pParamQueStr + "\">首页</a><a href=\"" + pageURL + "?p=" + ((CurrentIndex - 1) != 0 ? CurrentIndex - 1 : 1).ToString() + pParamQueStr + " \">上一页</a>");
            strbu.Append("<a" + (CurrentIndex == 1 ? "" : " href=\"" + pageURL + "?p=1" + pParamQueStr + "\"") + ">首页</a>");
            strbu.Append("<a" + (CurrentIndex == 1 ? "" : " href=\"" + pageURL + "?p=" + (CurrentIndex - 1).ToString() + pParamQueStr + " \" ") + ">上一页</a>");
            for (int i = (CurrentIndex - 4) > 0 ? (CurrentIndex - 4) : 1; i <= ((CurrentIndex + 4) <= PageCount ? (CurrentIndex + 4) : PageCount); i++)
            {
                if (i == CurrentIndex)
                    strbu.Append("<a class=\"no\">" + i + "</a>");
                else
                    strbu.Append("<a href=\"" + pageURL + "?p=" + i + pParamQueStr + "\">" + i + "</a>");
            }
            if ((CurrentIndex + 5) < PageCount)
            {//当前页+5小于总页时，中间添加省略号

                strbu.Append("<a>...</a>");
                strbu.Append("<a href=\"" + pageURL + "?p=" + PageCount + pParamQueStr + "\">" + PageCount + "</a>");
            }
            //strbu.Append("<a href=\"" + pageURL + "?p=" + ((CurrentIndex) != PageCount ? CurrentIndex + 1 : PageCount).ToString() + pParamQueStr + "\">下一页</a><a href=\"" + pageURL + "?p=" + PageCount + pParamQueStr + "\">尾页</a>");
            strbu.Append("<a" + (CurrentIndex == PageCount ? "" : " href=\"" + pageURL + "?p=" + (CurrentIndex + 1).ToString() + pParamQueStr + "\" ") + ">下一页</a>");
            strbu.Append("<a" + (CurrentIndex == PageCount ? "" : " href=\"" + pageURL + "?p=" + PageCount + pParamQueStr + "\"") + ">尾页</a>");
            strbu.Append("</div>");

            return strbu.ToString();
        }
    }
}
