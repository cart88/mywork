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
using System.Web;
using System.Data;
using System.Web.UI;
using CCControl;
using System.Web.UI.WebControls;

namespace BasePage
{
    public partial class PageUI : BasicPage
    {
        /// <summary>
        /// 该角色所对应的所有页面文件
        /// </summary>
        public string FileItems;
        /// <summary>
        /// 控件列表
        /// <remarks>用来装载页面上的所有自定义控件</remarks>
        /// </summary>
        private readonly List<Control> _rightControls;
        /// <summary>
        /// 构造
        /// </summary>
        public PageUI()
        {
            _rightControls = new List<Control>();
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);

            #region 设置页面自定义控件权限
            GetCustomServerButtons(Controls);
            InitControlsRight();
            #endregion
        }
        /// <summary>
        /// 获取自定义服务器控件
        /// <remarks>存放于_rightControls中</remarks>
        /// </summary>
        /// <param name="cc"></param>
        private void GetCustomServerButtons(ControlCollection cc)
        {
            foreach (Control c in cc)
            {
                if (c is ICustomControl)
                    _rightControls.Add(c);
                else if (c.HasControls())
                    GetCustomServerButtons(c.Controls);
            }
        }
        /// <summary>
        /// 初始化自定义控件
        /// </summary>
        /// <param name="dicRightvalue"></param>
        private void InitControlsRight()
        {
            foreach (Control obj in _rightControls)
            {
                switch (obj.GetType().Name)
                {
                    case "CCLinkButton":
                        CCLinkButton cclinkbutton = obj as CCLinkButton;
                        if (cclinkbutton != null && cclinkbutton.Enabled)
                            SetControlsRight(cclinkbutton);
                        break;
                    case "CCHyperLink":
                        CCHyperLink cchyperlink = obj as CCHyperLink;
                        if (cchyperlink != null && cchyperlink.Enabled)
                            SetControlsRight(cchyperlink);
                        break;
                }
            }
        }

        #region 设置控件是否有权限
        /// <summary>
        /// 获取用户行政级别大小
        /// </summary>
        /// <param name="_powervalue">行政级别标识,如：M2</param>
        /// <returns>行政级别数值大小</returns>
        private int GetLevelPowerValue(string _powervalue)
        {
            LevelPower getType = (LevelPower)Enum.Parse(typeof(LevelPower), _powervalue);
            return getType.GetHashCode();
        }
        private void SetControlsRight(CCLinkButton cclinkbutton)
        {
            //如果用户的行政权限 大于或等于 当前按钮要求的要求则做相关处理，否则隐藏或者不可用
            if (cclinkbutton == null || (GetLevelPowerValue(adminGetPowerLeave) < cclinkbutton.LevelPower.GetHashCode()))
            {
                if (cclinkbutton.NoRightModle == NoRightModle.Disabled) cclinkbutton.Enabled = false;
                else cclinkbutton.Visible = false;
            }
        }
        private void SetControlsRight(CCHyperLink cchyperlink)
        {
            //如果用户的行政权限 大于或等于 当前按钮要求的要求则做相关处理，否则隐藏或者不可用
            if (cchyperlink == null || (GetLevelPowerValue(adminGetPowerLeave) < cchyperlink.LevelPower.GetHashCode()))
            {
                if (cchyperlink.NoRightModle == NoRightModle.Disabled) cchyperlink.Enabled = false;
                else cchyperlink.Visible = false;
            }
        }
        #endregion

