using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_syspage_Add_Page : BasePage.PageUI
{
    private readonly Test_BUL.sys_sysfiles bg_bllSM = new Test_BUL.sys_sysfiles();
    public Test_BUL.sys_Common common = new Test_BUL.sys_Common();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindDDL();
        }
    }

    /// <summary>
    /// 绑定父级模块的下拉列表
    /// </summary>
    private void BindDDL()
    {
        DataSet ds = common.GetList(" select id, menuName from tb_sys_sysmenu ");
        Tools.WebControl.BindList(this.ddlParentMD, ds.Tables[0], "menuName", "Id");
        this.ddlParentMD.Items.Insert(0, new ListItem("——请选中——", "-1"));
    }

    /// <summary>
    /// 保存
    /// </summary>
    protected void btnCon_Click(object sender, EventArgs e)
    {
        Test_Model.sys_sysfiles model = new Test_Model.sys_sysfiles();
        model.classId = Tools.StringHelp.GetInt(this.ddlParentMD.SelectedValue);
        string tempStr = this.txtName.Value.Trim().Replace("'", "");
        //string tempStr = Tools.StringHelp.FilterSymbolStr(this.txtName.Value.Trim());
        model.fielsName = tempStr;
        model.filesUrl = this.txtPath.Value.Trim();
        model.describe = Tools.StringHelp.CutStirngNormal(this.txtDescribe.Value.Trim(), 20, 0);//数据库中该字段长度是20位
        model.showLeft = Tools.StringHelp.GetInt(this.rdShowLeft.SelectedValue) == 10 ? true : false;
        model.filesOrder = Tools.StringHelp.GetInt(this.txtIntOrder.Value.Trim());
        model.addTime = DateTime.Now;
        model.addUser = adminGetCount;
        model.addUserId = int.Parse(adminGetId);

        DataSet ds = common.GetList(" select fielsName from tb_sys_sysfiles where fielsName='" + Tools.StringHelp.FilterSymbolStr(tempStr) + "' ");
        if (!Tools.Validator.CheckDataSet(ds, 0))
        {
            if (bg_bllSM.Add(model) > 0)
                Response.Redirect("Manage_Page.aspx");
            else
                FinalMessage("保存失败", "", 1);
        }
    }
}
