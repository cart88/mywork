using System;
using System.Data;
using Tools;

/// <summary>
/// 没做单点处理了，凑活看吧
/// </summary>
public partial class ajax_adminlogin : BasePage.FrontAjax
{
    public Test_BUL.sys_Common common = new Test_BUL.sys_Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (CheckAdminLogin())
            return;//已经登录过了

        string validate = StringHelp.FilterSymbolStr(q("validate"));
        if (string.IsNullOrEmpty(validate))
            return;//参数丢失;
        if (string.Compare(validate, Session["LVNum"].ToString(), true) == 0)//不区分大小写比较验证码
        {
            string count = q("paramName");
            string pwd = q("paramPwd");

            if (string.IsNullOrEmpty(count) || string.IsNullOrEmpty(pwd))
                Response.Write("1|" + Test_BUL.sysParam.ErrorPageTip("1"));
            if (RequestCheck.CheckKeyWord(count) || RequestCheck.CheckKeyWord(pwd))
                Response.Write("3|" + Test_BUL.sysParam.ErrorPageTip("3"));
            else
            {
                string strsql = common.GetCustomDSsql("tb_sys_admin", "id,count,password,loginIP,loginTime,telephone,email,sex,birthday,createTime,roleid,adminTag,AccountState,PowerLeave ", " count='" + count + "' ");
                DataSet ds = common.GetList(strsql);
                if (Tools.Validator.CheckDataSet(ds, 0))
                {
                    if (ds.Tables[0].Rows[0]["password"].ToString() == EncryptAdmin(pwd))
                    {
                        string state = ds.Tables[0].Rows[0]["AccountState"].ToString();
                        //账号状态：10正常，20冻结，30禁用
                        if (state == "20")
                            Response.Write("20|" + Test_BUL.sysParam.ErrorPageTip("11"));
                        else if (state == "30")
                            Response.Write("30|" + Test_BUL.sysParam.ErrorPageTip("12"));
                        else
                        {
                            string tempRoleId = ds.Tables[0].Rows[0]["roleid"].ToString();
                            string tempAdminTag = ds.Tables[0].Rows[0]["adminTag"].ToString();

                            if (string.IsNullOrEmpty(tempRoleId) || state != "10" || string.IsNullOrEmpty(tempAdminTag))
                                Response.Write("14|" + Test_BUL.sysParam.ErrorPageTip("14"));
                            else
                            {
                                SetUserCookie(ds.Tables[0]);//用户信息写入Cookies
                                Test_BUL.sys_admin blladmin = new Test_BUL.sys_admin(); //更新登录IP和登录时间
                                blladmin.UpdateLogin(count, Tools.IPHelp.ClientIP, DateTime.Now);
                                Response.Write("10|" + Test_BUL.sysParam.ErrorPageTip("10"));
                            }
                        }
                    }
                    else
                        Response.Write("9|" + Test_BUL.sysParam.ErrorPageTip("9"));
                }
                else
                    Response.Write("8|" + Test_BUL.sysParam.ErrorPageTip("8"));
            }
        }
        else
            Response.Write("15|" + Test_BUL.sysParam.ErrorPageTip("15"));
    }

    /// <summary>
    /// 写入cookies
    /// </summary>
    /// <param name="ds"></param>
    private void SetUserCookie(DataTable dt)
    {
        int _tag = -24; //负数只保留于内存中
        string roleId = dt.Rows[0]["roleid"].ToString();

        #region 将用户能访问的文件id写入缓存
        DataSet files = common.GetList(" select roleName, pageId from tb_sys_role where id=" + roleId);
        Tools.CacheUtil.InsertCach(Test_BUL.sysParam.CachePageIdDs, (object)files, Test_BUL.sysParam.CachePageIdDsTimes, 2);
        #endregion

        //应该用mode存储的，老代码没改，这里先就这么凑合着看吧
        CookiesHelp.SetCookie(Test_BUL.sysParam.adminId, dt.Rows[0]["id"].ToString(), _tag, Test_BUL.sysParam.CookiesDomain);      //管理员id
        CookiesHelp.SetCookie(Test_BUL.sysParam.adminCount, dt.Rows[0]["count"].ToString(), _tag, Test_BUL.sysParam.CookiesDomain);     //管理员账户
        CookiesHelp.SetCookie(Test_BUL.sysParam.adminRoleId, roleId, _tag, Test_BUL.sysParam.CookiesDomain);     //管理员角色id
        CookiesHelp.SetCookie(Test_BUL.sysParam.adminRoleName, files.Tables[0].Rows[0]["roleName"].ToString(), _tag, Test_BUL.sysParam.CookiesDomain);     //管理员角色名称
        CookiesHelp.SetCookie(Test_BUL.sysParam.adminAdminTag, dt.Rows[0]["adminTag"].ToString(), _tag, Test_BUL.sysParam.CookiesDomain);  //管理员级别标记
        CookiesHelp.SetCookie(Test_BUL.sysParam.adminConState, dt.Rows[0]["AccountState"].ToString(), _tag, Test_BUL.sysParam.CookiesDomain);   //管理员账户状态
        CookiesHelp.SetCookie(Test_BUL.sysParam.adminPowerLeave, dt.Rows[0]["PowerLeave"].ToString(), _tag, Test_BUL.sysParam.CookiesDomain);   //管理员行政级别
    }
}
