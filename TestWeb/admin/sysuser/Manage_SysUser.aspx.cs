using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_sysuser_Manage_SysUser : BasePage.PageUI
{
    public Test_BUL.sys_admin bulAdmin = new Test_BUL.sys_admin();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataBind_role();
        }
    }

    /// <summary>
    /// 数据绑定
    /// </summary>
    private void DataBind_role()
    {
        DataSet ds = bulAdmin.GetList();
        if (Tools.Validator.CheckDataSet(ds, 0))
        {
            ds.Tables[0].Columns.Add("NoLi");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                ds.Tables[0].Rows[i]["NoLi"] = (i + 1).ToString();

            this.rpt_Mod.DataSource = ds.Tables[0].DefaultView;
            this.rpt_Mod.DataBind();
        }
    }

    public bool CehckState(object statType)
    {
        return Convert.ToInt32(statType) == 20 ? true : false; //冻结、启用
    }

    /// <summary>
    /// 按钮操作
    /// </summary>
    protected void rpt_Mod_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        Test_BUL.sys_Common common = new Test_BUL.sys_Common();

        HiddenField hfGetId = (HiddenField)e.Item.FindControl("hfGetId");
        int id = Tools.StringHelp.GetInt(hfGetId.Value);
        if (e.CommandName == "freeze")
        {
            try
            {
                if (common.ExecuteSql(" update tb_sys_admin set AccountState=20 where id=" + id) > 0)
                {
                    DataBind_role();
                    foreach (RepeaterItem rpItem in rpt_Mod.Items)
                    {
                        LinkButton lbbDel = (LinkButton)rpItem.FindControl("lblfreeze");
                        lbbDel.Attributes.Add("onclick", "if(!confirm('确定禁用吗？')) return false;");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('冻结失败:" + ex.Message + "');</script>");
            }
        }
        if (e.CommandName == "open")
        {
            try
            {
                if (common.ExecuteSql(" update tb_sys_admin set AccountState=10 where id=" + id) > 0)
                {
                    DataBind_role();
                    foreach (RepeaterItem rpItem in rpt_Mod.Items)
                    {
                        LinkButton lbbDel = (LinkButton)rpItem.FindControl("lblopen");
                        lbbDel.Attributes.Add("onclick", "if(!confirm('确定启用吗？')) return false;");
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('启用失败:" + ex.Message + "');</script>");
            }
        }
        if (e.CommandName == "del")
        {
            try
            {
                if (common.Delete("tb_sys_admin", id))
                {
                    DataBind_role();
                    foreach (RepeaterItem rpItem in rpt_Mod.Items)
                    {
                        LinkButton lbbDel = (LinkButton)rpItem.FindControl("lblDelete");
                        lbbDel.Attributes.Add("onclick", "if(!confirm('确定删除吗？')) return false;");
                    }
                }
            }
            catch (Exception ex)
            {
                FinalMessage("删除失败" + ex.Message, "Manage_SysUser.aspx", 1);
            }
        }
    }
}
