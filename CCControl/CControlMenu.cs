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
using Tools;

namespace CCControl
{
    /// <summary>
    /// 按钮操作文本
    /// </summary>
    public enum HandlerType
    {
        新增,
        删除,
        修改,
        提交
    }

    /// <summary>
    /// 无权限时模式
    /// </summary>
    public enum NoRightModle
    {
        /// <summary>
        /// 禁用
        /// </summary>
        Disabled,
        /// <summary>
        /// 隐藏
        /// </summary>
        Hidden
    }

    /// <summary>
    /// 行政级别大小
    /// </summary>
    public enum LevelPower
    {
        /// <summary>
        /// 员工
        /// </summary>
        [EnumAttribute("员工")]
        M1 = 1,
        /// <summary>
        /// 组长
        /// </summary>
        [EnumAttribute("组长")]
        M2 = 2,
        /// <summary>
        /// 部门经理
        /// </summary>
        [EnumAttribute("部门经理")]
        M3 = 4,
        /// <summary>
        /// 部门主管
        /// </summary>
        [EnumAttribute("部门主管")]
        M4 = 8,
        /// <summary>
        /// 中心领导
        /// </summary>
        [EnumAttribute("中心领导")]
        M5 = 16,
        /// <summary>
        /// 区域经理
        /// </summary>
        [EnumAttribute("区域经理")]
        M6 = 32,
        /// <summary>
        /// 人事
        /// </summary>
        [EnumAttribute("人事")]
        M7 = 64,
        /// <summary>
        /// 财务
        /// </summary>
        [EnumAttribute("财务")]
        M8 = 128,
        /// <summary>
        /// 副总裁
        /// </summary>
        [EnumAttribute("副总裁")]
        M9 = 256,
        /// <summary>
        /// 高级副总裁
        /// </summary>
        [EnumAttribute("高级副总裁")]
        M10 = 512,
        /// <summary>
        /// 总裁
        /// </summary>
        [EnumAttribute("总裁")]
        M11 = 1024,
        /// <summary>
        /// 研发人员(超级后门)
        /// </summary>
        [EnumAttribute("研发人员")]
        M12 = 2048
    }
}