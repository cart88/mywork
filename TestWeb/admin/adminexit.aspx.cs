using System;

/// <summary>
/// 系统管理员退出
/// </summary>
public partial class admin_adminexit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        #region Clear Cookies
        Tools.CookiesHelp.RemoveCookie(Test_BUL.sysParam.adminId); //管理员id
        Tools.CookiesHelp.RemoveCookie(Test_BUL.sysParam.adminCount); //管理员账户
        Tools.CookiesHelp.RemoveCookie(Test_BUL.sysParam.adminRoleId); //管理员角色id
        Tools.CookiesHelp.RemoveCookie(Test_BUL.sysParam.adminRoleName); //管理员角色名称
        Tools.CookiesHelp.RemoveCookie(Test_BUL.sysParam.adminAdminTag); //管理员级别标记
        Tools.CookiesHelp.RemoveCookie(Test_BUL.sysParam.adminConState); //管理员账户状态
        #endregion
        #region Clear Cache
        Tools.CacheUtil.Remove(Test_BUL.sysParam.CachePageIdDs);
        #endregion

        Response.Write(" <script  language='javascript'> window.top.location='login.aspx'</script> ");
    }
}
