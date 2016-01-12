/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: Edit_Address
** Remarks: 
** Varsion: 1.0
** Author:  Jon
** Contact: 573741776@qq.com
** Last Edit User: 
** Last Edit Time: 2013-01-10
** Statement: 
**-----------------------------------------------------------------
******************************************************************/


using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_member_Edit_Address : BasePage.PageUI
{
    private Test_BUL.sys_Common common = new Test_BUL.sys_Common();
    private Test_Model.sys_distribution modelDis = new Test_Model.sys_distribution();
    private Test_BUL.sys_distribution bulDis = new Test_BUL.sys_distribution();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (string.IsNullOrEmpty(q("id")))
                FinalMessage("网络错误！", "Manage_Address.aspx", 1);

            BindProvince();
            BindData();
        }
    }

    /// <summary>
    /// 绑定所在省
    /// </summary>
    private void BindProvince()
    {
        string strb = " select CapitalName,DomainID from tb_sys_capital ";
        DataSet ds = common.GetList(strb.ToString());
        Tools.WebControl.BindList(this.ddlProcince, ds.Tables[0], "CapitalName", "DomainID");
        this.ddlProcince.Items.Insert(0, new ListItem("——请选中——", "-1"));
    }

    /// <summary>
    /// 由省份名获取城市
    /// </summary>
    /// <param name="province">省份名</param>
    /// <param name="cityname">城市名称</param>
    private void GetCity(string province, string cityname)
    {
        if (!string.IsNullOrEmpty(province))
        {
            DataSet ds;
            ds = common.GetList("select DomainID from tb_sys_capital WHERE CapitalName='" + province.Trim() + "'");
            if (Tools.Validator.CheckDataSet(ds, 0))
            {
                string _domainid = ds.Tables[0].Rows[0]["DomainID"].ToString();
                ds = common.GetList(" select  CityName from tb_sys_city where DomainID=" + _domainid);
                if (Tools.Validator.CheckDataSet(ds, 0))
                    Tools.WebControl.BindList(this.ddlCity, ds.Tables[0], "CityName", "CityName");

                Tools.WebControl.SetSelectedListByText(this.ddlCity, cityname);
            }
        }
    }

    /// <summary>
    /// 绑定页面数据
    /// </summary>
    private void BindData()
    {
        if (!Tools.Validator.IsPositiveInt(q("id")) || Tools.RequestCheck.CheckKeyWord(q("id")))
            FinalMessage("UTL解析错误，请勿在Url中添加非法关键词！", "Manage_Address.aspx", 1);

        modelDis = bulDis.GetModel(int.Parse(q("id")));
        if (modelDis != null)
        {
            this.txtReceiveName.Value = modelDis.receiveName;
            this.txtTelephone.Text = modelDis.telephone.ToString();
            this.txtPhone.Text = modelDis.phone.ToString();
            string pro = modelDis.province;
            string city = modelDis.city;
            GetCity(pro, city);
            this.hidProvince.Value = pro;
            this.hidCity.Value = city;
            Tools.WebControl.SetSelectedListByText(this.ddlProcince, pro);
            this.txtAddress.Value = modelDis.postAddress;
            this.txtZipCode.Text = modelDis.zipCode.ToString();
        }
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

        modelDis.receiveName = _receiveName;
        modelDis.postAddress = _address;
        modelDis.province = _province;
        modelDis.city = _city;
        modelDis.phone = _phone;
        modelDis.telephone = _cellphone;
        modelDis.zipCode = _zipCode;
        modelDis.userid = 1;//暂时测试，测试时修改回去
        modelDis.addtime = DateTime.Now;
        modelDis.id = Tools.StringHelp.GetInt(q("id"));

        if (bulDis.Update(modelDis))
            Response.Redirect("Manage_Address.aspx");
        else
            FinalMessage("修改失败！", "", 1);
    }
}
