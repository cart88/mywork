using System;
using System.Collections.Specialized;
using System.Web;

public partial class error : BasePage.BasicPage
{
    public System.Text.StringBuilder strMsg;
    public string Go2Url;

    protected void Page_Load(object sender, EventArgs e)
    {
        strMsg = new System.Text.StringBuilder("");

        string strq = HttpUtility.UrlDecode(Request.QueryString.ToString());
        NameValueCollection nv = HttpUtility.ParseQueryString(strq);

        if (nv["errorMsgTag"] != null && nv["errorMsgTag"].ToString() != "")
        {
            string[] arr = nv["errorMsgTag"].ToString().Split(',');
            for (int i = 0; i < arr.Length; i++)
                if (arr[i].ToString() != "" && Tools.Validator.IsPositiveInt(arr[i].ToString()))
                    strMsg.Append("<li style=\"height: 25px;\">" + (i + 1) + "." + Test_BUL.sysParam.ErrorPageTip(arr[i].ToString()) + "</li>");
        }
        if (strMsg.ToString() == "")
            strMsg.Append("<li style=\"height: 28px; font-size:28px; line-height:30px;\">Oh，Shit！You make it lost</li>");

        Go2Url = (nv["Go2Url"] != null && nv["Go2Url"].ToString().Length > 0) ? nv["Go2Url"].ToString() : Request.RawUrl;
    }
}