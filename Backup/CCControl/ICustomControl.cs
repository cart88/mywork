/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: CCLinkButton
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
using System.ComponentModel;

namespace CCControl
{
    /// <summary>
    /// 自定义控件的统一接口
    /// </summary>
    public interface ICustomControl
    {
        /// <summary>
        /// 功能权限值
        /// <remarks>按钮操作权限级别</remarks>
        /// </summary>
        [Bindable(true), Category("LevelPower"), DefaultValue(LevelPower.M12), Localizable(true)]
        LevelPower LevelPower { set; get; }

        /// <summary>
        /// 无权限时的状态
        /// </summary>
        [Bindable(true), Category("Rights"), DefaultValue(NoRightModle.Disabled), Localizable(true)]
        NoRightModle NoRightModle { set; get; }
    }
}
