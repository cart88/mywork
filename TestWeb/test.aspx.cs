using System;

/// <summary>
/// 各种测试用的页面
/// </summary>
public partial class test : System.Web.UI.Page
{
    public string aaaa = string.Empty;
    protected void Page_Load(object sender, EventArgs e)
    {
        string _str = @"年轻,并非人生旅程的一段时光,也并非粉颊红唇和体魄的矫健,
                        它是心灵中的一种状态,是头脑中的一个意念,是理性思维中的创造潜力,
                        是情感活动中的一股勃勃的朝气";
        aaaa = _str.Replace(",", "<br/>");
        //Response.Write(_str);
    }
}