using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_member_Add_Address : BasePage.PageUI
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindProvince();
        }
    }

    private void BindProvince()
    {
        Test_BUL.sys_Common common = new Test_BUL.sys_Common();
        string strb = " select CapitalName,DomainID from tb_sys_capital ";
        DataSet ds = common.GetList(strb.ToString());
        Tools.WebControl.BindList(this.ddlProcince, ds.Tables[0], "CapitalName", "DomainID");
        this.ddlProcince.Items.Insert(0, new ListItem("——请选中——", "-1"));
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        string _receiveName = this.txtReceiveName.Value.Trim();
        string _address = this.txtAddress.Value.Trim();
        string _province = this.hidProvince.Value;
        string _city = this.hidCity.Value;
        string _phone = this.txtPhone.Text;
        string _cellphone = this.txtTelephone.Text.Trim();
        string _zipCode = this.txtZipCode.Text.Trim();

        if (string.IsNullOrEmpty(_receiveName) || string.IsNullOrEmpty(_cellphone) || string.IsNullOrEmpty(_zipCode))
            FinalMessage("网络传输异常，请重试！", "", 1);

        Test_Model.sys_distribution modelDis = new Test_Model.sys_distribution();
        modelDis.receiveName = _receiveName;
        modelDis.postAddress = _address;
        modelDis.province = _province;
        modelDis.city = _city;
        modelDis.phone = _phone;
        modelDis.telephone = _cellphone;
        modelDis.zipCode = _zipCode;
        modelDis.userid = 1;//暂时测试，测试时修改回去
        modelDis.addtime = DateTime.Now;


        Test_BUL.sys_distribution bulDis = new Test_BUL.sys_distribution();
        if (bulDis.Add(modelDis) > 0)
            Response.Redirect("Manage_Address.aspx");
        else
            FinalMessage("保存失败！", "", 1);
    }
}
