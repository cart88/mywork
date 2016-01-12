/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: SysCheck
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
using System.Text;
using System.Data;

namespace Test_BUL
{
    internal class sysCheck
    {
        #region 数据集校验
        /// <summary>
        /// 检查DataSet的合法性【检查datase中的所有表不为空】
        /// last edit by zhouzhilong 2011-10-19
        /// </summary>
        /// <param name="ds">数据集</param>
        /// <returns>成功1 ，失败0</returns>
        public static bool CheckDataSet(DataSet ds)
        {
            if (ds != null && ds.Tables.Count > 0)
            {
                for (int i = 0; i < ds.Tables.Count; i++)
                {
                    if (ds.Tables[i].Rows.Count < 0)
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }

        /// <summary>
        /// 检查dataset中指定表
        /// </summary>
        /// <param name="ds">数据集</param>
        /// <param name="table_i">数据集中的第几张表</param>
        /// <returns>有记录返回true，无记录返回false</returns>
        public static bool CheckDataSet(DataSet ds, int table_i)
        {
            if (ds != null && ds.Tables != null)
                if (ds.Tables[table_i].Rows.Count > 0)
                    return true;

            return false;
        }

        /// <summary>
        /// 检查DataTable的合法性
        /// last edit by zhouzhilong 2011-10-19
        /// </summary>
        /// <param name="dt"></param>
        /// <returns>成功1 ，失败0</returns>
        public static bool CheckDataTable(DataTable dt)
        {
            if (dt != null && dt.Rows.Count > 0)
                return true;

            return false;
        }

        #endregion
    }
}