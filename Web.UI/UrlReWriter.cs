using System;
using System.Text.RegularExpressions;
using System.Web;
using System.Globalization;

namespace Web.UI
{
    /// <summary>
    ///UrlReWriter 的摘要说明
    /// </summary>
    public class UrlReWriter : IHttpModule
    {
        public UrlReWriter()
        {
            //
            //TODO: 在此处添加构造函数逻辑
            //
        }

        #region IHttpModule 成员

        public void Dispose()
        {
            //这里写Dispose代码
        }

        public void Init(HttpApplication context)
        {
            #region
            //BeginRequest	指示请求处理开始
            //AuthenticateRequest	封装请求身份验证过程
            //AuthorizeRequest	封装检查是否能利用以前缓存的输出页面处理请求的过程
            //ResolveRequestCache	从缓存中得到相应时候触发
            //AcquireRequestState	加载初始化Session时候触发
            //PreRequestHandlerExecute	在Http请求进入HttpHandler之前触发
            //PostRequestHandlerExecute	在Http请求进入HttpHandler之后触发
            //ReleaseRequestState	存储Session状态时候触发
            //UpdateRequestCache	更新缓存信息时触发
            //EndRequest	在Http请求处理完成的时候触发
            //PreSendRequestHenaders	在向客户端发送Header之前触发
            //PreSendRequestConternt	在向客户端发送内容之前触发
            #endregion

            context.BeginRequest += new EventHandler(context_BeginRequest);
            context.Error += new EventHandler(context_Error);
        }

        void context_Error(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            context.Response.Write("<html>");
            context.Response.Write("<head><title>出错了！</title></head>");
            context.Response.Write("<body style=\"font-size:14px;\">");
            context.Response.Write("出错了:<br />");
            context.Response.Write("<textarea name=\"errormessage\" style=\"width:80%; height:200px; word-break:break-all\">");
            context.Response.Write(HttpUtility.HtmlEncode(context.Server.GetLastError().ToString()));
            context.Response.Write("</textarea>");
            context.Response.Write("</body></html>");
            context.Response.End();
        }
       
        void context_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            HttpContext context = application.Context;
            HttpResponse response = context.Response;
            string path = context.Request.FilePath;
            //重写后的URL地址
            if (path.IndexOf("member") > -1 || path.IndexOf("menu") > -1
                || path.IndexOf("orders") > -1 || path.IndexOf("syspage") > -1
                || path.IndexOf("sysparam") > -1 || path.IndexOf("sysuser") > -1
                || path.IndexOf("control") > -1)
            {
                CompareInfo Compare = CultureInfo.InvariantCulture.CompareInfo;
                if (Compare.IndexOf(path, "images", CompareOptions.IgnoreCase) == -1)
                {
                    //...
                }
            }
        }

        #endregion
    }
}
