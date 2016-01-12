/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: UserCenter
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
using System.Web;
using System.Data;

namespace BasePage
{
    /// <summary>
    /// 用户中心
    /// </summary>
    public class UserCenter : BasicPage
    {
        override protected void OnInit(EventArgs e)
        {
            base.OnInit(e);
        }

        /// <summary>
        /// 用户是否登录了
        /// </summary>
        /// <returns></returns>
        public bool CheckLogin()
        {
            //...
            return true;
        }

        /// <summary>
        /// 用户的个信息是否完善
        /// </summary>
        public bool CheckUserInfoComplete()
        {
            //...
            return true;
        }

        /// <summary>
        /// 获取用户的当前积分
        /// <remarks>总积分|兑换积分</remarks>
        /// </summary>
        /// <returns>xxx|xxx 结构</returns>
        public string GetUserIntegral()
        {
            //...
            return "xxx|xxx";
        }


        public DataSet GetUserOrder()
        {
            DataSet ds = null;
            //...
            return ds;
        }
    }
}
