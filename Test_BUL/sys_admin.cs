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

using System.Data;
using System;

namespace Test_BUL
{
    /// <summary>
    /// sys_admin
    /// </summary>
    public partial class sys_admin
    {
        private readonly Test_DAL.sys_admin dal = new Test_DAL.sys_admin();
        public sys_admin()
        { }
        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Test_Model.sys_admin model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Test_Model.sys_admin model)
        {
            return dal.Update(model);
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
            return dal.UpdateLogin(count, ip, datetime);
        }

        /// <summary>
        /// 更新管理员密码
        /// </summary>
        /// <param name="userid"0>系统用户id</param>
        /// <param name="oldpassword">用户原始密码</param>
        /// <param name="password">用户当前密码</param>
        public bool UpdatePwd(int userid, string oldpassword, string password)
        {
            return dal.UpdatePwd(userid, oldpassword, password);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Test_Model.sys_admin GetModel(int id)
        {
            return dal.GetModel(id);
        }

        /// <summary>
        /// 获取数据集
        /// </summary>
        /// <returns></returns>
        public DataSet GetList()
        {
            string strSql = @"select tb_sys_admin.id,[count],telephone,loginTime,sex,AccountState,PowerLeave,tb_sys_role.roleName from tb_sys_admin
                                left join tb_sys_role on tb_sys_role.id=tb_sys_admin.roleid ";
            Test_BUL.sys_Common common = new Test_BUL.sys_Common();

            return common.GetList(strSql);
        }
        #endregion  Method
    }
}

