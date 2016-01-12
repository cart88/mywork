using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_role_Add_Role : BasePage.PageUI
{
    public Test_BUL.sys_Common common = new Test_BUL.sys_Common();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DataBind_CheckBoxList(); //初始所有菜单
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
    protected void rpt_RoleList_ItemDataBound(object sender, System.Web.UI.WebControls.RepeaterItemEventArgs e)
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
    /// 保存选中的小类Id
    /// </summary>
    protected void btnSave_Click(object sender, EventArgs e)
    {
        DataSet tempds = common.GetList("select roleName from tb_sys_role where roleName='" + txt_RoleName.Text + "' ");
        if (!Tools.Validator.CheckDataSet(tempds, 0))
        {
            Test_BUL.sys_role role = new Test_BUL.sys_role();
            Test_Model.sys_role model = new Test_Model.sys_role();
            model.roleName = txt_RoleName.Text;
            model.pageId = getCheckBoxListValue();
            model.addTime = DateTime.Now;
            model.addUser = adminGetCount;

            if (role.Add(model) > 0)
                lblMsg.InnerHtml = "<script type='text/javascript'>alert('添加成功!');window.location='Manage_Role.aspx'</script>";
        }
        else
            lblMsg.InnerHtml = "<script type='text/javascript'>alert('该角色名称已经存在!');</script>";
    }
}