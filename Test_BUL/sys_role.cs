/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
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
using System.Collections.Generic;

namespace Test_BUL
{
    /// <summary>
    /// sys_role
    /// </summary>
    public partial class sys_role
    {
        private readonly Test_DAL.sys_role dal = new Test_DAL.sys_role();
        public sys_role()
        { }
        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Test_Model.sys_role model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Test_Model.sys_role model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Test_Model.sys_role GetModel(int id)
        {
            return dal.GetModel(id);
        }

        #endregion  Method
    }
}

