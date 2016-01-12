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
using System.ComponentModel;
using System.Web.UI.WebControls;
using System.Web.UI;

namespace CCControl
{
    [DefaultProperty("Text"), ToolboxData("<{0}:CCHyperLink runat=server />")]
    public class CCHyperLink : HyperLink, ICustomControl
    {
        /// <summary>
        /// 是否对超链接进行MD5校验
        /// </summary>
        [Bindable(true), Category("EncryptUrl"), DefaultValue(true), Localizable(true)]
        public bool IsLinkEncrypt
        {
            set { ViewState["IsLinkEncrypt"] = value; }
            get { return ViewState["IsLinkEncrypt"] != null ? (bool)ViewState["IsLinkEncrypt"] : true; }
        }

        /// <summary>
        /// 功能权限值
        /// <remarks>按钮操作权限级别</remarks>
        /// </summary>
        [Bindable(true), Category("LevelPower"), DefaultValue(LevelPower.M1), Localizable(true)]
        public LevelPower LevelPower
        {
            set { ViewState["LevelPower"] = value; }
            get { return ViewState["LevelPower"] != null ? (LevelPower)ViewState["LevelPower"] : LevelPower.M1; }
        }

        /// <summary>
        /// 无权限时状态
        /// </summary>
        [Bindable(true), Category("Rights"), DefaultValue(NoRightModle.Disabled), Localizable(true)]
        public NoRightModle NoRightModle
        {
            set { ViewState["NoRightModle"] = value; }
            get { return ViewState["NoRightModle"] != null ? (NoRightModle)ViewState["NoRightModle"] : NoRightModle.Disabled; }
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            if (string.IsNullOrEmpty(NavigateUrl))
                NavigateUrl = "javascript:void(0);";
            else
                NavigateUrl = (IsLinkEncrypt && (NavigateUrl.IndexOf("md=") < 0)) ? CCUtilsComplex.UrlMD5(NavigateUrl) : NavigateUrl;
        }
    }
}