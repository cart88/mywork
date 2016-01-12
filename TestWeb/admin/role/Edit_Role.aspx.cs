using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_role_Edit_Role : BasePage.PageUI
{
    public Test_Model.sys_role model = new Test_Model.sys_role();
    public Test_BUL.sys_role role = new Test_BUL.sys_role();
    public Test_BUL.sys_Common common = new Test_BUL.sys_Common();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (string.IsNullOrEmpty(q("id")))
                FinalMessage("网络错误！", "Manage_Role.aspx", 1);
            if (!Tools.Validator.IsPositiveInt(q("id")) || Tools.RequestCheck.CheckKeyWord(q("id")))
                FinalMessage("UTL解析错误，请勿在Url中添加非法关键词！", "Edit_Role.aspx", 1);

            DataBind_CheckBoxList();
            DataBind_Role();
        }
    }

    /// <summary>
    /// 获得所有大类菜单
    /// </summary>
    private void DataBind_CheckBoxList()
    {
        DataTable dt = common.GetList("select id,menuName from tb_sys_sysmenu").Tables[0];
        rpt_RoleList.DataSource = dt.DefaultView;
        rpt_RoleList.DataBind();
    }

    /// <summary>
    /// 根据大类菜单获取小类菜单
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void rpt_RoleList_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        DataTable dt;
        string parentId = ((DataRowView)e.Item.DataItem).Row["id"].ToString();
        CheckBoxList childRen = (CheckBoxList)e.Item.FindControl("cbList");
        if (childRen != null)
        {
            dt = common.GetList("select id,fielsName from tb_sys_sysfiles where classId = " + Convert.ToInt32(parentId)).Tables[0];
            childRen.DataSource = dt.DefaultView;
            childRen.DataTextField = "fielsName";
            childRen.DataValueField = "id";
            childRen.DataBind();
        }
    }

    /// <summary>
    /// 获取选中的小类Id
    /// </summary>
    /// <returns></returns>
    private string getCheckBoxListValue()
    {
        //取得CheckBoxList选中项的值
        string returnValue = "";
        foreach (RepeaterItem DataItem in rpt_RoleList.Items)
        {
            foreach (ListItem item in ((CheckBoxList)DataItem.FindControl("cbList")).Items)
            {
                if (item.Selected == true)
                {
                    if (returnValue == "")
                        returnValue = item.Value;
                    else
                        returnValue += "," + item.Value;
                }
            }
        }

        return returnValue;
    }

    /// <summary>
    /// 初始该角色的小类菜单
    /// </summary>
    private void DataBind_Role()
    {
        if (Request.QueryString["Id"] == null || !Tools.Validator.IsPositiveInt(Request.QueryString["Id"].ToString()))
            return;
        model = role.GetModel(Tools.StringHelp.GetInt(Request.QueryString["Id"]));
        if (model == null)
            return;

        this.txt_RoleName.Text = model.roleName.ToString();
        if (!string.IsNullOrEmpty(model.pageId))
        {
            //初始化CheckBoxList选中项
            foreach (RepeaterItem DataItem in rpt_RoleList.Items)
            {
                foreach (ListItem item in ((CheckBoxList)DataItem.FindControl("cbList")).Items)
                {
                    if (("," + model.pageId.ToString() + ",").IndexOf("," + item.Value + ",") != -1)
                        item.Selected = true;
                }
            }
        }
    }

    /// <summary>
    /// 修改角色信息
    /// </summary>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        model.roleName = txt_RoleName.Text;
        model.pageId = getCheckBoxListValue();
        model.addTime = DateTime.Now;
        model.addUser = adminGetCount;
        model.id = Tools.StringHelp.GetInt(q("id"));

        DataSet tempds = common.GetList("select roleName from tb_sys_role where roleName='" + txt_RoleName.Text.Replace("'", "") + "' ");
        if (Tools.Validator.CheckDataSet(tempds, 0))
        {
            if (tempds.Tables[0].Rows[0]["roleName"].ToString() != txt_RoleName.Text.Trim())
                lblMsg.InnerHtml = "<script type='text/javascript'>alert('该角色名称已经存在!');</script>";
            else
            {
                if (role.Update(model))
                    lblMsg.InnerHtml = "<script type='text/javascript'>alert('修改成功!');window.location='Manage_Role.aspx'</script>";
                else
                    FinalMessage("修改角色失败！", "Edit_Role.aspx", 1);
            }
        }
        else if (role.Update(model))
            lblMsg.InnerHtml = "<script type='text/javascript'>alert('修改成功!');window.location='Manage_Role.aspx'</script>";
    }
}
