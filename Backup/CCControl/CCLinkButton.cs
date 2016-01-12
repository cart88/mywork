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
using System.Web.UI.WebControls;
using System.Web.UI;
using System.ComponentModel;


namespace CCControl
{
    [DefaultProperty("Text"), ToolboxData("<{0}:CCLinkButton runat=server />")]
    public class CCLinkButton : LinkButton, ICustomControl
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
        /// 点击时执行Js内容
        /// </summary>
        /// <returns></returns>
        [Bindable(true), Category("ClickEvent"), DefaultValue(""), Localizable(true)]
        public string ClickEvent
        {
            set { ViewState["ClickEvent"] = value; }
            get { return ViewState["ClickEvent"] != null ? ViewState["ClickEvent"].ToString() : string.Empty; }
        }

        /// <summary>
        /// 功能权限值
        /// <remarks>按钮操作权限级别</remarks>
        /// </summary>
        [Bindable(true), Category("LevelPower"), DefaultValue(LevelPower.M12), Localizable(true)]
        public LevelPower LevelPower
        {
            set { ViewState["LevelPower"] = value; }
            get { return ViewState["LevelPower"] != null ? (LevelPower)ViewState["LevelPower"] : LevelPower.M12; }
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
            if (Enabled)
            {
                string strOnClickJS = string.Empty;
                if (!string.IsNullOrEmpty(ClickEvent))
                    strOnClickJS += ClickEvent;
                if (!string.IsNullOrEmpty(strOnClickJS))
                    Attributes["onclick"] = strOnClickJS;
                
                //if (string.IsNullOrEmpty(NavigateUrl))
                //    NavigateUrl = "javascript:void(0);";
                //else
                //    NavigateUrl = (IsLinkEncrypt && (NavigateUrl.IndexOf("md=") < 0)) ? CCUtilsComplex.UrlMD5(NavigateUrl) : NavigateUrl;

            }
            else
                this.Attributes.Remove("onclick");
        }
    }
}
