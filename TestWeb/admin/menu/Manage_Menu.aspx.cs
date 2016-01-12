using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_menu_Manage_Menu : BasePage.PageUI
{
    public string PageBarHTML;
    public Test_BUL.sys_Common common = new Test_BUL.sys_Common();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.rpt_Menu.DataSource = GetInfoDS();
            this.rpt_Menu.DataBind();
        }
    }

    /// <summary>
    /// 获取数据
    /// </summary>
    /// <returns></returns>
    public DataSet GetInfoDS()
    {
        Test_BUL.sys_sysmenu bulMenu = new Test_BUL.sys_sysmenu();
        DataSet ds = bulMenu.GetAllList();
        if (Tools.Validator.CheckDataSet(ds, 0))
        {
            int count = ds.Tables[0].Rows.Count;
            ds.Tables[0].Columns.Add("NoLi");
            for (int i = 0; i < count; i++)
                ds.Tables[0].Rows[i]["NoLi"] = (i + 1).ToString();
            return ds;
        }
        else
            return null;
    }

    /// <summary>
    /// 删除
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void rpt_Menu_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            HiddenField hfGetId = (HiddenField)e.Item.FindControl("hfGetId");
            int id = Tools.StringHelp.GetInt(hfGetId.Value);
            try
            {
                if (common.Delete("tb_sys_sysmenu", id))
                {
                    this.rpt_Menu.DataSource = GetInfoDS();
                    this.rpt_Menu.DataBind();
                    //刷新左边的菜单
                    Page.ClientScript.RegisterStartupScript(this.Page.GetType(), Guid.NewGuid().ToString(), "top.FreshMenu();", true);
                }
            }
            catch (Exception ex)
            {
                FinalMessage("删除失败" + ex.Message, "Manage_Menu.aspx", 1);
            }
        }
    }
}
