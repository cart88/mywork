using System;
using System.Data;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using CCControl;
using System.Reflection;
using System.EnterpriseServices;

public partial class admin_sysuser_Add_SysUser : BasePage.PageUI
{
    private Test_BUL.sys_Common common = new Test_BUL.sys_Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //BindLeaveType(ddlPowerLeave);
            BindRole();
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
    /// 保存操作
    /// </summary>
    protected void btnSend_Click(object sender, EventArgs e)
    {
        Test_BUL.sys_admin bulAdmin = new Test_BUL.sys_admin();
        Test_Model.sys_admin modeladmin = new Test_Model.sys_admin();

        string tempCount = this.txtcount.Value.Trim();
        DataSet temds = common.GetList(" select [count] FROM tb_sys_admin where [count]='" + tempCount + "' ");
        if (Tools.Validator.CheckDataSet(temds, 0))
            FinalMessage("此账号已经存在，请更换！", "Add_SysUser.aspx", 1);

        modeladmin.count = tempCount;
        modeladmin.password = EncryptAdmin(this.txtPwd.Text.Trim());
        modeladmin.loginIP = GetUserIp;
        modeladmin.loginTime = null;
        modeladmin.telephone = this.txtTelephone.Value.Trim();
        modeladmin.email = this.txtEmail.Value.Trim();
        modeladmin.sex = Tools.StringHelp.GetInt(this.rbSex.SelectedValue) == 1 ? true : false;
        modeladmin.birthday = Tools.StringHelp.GetDateTime(this.txtBirthday.Value.Trim());
        modeladmin.createTime = DateTime.Now;
        modeladmin.roleid = Tools.StringHelp.GetInt(this.ddlRole.SelectedValue);
        modeladmin.AccountState = 10;
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

        if (bulAdmin.Add(modeladmin) > 0)
            Response.Redirect("Manage_SysUser.aspx");
        else
            FinalMessage("新增用户失败！", "Add_SysUser.aspx", 1);
    }
}
