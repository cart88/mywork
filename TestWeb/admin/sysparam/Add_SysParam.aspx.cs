using System;

public partial class admin_sysparam_Add_SysParam : BasePage.PageUI
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCon_Click(object sender, EventArgs e)
    {
        string _name = this.txtName.Value.Trim();
        string _value = this.txtValue.Value.Trim();
        string _typetag = this.txtTypeTag.Value.Trim();

        if (string.IsNullOrEmpty(_name) || string.IsNullOrEmpty(_typetag))
            FinalMessage("请确认所填信息的完整性", "Add_SysParam.aspx", 1);
        if (Tools.RequestCheck.CheckKeyWord(_name) || Tools.RequestCheck.CheckKeyWord(_typetag))
            FinalMessage("参数名或类型标记含有非法字符", "Add_SysParam.aspx", 1);
        if (!Tools.Validator.IsPositiveInt(_value))
            FinalMessage("参数参数值应为正数", "Add_SysParam.aspx", 1);

        Test_Model.sys_paramcenter modelparma = new Test_Model.sys_paramcenter();
        modelparma.name = _name;
        modelparma.value = Tools.StringHelp.GetInt(_value);
        modelparma.typeTag = Tools.StringHelp.CutStirngNormal(_typetag, 10, 0);
        modelparma.addUserId = Tools.StringHelp.GetInt(adminGetId);
        modelparma.addUserName = adminGetCount;
        modelparma.addTime = DateTime.Now;

        Test_BUL.sys_paramcenter bulparam = new Test_BUL.sys_paramcenter();
        if (bulparam.Add(modelparma) > 0)
            Response.Redirect("Manage_SysParam.aspx");
        else
            FinalMessage("保存失败", "Add_SysParam.aspx", 1);
    }
}
