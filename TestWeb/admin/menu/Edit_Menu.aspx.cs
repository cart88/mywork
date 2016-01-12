using System;
using System.Data;

public partial class admin_menu_Edit_Menu : BasePage.PageUI
{
    public readonly Test_BUL.sys_sysmenu sysmenu = new Test_BUL.sys_sysmenu();
    public Test_Model.sys_sysmenu sysmenuModel = new Test_Model.sys_sysmenu();
    public Test_BUL.sys_Common common = new Test_BUL.sys_Common();
    public string NowImgPath = string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (string.IsNullOrEmpty(q("menuId")))
                FinalMessage("网络错误！", "Manage_Menu.aspx", 1);

            sysmenuModel = sysmenu.GetModel(Tools.StringHelp.GetInt(q("menuId")));
            this.txtMenuName.Value = sysmenuModel.menuName;
            this.txtMenuImg.Value = sysmenuModel.imgUrl;
            NowImgPath = sysmenuModel.imgUrl;
            this.txtIntOrder.Value = sysmenuModel.menuOrder.ToString();
        }
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        if (!Tools.Validator.IsPositiveInt(q("menuId")) || Tools.RequestCheck.CheckKeyWord(q("menuId")))
            FinalMessage("UTL解析错误，请勿在Url中添加非法关键词！", "Manage_Menu.aspx", 1);

        sysmenuModel.menuName = this.txtMenuName.Value.Trim();
        string imgUrl = this.txtMenuImg.Value.Trim();
        sysmenuModel.imgUrl = imgUrl != "" ? imgUrl : "../Images/Ico/null.gif";
        sysmenuModel.menuOrder = Tools.StringHelp.GetInt(this.txtIntOrder.Value.Trim());
        sysmenuModel.addName = adminGetCount;
        sysmenuModel.addTime = DateTime.Now;
        sysmenuModel.id = int.Parse(q("menuId"));

        DataSet ds = common.GetList(" select id, menuName from tb_sys_sysmenu where menuName='" + this.txtMenuName.Value.Trim() + "' ");
        if (!Tools.Validator.CheckDataSet(ds, 0))
        {
            if (sysmenu.Update(sysmenuModel))
                Response.Redirect("Manage_Menu.aspx");
            else
                FinalMessage("保存失败！", "Manage_Menu.aspx", 1);
        }
        else
        {
            if (ds.Tables[0].Rows[0]["id"].ToString() == q("menuId"))
            {
                if (sysmenu.Update(sysmenuModel))
                    Response.Redirect("Manage_Menu.aspx");
                else
                    FinalMessage("保存失败！", "Manage_Menu.aspx", 1);
            }
            else
                FinalMessage("此菜单模块已经存在！", "Manage_Menu.aspx", 1);
        }
    }
}