        protected override void OnInit(EventArgs e)
        {
            if (!CheckAdminLogin())
                FinalMessage("系统尚未登录或登录超时！", "./login.aspx", 0);
            else
            {
                #region Request对象地址栏参数检查
                //..
                #endregion
                #region 得到该用户所对角色的菜单
                Test_BUL.sys_Common common = new Test_BUL.sys_Common();
                DataSet SysAdminDS;
                if (Tools.CacheUtil.IsExist(Test_BUL.sysParam.CachePageIdDs))
                    SysAdminDS = (DataSet)Tools.CacheUtil.GetCache(Test_BUL.sysParam.CachePageIdDs);
                else
                {
                    SysAdminDS = common.GetList(" select pageId from tb_sys_role where id=" + adminGetRoleId);
                    Tools.CacheUtil.InsertCach(Test_BUL.sysParam.CachePageIdDs, (object)SysAdminDS, Test_BUL.sysParam.CachePageIdDsTimes, 2);
                }

                FileItems = SysAdminDS.Tables[0].Rows[0]["pageId"].ToString();//1,2,3,4,5,6,7,8,9...
                #endregion
                #region URL访问判断
                string urlHead = "/testweb/admin/";
                string currentUrl = HttpContext.Current.Request.FilePath.ToLower().Replace(urlHead, "");

                if (currentUrl.IndexOf("admin.aspx") == -1 && currentUrl.IndexOf("desktop.aspx") == -1)
                {
                    DataSet urlDS = common.GetList(" select id , filesUrl from tb_sys_sysfiles where lower(filesUrl)='" + currentUrl + "' ");
                    if (Tools.Validator.CheckDataSet(urlDS, 0))
                    {
                        string _parmUrlId = urlDS.Tables[0].Rows[0]["id"].ToString();
                        string[] tempArr = FileItems.Split(',');
                        bool tag = false;
                        for (int i = 0; i < tempArr.Length; i++)
                            if (tempArr[i] == _parmUrlId) { tag = true; break; }
                        if (!tag)
                            FinalMessage("您无权访问该页", "", 1);

                        //if (!RequestQueryValidate()) //没有处理完善，带搜索框查询跳转、多条件分页查询跳转的2种情况的还没有处理
                        //    FinalMessage("对不起，页面参数校验错误！", "", 1);
                    }
                    else
                        FinalMessage("您访问的页面不存在", "", 1);
                }
                #endregion
            }
            base.OnInit(e);
        }

        /// <summary>
        /// 校验参数有效性
        /// <remarks>有参数就校验，没有就不处理</remarks>
        /// </summary>
        private bool RequestQueryValidate()
        {
            //判断仅仅是分页的情况
            int queCout = Request.QueryString.Count;
            if (queCout == 1 && Request.QueryString.Keys[0].ToString() == "p")
                if (q("p") != null)
                    return true;

            //除分页外还有其它参数
            string allParamter = GetRequestParametersValue().ToLower();//已经过滤掉md参数
            if (allParamter != "")
            {
                string tempstr = string.Empty;
                tempstr = Tools.Encrypt.MD5Encrypt(Tools.Encrypt.MD5Encrypt(allParamter));
                tempstr = tempstr.Substring(0, 8) + Tools.StringHelp.ReverseStr(tempstr).Substring(0, 8);
                tempstr = Tools.Encrypt.MD5Encrypt(tempstr).Substring(0, 16).ToUpper();//取16位转大写
                if (q("md") == tempstr) return true;
                else return false;
            }
            return true;
        }

        /// <summary>
        /// 绑定行政级别
        /// </summary>
        public void BindLeaveType(DropDownList ddlPowerLeave)
        {
            List<ListItem> albumType = new List<ListItem>();
            albumType.Add(new ListItem("——请选择——", "-1"));
            foreach (LevelPower type in Enum.GetValues(typeof(LevelPower)))
            {
                //albumType.Add(new ListItem(Tools.EnumUtils.GetName(type) + "(" + type.ToString() + ")", ((int)type).ToString()));
                albumType.Add(new ListItem(Tools.EnumUtils.GetName(type) + "(" + type.ToString() + ")", type.ToString()));
            }
            ddlPowerLeave.DataSource = albumType;
            ddlPowerLeave.DataTextField = "text";
            ddlPowerLeave.DataValueField = "value";
            ddlPowerLeave.DataBind();
        }
    }
}