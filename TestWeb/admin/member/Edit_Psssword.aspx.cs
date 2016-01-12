using System;

public partial class admin_member_Edit_Psssword : BasePage.PageUI
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(ID))
            FinalMessage("网络错误！", "Manage_Member.aspx", 1);
        if (!Tools.Validator.IsPositiveInt(ID) || Tools.RequestCheck.CheckKeyWord(ID))
            FinalMessage("URL解析错误，请勿在Url中添加非法关键词！", "Manage_Member.aspx", 1);
    }

    public string ID
    {
        get
        {
            return string.IsNullOrEmpty(q("id")) ? "" : q("id");
        }
    }

    /// <summary>
    /// 更新密码操作
    /// </summary>
    protected void btnCon_Click(object sender, EventArgs e)
    {
        string relpwd = this.txtrelpwd.Value.Trim();
        string newpwd = this.txtnewpwd.Value.Trim();
        string chkpwd = this.txtchkpwd.Value.Trim();

        if (string.IsNullOrEmpty(relpwd) || string.IsNullOrEmpty(newpwd) || string.IsNullOrEmpty(chkpwd))
            FinalMessage("输入不完整或网络错误", "Edit_Psssword.aspx", 1);
        if (newpwd != chkpwd)
            FinalMessage("新密码两次输入不一致", "Edit_Psssword.aspx", 1);
        if (newpwd.Length < 6 || newpwd.Length > 16)
            FinalMessage("新密码长度与要求不符", "Edit_Psssword.aspx", 1);

        Test_BUL.sys_Common common = new Test_BUL.sys_Common();
        string strsql = " update tb_sys_userinfo set password='" + EncryptAdmin(newpwd) 
            + "' where id=" + ID + " and password='" + EncryptAdmin(relpwd) + "' ";

        if (common.ExecuteSql(strsql) > 0)
            Response.Redirect("Manage_Member.aspx");
        else
            FinalMessage("修改失败", "Edit_Psssword.aspx", 1);

    }
}
