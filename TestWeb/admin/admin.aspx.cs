using System;
using System.Data;

public partial class admin_admin : BasePage.PageUI
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.menu_all.InnerHtml = GetMenuHTML();
        }
    }

    /// <summary>
    /// 获取菜单HTML 
    /// </summary>
    /// <returns></returns>
    private string GetMenuHTML()
    {
        if (string.IsNullOrEmpty(FileItems))
            return "";

        Test_BUL.sys_Common common = new Test_BUL.sys_Common();
        DataSet ds = common.GetList(" select id,menuName,imgUrl from tb_sys_sysmenu order by menuOrder asc ");
        if (Tools.Validator.CheckDataSet(ds, 0))
        {
            Test_BUL.sys_sysmenu bulMenu = new Test_BUL.sys_sysmenu();           
            return bulMenu.GetSystemMenu(ds, FileItems);
        }
        return "";
    }
}
