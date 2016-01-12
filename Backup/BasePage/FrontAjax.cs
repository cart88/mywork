/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: FrontAjax
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
using System.Text;
using System.Data;

namespace BasePage
{
    public class FrontAjax : BasicPage
    {
        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            if (!CheckFormUrl()) //不可直接在url下访问            
                Response.End();
            
            //...应该做一些其他方面的检查，比如限定IP（从配置文件中读取什么的），登录失败次数
        }
    }
}
