using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_member_Add_Member : BasePage.PageUI
{
    private Test_BUL.sys_Common common = new Test_BUL.sys_Common();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindProvince();
        }
    }

    /// <summary>
    /// 绑定城市
    /// </summary>
    private void BindProvince()
    {
        DataSet ds;
        if (Tools.CacheUtil.IsExist(Test_BUL.sysParam.CacheCapital_info))
            ds = (DataSet)Tools.CacheUtil.GetCache(Test_BUL.sysParam.CacheCapital_info);
        else
        {
            string strb = " select CapitalName,DomainID from tb_sys_capital ";
            ds = common.GetList(strb.ToString());
            Tools.CacheUtil.InsertCach(Test_BUL.sysParam.CacheCapital_info, (object)ds, 60 * 60, 2);
        }
        Tools.WebControl.BindList(this.ddlProcince, ds.Tables[0], "CapitalName", "DomainID");
        this.ddlProcince.Items.Insert(0, new ListItem("——请选中——", "-1"));
    }

    /// <summary>
    /// 新增会员
    /// </summary>
    protected void btnSend_Click(object sender, EventArgs e)
    {
        string _userName = this.txtUserName.Value.Trim();
        DataSet temds = common.GetList(" select [userName] FROM tb_sys_userinfo where [userName]='" + _userName + "' ");
        if (Tools.Validator.CheckDataSet(temds, 0))
            FinalMessage("此账号已经存在，请更换！", "Add_Member.aspx", 1);

        Test_Model.sys_userinfo modelUser = new Test_Model.sys_userinfo();
        modelUser.userName = _userName;
        modelUser.password = EncryptAdmin(this.txtPassword.Value.Trim());
        modelUser.trueName = this.txtTrueName.Value.Trim();
        modelUser.currentScore = 30;//暂用，待改
        modelUser.totalScore = 30;//暂用，待改
        modelUser.sex = Tools.StringHelp.GetInt(this.rbSex.SelectedValue) == 1 ? true : false;
        modelUser.province = this.hidProvince.Value;
        modelUser.city = this.hidCity.Value;
        modelUser.isBusiness = Tools.StringHelp.GetInt(this.rbIsBusiness.SelectedValue) == 1 ? true : false;
        modelUser.registNumber = this.txtRegistNumber.Value.Trim();
        modelUser.department = this.txtDepartment.Value.Trim();
        modelUser.position = this.txtPosition.Value.Trim();
        modelUser.phone = this.txtPhone.Value.Trim();
        modelUser.address = Tools.StringHelp.CutStirngNormal(this.txtAddress.Value.Trim(), 100, 1);
        modelUser.addTime = DateTime.Now;

        Test_BUL.sys_userinfo bulUser = new Test_BUL.sys_userinfo();
        if (bulUser.Add(modelUser) > 0)
            Response.Redirect("Manage_Member.aspx");
        else
            FinalMessage("保存失败！", "Add_Member.aspx", 1);
    }

}
