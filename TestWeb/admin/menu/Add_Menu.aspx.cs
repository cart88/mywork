using System;
using System.Data;

public partial class admin_menu_Add_Menu : BasePage.PageUI
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        Test_BUL.sys_Common common = new Test_BUL.sys_Common();
        DataSet ds = common.GetList(" select menuName from tb_sys_sysmenu where menuName='" + this.txtMenuName.Value.Trim() + "' ");
        if (!Tools.Validator.CheckDataSet(ds, 0))
        {
            Test_Model.sys_sysmenu sysmenuModel = new Test_Model.sys_sysmenu();
            sysmenuModel.menuName = this.txtMenuName.Value.Trim();
            string imgUrl = this.txtMenuImg.Value.Trim();
            sysmenuModel.imgUrl = imgUrl != "" ? imgUrl : "../Images/Ico/null.gif";
            sysmenuModel.menuOrder = Tools.StringHelp.GetInt(this.txtIntOrder.Value.Trim());
            sysmenuModel.addName = adminGetCount;
            sysmenuModel.addTime = DateTime.Now;

            Test_BUL.sys_sysmenu sysmenu = new Test_BUL.sys_sysmenu();
            if (sysmenu.Add(sysmenuModel) > 0)
                Response.Redirect("Manage_Menu.aspx");
            else
                FinalMessage("新增用户失败！", "Add_Menu.aspx", 1);
        }
    }
}
