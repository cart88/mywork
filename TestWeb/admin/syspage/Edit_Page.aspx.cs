using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_syspage_Edit_Page : BasePage.PageUI
{
    private readonly Test_BUL.sys_sysfiles bg_bllSM = new Test_BUL.sys_sysfiles();
    public Test_BUL.sys_Common common = new Test_BUL.sys_Common();
    public Test_Model.sys_sysfiles ModFilses = new Test_Model.sys_sysfiles();

    public string pageIndex;//返回的页码

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (string.IsNullOrEmpty(temp))
                FinalMessage("网络错误！", "Manage_Page.aspx", 1);

            BindDDL();
            BindData();
        }
    }

    /// <summary>
    /// 获取request对象
    /// </summary>
    public string temp
    {
        get
        {
            return q("FilseId");
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
    /// 绑定页面数据
    /// </summary>
    private void BindData()
    {
        if (string.IsNullOrEmpty(temp) || !Tools.Validator.IsPositiveInt(temp))
            FinalMessage("UTL解析错误，请勿在Url中添加非法关键词！", "Manage_Page.aspx", 1);

        ModFilses = bg_bllSM.GetModel(Tools.StringHelp.GetInt(temp));
        if (ModFilses != null)
        {
            this.txtName.Value = ModFilses.fielsName.Trim();
            this.txtPath.Value = ModFilses.filesUrl.Trim();
            this.txtDescribe.Value = ModFilses.describe.Trim();
            this.txtIntOrder.Value = ModFilses.filesOrder.ToString().Trim();
            Tools.WebControl.SeRadioButtonList(this.rdShowLeft, ModFilses.showLeft == true ? "10" : "20");
            Tools.WebControl.SetSelectedList(this.ddlParentMD, ModFilses.classId.ToString());
        }
    }

    /// <summary>
    /// 修改数据
    /// </summary>
    protected void btnCon_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(temp) || !Tools.Validator.IsPositiveInt(temp))
            FinalMessage("UTL解析错误，请勿在Url中添加非法关键词！", "Manage_Page.aspx", 1);

        ModFilses.fielsName = this.txtName.Value.Trim();
        ModFilses.filesUrl = this.txtPath.Value.Trim();
        ModFilses.describe = Tools.StringHelp.CutStirngNormal(this.txtDescribe.Value.Trim(), 20, 0);
        ModFilses.classId = Tools.StringHelp.GetInt(this.ddlParentMD.SelectedValue);
        ModFilses.showLeft = this.rdShowLeft.SelectedValue == "10" ? true : false;
        ModFilses.filesOrder = Tools.StringHelp.GetInt(this.txtIntOrder.Value.Trim());
        ModFilses.addUser = adminGetCount;
        ModFilses.addTime = DateTime.Now;
        ModFilses.id = Tools.StringHelp.GetInt(temp);

        DataSet ds = common.GetList(" select id from tb_sys_sysfiles where fielsName='" + this.txtName.Value.Trim() + "' ");
        if (!Tools.Validator.CheckDataSet(ds, 0))
        {
            bg_bllSM.Update(ModFilses);
            Response.Redirect("Manage_Page.aspx");
        }
        else
        {
            if (ds.Tables[0].Rows[0]["id"].ToString() == temp)
            {
                bg_bllSM.Update(ModFilses);
                if (!string.IsNullOrEmpty(q("pageIndex")) && Tools.Validator.IsPositiveInt(q("pageIndex")))
                    pageIndex = q("pageIndex");
                else
                    pageIndex = "1";
                Response.Redirect("Manage_Page.aspx?p=" + Convert.ToInt32(pageIndex));
            }
            else
                FinalMessage("该城菜单模块经存在", "", 1);
        }
    }
}
