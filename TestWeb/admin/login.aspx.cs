using System;

public partial class admin_login : BasePage.BasicPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (CheckAdminLogin())
            Response.Redirect("~/admin/admin.aspx");
    }
}