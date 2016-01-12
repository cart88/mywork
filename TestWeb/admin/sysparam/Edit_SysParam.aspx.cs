using System;
using System.Data;

public partial class admin_sysparam_Edit_SysParam : BasePage.PageUI
{
    /// <summary>
    /// 返回的页面索引
    /// </summary>
    protected string p;
    protected Test_Model.sys_paramcenter modelparma = new Test_Model.sys_paramcenter();
    protected Test_BUL.sys_paramcenter bulparam = new Test_BUL.sys_paramcenter();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetData();
            p = backpage;
        }
    }

    /// <summary>
    /// 获取数据
    /// </summary>
    protected void GetData()
    {
        if (!Tools.Validator.IsNumber(ID))
            FinalMessage("url参数解析错误", "Manage_SysParam.aspx", 1);
        if (Tools.RequestCheck.CheckKeyWord(ID))
            FinalMessage("url参数含有非法关键词", "Manage_SysParam.aspx", 1);

        modelparma = bulparam.GetModel(Tools.StringHelp.GetInt(ID));
        if (modelparma == null)
            FinalMessage("您查看的数据不存在", "Manage_SysParam.aspx", 1);

        this.txtName.Value = modelparma.name.Trim();
        this.txtValue.Value = modelparma.value.ToString().Trim();
        this.txtTypeTag.Value = modelparma.typeTag.Trim();
    }

    #region 获取url参数
    /// <summary>
    /// 返回的页面索引
    /// </summary>
    private string backpage
    {
        get
        {
            return string.IsNullOrEmpty(q("pageIndex")) ? "1" : q("pageIndex");
        }
    }
    /// <summary>
    /// 传值id
    /// </summary>
    private string ID
    {
        get
        {
            return string.IsNullOrEmpty(q("id")) ? "1" : q("id");
        }
    }
    #endregion

    /// <summary>
    /// 更新数据
    /// </summary>
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
            FinalMessage("参数值应为正整数", "Add_SysParam.aspx", 1);

        Test_BUL.sys_Common common = new Test_BUL.sys_Common();
        DataSet temds = common.GetList(" select id, name from tb_sys_paramcenter where name='" + (this.txtName.Value) + "' and typeTag='" + (this.txtTypeTag.Value) + "' ");
        if (Tools.Validator.CheckDataSet(temds, 0))
        {
            if (temds.Tables[0].Rows.Count > 1)
                FinalMessage("此参数名已经存在", "Add_SysParam.aspx", 1);
            else if (temds.Tables[0].Rows[0]["id"].ToString() != ID)
                FinalMessage("此参数名已经存在", "Add_SysParam.aspx", 1);
        }

        modelparma.id = Tools.StringHelp.GetInt(ID);
        modelparma.name = _name;
        modelparma.value = Tools.StringHelp.GetInt(_value);
        modelparma.typeTag = Tools.StringHelp.CutStirngNormal(_typetag, 10, 0);
        modelparma.addUserId = Tools.StringHelp.GetInt(adminGetId);
        modelparma.addUserName = adminGetCount;
        modelparma.addTime = DateTime.Now;

        if (bulparam.Update(modelparma))
            Response.Redirect("Manage_SysParam.aspx?p=" + p);
        else
            FinalMessage("保存失败", "Add_SysParam.aspx", 1);
    }
}
