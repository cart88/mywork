/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: Edit_Member
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

public partial class admin_member_Edit_Member : BasePage.PageUI
{
    private Test_BUL.sys_Common common = new Test_BUL.sys_Common();
    public Test_Model.sys_userinfo modelUser = new Test_Model.sys_userinfo();
    public Test_BUL.sys_userinfo bulUser = new Test_BUL.sys_userinfo();
    new public string userId;
    public string isbenuessTag;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (string.IsNullOrEmpty(q("id")))
                FinalMessage("网络错误！", "Manage_Member.aspx", 1);

            userId = q("id");
            BindProvince();
            BindData();
        }
    }

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
                ds = common.GetList(" select CityName from tb_sys_city where DomainID=" + _domainid);
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
            FinalMessage("URL解析错误，请勿在Url中添加非法关键词！", "Manage_Member.aspx", 1);

        modelUser = bulUser.GetModel(int.Parse(q("id")));
        if (modelUser != null)
        {
            this.txtUserName.Value = modelUser.userName.ToString();
            this.hidName.Value = modelUser.userName.ToString();
            this.txtTrueName.Value = modelUser.trueName.ToString();
            Tools.WebControl.SeRadioButtonList(this.rbSex, (modelUser.sex == true ? "1" : "0"));
            string pro = modelUser.province;
            string city = modelUser.city;
            GetCity(pro, city);
            this.hidProvince.Value = pro;
            this.hidCity.Value = city;
            Tools.WebControl.SetSelectedListByText(this.ddlProcince, pro);
            isbenuessTag = modelUser.isBusiness == true ? "1" : "0";
            Tools.WebControl.SeRadioButtonList(this.rbIsBusiness, isbenuessTag);
            this.txtRegistNumber.Value = modelUser.registNumber.ToString();
            this.txtDepartment.Value = modelUser.department.ToString();
            this.txtPosition.Value = modelUser.position.ToString();
            this.txtPhone.Value = modelUser.phone.ToString();
            this.txtAddress.Value = modelUser.address.ToString();
        }
    }

    protected void btnSend_Click(object sender, EventArgs e)
    {
        modelUser.userName = this.hidName.Value;
        modelUser.trueName = this.txtTrueName.Value.Trim();
        modelUser.currentScore = 30;//暂用，待改
        modelUser.totalScore = 30;//暂用，待改
        modelUser.sex = Tools.StringHelp.GetInt(this.rbSex.SelectedValue) == 1 ? true : false;
        modelUser.province = this.hidProvince.Value;
        modelUser.city = this.hidCity.Value;
        bool tempTag = Tools.StringHelp.GetInt(this.rbIsBusiness.SelectedValue) == 1 ? true : false;
        modelUser.isBusiness = tempTag;
        if (tempTag)
        {
            modelUser.registNumber = this.txtRegistNumber.Value.Trim();
            modelUser.department = this.txtDepartment.Value.Trim();
            modelUser.position = this.txtPosition.Value.Trim();
        }
        else
        {
            //由企业修改成个人时清空
            modelUser.registNumber = "";
            modelUser.department = "";
            modelUser.position = "";
        }
        modelUser.phone = this.txtPhone.Value.Trim();
        modelUser.address = this.txtAddress.Value.Trim();
        modelUser.ID = Tools.StringHelp.GetInt(q("id"));

        if (bulUser.Update(modelUser))
        {
            string bakp = string.IsNullOrEmpty(q("pageIndex")) ? "1" : q("pageIndex");
            Response.Redirect("Manage_Member.aspx?p=" + bakp);
        }
        else
            FinalMessage("修改失败！", "", 1);
    }

    protected void lkbtn_Click(object sender, EventArgs e)
    {
        Response.Redirect("Edit_Psssword.aspx?id=" + q("id"));
    }
}
