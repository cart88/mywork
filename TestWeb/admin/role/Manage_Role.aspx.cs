using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class Manage_Role : BasePage.PageUI
{
    public Test_Model.sys_role model = new Test_Model.sys_role();
    public Test_BUL.sys_Common common = new Test_BUL.sys_Common();

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
        DataSet ds = common.GetList(" select id,roleName,addUser,addTime FROM tb_sys_role ");
        if (Tools.Validator.CheckDataSet(ds, 0))
        {
            ds.Tables[0].Columns.Add("number");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                ds.Tables[0].Rows[i]["number"] = (i + 1).ToString();

            this.rpt_roleList.DataSource = ds.Tables[0].DefaultView;
            this.rpt_roleList.DataBind();
        }
    }

    /// <summary>
    /// 删除操作
    /// </summary>
    protected void rpt_roleList_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        HiddenField hfGetId = (HiddenField)e.Item.FindControl("hfGetId");
        int id = Tools.StringHelp.GetInt(hfGetId.Value);
        if (e.CommandName == "del")
        {
            try
            {
                if (common.Delete("tb_sys_role", id))
                {
                    DataBind_role();
                    foreach (RepeaterItem rpItem in rpt_roleList.Items)
                    {
                        LinkButton lbbDel = (LinkButton)rpItem.FindControl("lblDelete");
                        lbbDel.Attributes.Add("onclick", "if(!confirm('确定删除？')) return false;");
                    }
                }
            }
            catch (Exception ex)
            {
                FinalMessage("删除失败" + ex.Message, "Manage_Role.aspx", 1);
            }
        }
    }
}
