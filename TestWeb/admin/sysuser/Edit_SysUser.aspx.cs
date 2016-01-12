using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using CCControl;

public partial class admin_sysuser_Edit_SysUser : BasePage.PageUI
{
    private Test_BUL.sys_Common common = new Test_BUL.sys_Common();
    private Test_Model.sys_admin modeladmin = new Test_Model.sys_admin();
    private Test_BUL.sys_admin bulAdmin = new Test_BUL.sys_admin();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (string.IsNullOrEmpty(q("id")))
                FinalMessage("网络错误！", "Manage_SysUser.aspx", 1);

            BindLeaveType(ddlPowerLeave);
            BindRole();
            BindData();
        }
    }

    /// <summary>
    /// 绑定角色类型
    /// </summary>
    private void BindRole()
    {
        System.Text.StringBuilder strb = new System.Text.StringBuilder(" select id,roleName FROM tb_sys_role ");
        if (adminGetadminTag != Test_BUL.sysParam.AdministratorTagH)
            strb.Append(" where roleName!='超级管理员' ");

        DataSet ds = common.GetList(strb.ToString());
        Tools.WebControl.BindList(this.ddlRole, ds.Tables[0], "roleName", "id");
        this.ddlRole.Items.Insert(0, new ListItem("——请选中——", "-1"));
    }
    /// <summary>
    /// 绑定页面数据
    /// </summary>
    private void BindData()
    {
        if (!Tools.Validator.IsPositiveInt(q("id")) || Tools.RequestCheck.CheckKeyWord(q("id")))
            FinalMessage("UTL解析错误，请勿在Url中添加非法关键词！", "Manage_Page.aspx", 1);

        modeladmin = bulAdmin.GetModel(int.Parse(q("id")));
        if (modeladmin != null)
        {
            this.chkIsAdmin.Checked = (modeladmin.adminTag == int.Parse(Test_BUL.sysParam.AdministratorTagH)) ? true : false;//超管选中标记
            this.txtcount.Value = modeladmin.count;
            Tools.WebControl.SetSelectedList(this.ddlRole, modeladmin.roleid.ToString());
            Tools.WebControl.SetSelectedList(this.ddlPowerLeave, modeladmin.PowerLeave.ToString());
            this.txtTelephone.Value = modeladmin.telephone;
            Tools.WebControl.SeRadioButtonList(this.rbSex, (modeladmin.sex == true ? "1" : "0"));
            this.txtBirthday.Value = Tools.StringHelp.GetDateTime(modeladmin.birthday).ToString("yyyy-MM-dd");
            this.txtEmail.Value = modeladmin.email;
        }
    }

    /// <summary>
    /// 保存操作
    /// </summary>
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string tempCount = this.txtcount.Value.Trim();
        DataSet temds = common.GetList(" select id, [count] FROM tb_sys_admin where [count]='" + tempCount + "' ");
        if (Tools.Validator.CheckDataSet(temds, 0))
            if (temds.Tables[0].Rows[0]["id"].ToString() != q("id"))
                FinalMessage("此账号已经存在，请更换！", "Edit_SysUser.aspx", 1);

        modeladmin.count = tempCount;
        modeladmin.telephone = this.txtTelephone.Value.Trim();
        modeladmin.email = this.txtEmail.Value.Trim();
        modeladmin.sex = Tools.StringHelp.GetInt(this.rbSex.SelectedValue) == 1 ? true : false;
        modeladmin.birthday = Tools.StringHelp.GetDateTime(this.txtBirthday.Value.Trim());
        modeladmin.createTime = DateTime.Now;
        modeladmin.roleid = Tools.StringHelp.GetInt(this.ddlRole.SelectedValue);
        modeladmin.AccountState = 10;
        modeladmin.id = Tools.StringHelp.GetInt(q("id"));
        modeladmin.PowerLeave = this.ddlPowerLeave.SelectedValue;

        //判断超管标记
        if (adminGetadminTag == Test_BUL.sysParam.AdministratorTagH)
        {
            if (this.Page.FindControl("chkIsAdmin") != null && this.chkIsAdmin.Checked == true)
                modeladmin.adminTag = int.Parse(Test_BUL.sysParam.AdministratorTagH);//符合条件
            else
                modeladmin.adminTag = int.Parse(Test_BUL.sysParam.AdministratorTagN);//普通的系统用户
        }
        else
            modeladmin.adminTag = int.Parse(Test_BUL.sysParam.AdministratorTagN);//当前用户不具有添加超管的权限

        if (bulAdmin.Update(modeladmin))
            Response.Redirect("Manage_SysUser.aspx");
        else
            FinalMessage("新增用户失败！", "Edit_SysUser.aspx", 1);
    }
}
