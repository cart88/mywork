/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: BasicPage
** Remarks: 
** Varsion: 1.0
** Author:  Jon
** Contact: 573741776@qq.com
** Last Edit User: 
** Last Edit Time: 2013-01-10
** Statement: 
            年轻
            并非人生旅程的一段时光
            也并非粉颊红唇和体魄的矫健
            它是心灵中的一种状态
            是头脑中的一个意念
            是理性思维中的创造潜力
            是情感活动中的一股勃勃的朝气
**-----------------------------------------------------------------
******************************************************************/

using System;
using System.Text;
using System.Web;
using System.IO;
using System.Web.UI;

namespace BasePage
{
    /// <summary>
    /// 页面处理基类
    /// <remarks>请勿修改</remarks>
    /// </summary>
    public class BasicPage : System.Web.UI.Page
    {
        #region 读取cookies 要修改，应该讲用户的实体类序列号写入到缓存中

        //用户cookies
        public string adminGetId = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.adminId);        //管理员id
        public string adminGetCount = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.adminCount);//管理员账户
        public string adminGetRoleId = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.adminRoleId);//管理员角色id
        public string adminGetRoleName = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.adminRoleName);//管理员角色名称
        public string adminGetadminTag = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.adminAdminTag);//管理员级别标记
        public string adminGetConState = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.adminConState);//管理员账户状态
        public string adminGetPowerLeave = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.adminPowerLeave);//管理员行政级别

        //===============================================================================================================

        public string userId = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.userId);            //用户id
        public string userName = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.userName);        //用户真实姓名    
        public string userNikeName = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.userNikeName);//用户昵称        
        public string userSex = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.userSex);          //用户性别
        public string userBirthday = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.userBirthday);//出生日期
        public string userCity = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.userCity);        //所在城市
        public string userEmail = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.userEmail);      //Email
        public string userEmailOK = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.userEmailOK);  //Email是否验证
        public string userLoginIp = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.userLoginIp);  //用户登录的ip
        public string userAddress = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.userAddress);  //用户地址
        public string userPhone = Tools.CookiesHelp.GetCookieValue(Test_BUL.sysParam.userPhone);  //用户联系电话

        #endregion

        /// <summary>
        /// 管理员是否登录了
        /// </summary>
        /// <returns></returns>
        public bool CheckAdminLogin()
        {
            if (!string.IsNullOrEmpty(adminGetId) && !string.IsNullOrEmpty(adminGetCount) &&
                !string.IsNullOrEmpty(adminGetRoleId) && !string.IsNullOrEmpty(adminGetadminTag))
                return true;
            else
                return false;
        }
        /// <summary>
        /// 用户密码加密
        /// </summary>
        /// <param name="paramStr">待加密的字符串</param>
        /// <returns>加密后的字符串</returns>
        public static string EncryptAdmin(string paramStr)
        {
            return Tools.Encrypt.MD5Encrypt(Tools.Encrypt.MD5Encrypt(paramStr));
        }

        #region 处理完成输出页面提醒并跳转
        /// <summary>
        /// 处理过程完成
        /// </summary>
        /// <param name="pageMsg">页面提示信息</param>
        /// <param name="go2Url">如果倒退步数为0，就转到该地址</param>
        /// <param name="BackStep">倒退步数</param>
        protected void FinalMessage(string pageMsg, string go2Url, int BackStep)
        {
            FinalMessage(pageMsg, go2Url, BackStep, 2);
        }
        protected void FinalMessage(string pageMsg, string go2Url, int BackStep, int Seconds)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<!DOCTYPE html PUBLIC '-//W3C//DTD XHTML 1.0 Transitional//EN' 'http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd'>\r\n");
            sb.Append("<html xmlns='http://www.w3.org/1999/xhtml'>\r\n");
            sb.Append("<head>\r\n");
            sb.Append("<meta http-equiv='Content-Type' content='text/html; charset=utf-8' />\r\n");
            sb.Append("<head>\r\n");
            sb.Append("<title>系统提示</title>\r\n");
            sb.Append("<style>\r\n");
            sb.Append("body {padding:0; margin:0; }\r\n");
            sb.Append("#infoBox{padding:0; margin:0; position:absolute; top:40%; width:100%; text-align:center;}\r\n");
            sb.Append("#info{padding:0; margin:0;position:relative; top:-40%; right:0; border:0px #B4E0F7 solid; text-align:center;}\r\n");
            sb.Append(".a_goto{ color:#ff0000; text-decoration:underline;}");
            sb.Append("</style>\r\n");
            sb.Append("<script language=\"javascript\">\r\n");
            sb.Append("var seconds=" + Seconds + ";\r\n");
            sb.Append("for(i=1;i<=seconds;i++)\r\n");
            sb.Append("{window.setTimeout(\"update(\" + i + \")\", i * 1000);}\r\n");
            sb.Append("function update(num)\r\n");
            sb.Append("{\r\n");
            sb.Append("if(num == seconds)\r\n");
            if (BackStep > 0)
                sb.Append("{ history.go(" + (0 - BackStep) + "); }\r\n");
            else
            {
                if (go2Url != "")
                    sb.Append("{ self.location.href='" + go2Url + "'; }\r\n");
                else
                    sb.Append("{window.close();}\r\n");
            }
            sb.Append("else\r\n");
            sb.Append("{ }\r\n");
            sb.Append("}\r\n");
            sb.Append("</script>\r\n");
            sb.Append("<base target='_self' />\r\n");
            sb.Append("</head>\r\n");
            sb.Append("<body>\r\n");
            sb.Append("<div id='infoBox'>\r\n");
            sb.Append("<div id='info'>\r\n");
            sb.Append("<div style='text-align:center;margin:0 auto;width:320px;padding-top:4px;line-height:26px;height:26px;font-weight:bold;color:#2259A6;font-size:14px;border:1px #B4E0F7 solid;background:#CAEAFF;'>提示信息</div>\r\n");
            sb.Append("<div style='text-align:center;padding:20px 0 20px 0;margin:0 auto;width:320px;font-size:12px;background:#F5FBFF;border-right:1px #B4E0F7 solid;border-bottom:1px #B4E0F7 solid;border-left:1px #B4E0F7 solid;'>\r\n");
            sb.Append(pageMsg + "<br /><br />\r\n");
            if (BackStep > 0)
                sb.Append("        <a class=\"a_goto\" href=\"javascript:history.go(" + (0 - BackStep) + ")\">如果您的浏览器没有自动跳转，请点击这里</a>\r\n");
            else
                sb.Append("        <a class=\"a_goto\" href=\"" + go2Url + "\">如果您的浏览器没有自动跳转，请点击这里</a>\r\n");
            sb.Append("    </div>\r\n");
            sb.Append("</div>\r\n");
            sb.Append("</div>\r\n");
            sb.Append("</body>\r\n");
            sb.Append("</html>\r\n");
            Response.Write(sb.ToString());
            Response.End();
        }
        #endregion

        #region QueryString、Form对象
        /// <summary>
        /// 获取querystring
        /// </summary>
        /// <param name="s">参数名</param>
        /// <returns>返回值</returns>
        public string q(string s)
        {
            if (HttpContext.Current.Request.QueryString[s] != null && HttpContext.Current.Request.QueryString[s] != "")
            {
                return Tools.StringHelp.SafetyStr(HttpContext.Current.Request.QueryString[s].ToString());
            }
            return string.Empty;
        }

        /// <summary>
        /// 获取post得到的参数
        /// </summary>
        /// <param name="s">参数名</param>
        /// <returns>返回值</returns>
        public string f(string s)
        {
            if (HttpContext.Current.Request.Form[s] != null && HttpContext.Current.Request.Form[s] != "")
            {
                return HttpContext.Current.Request.Form[s].ToString();
            }
            return string.Empty;
        }

        /// <summary>
        /// 构建Request.QueryString(主要用于分页)
        /// </summary>
        /// <returns></returns>
        public string GetRequestQuery()
        {
            int queCout = Request.QueryString.Count;
            StringBuilder strbu = new StringBuilder("");
            //去掉第一个参数

            for (int i = 0; i < queCout; i++)
            {
                if (Request.QueryString.Keys[i] != null && Request.QueryString.Keys[i].ToString() != "p")
                {
                    strbu.Append(Request.QueryString.Keys[i].ToString() + "=" + Request.QueryString[i].ToString());
                    strbu.Append(i != queCout - 1 ? "&" : "");
                }
            }
            return strbu.ToString() != "" ? "&" + strbu.ToString() : "";
        }
        /// <summary>
        /// 获取所有参数名和值除校验参数外
        /// </summary>
        public string GetRequestParametersValue()
        {
            int queCout = Request.QueryString.Count;
            StringBuilder strbu = new StringBuilder("");
            for (int i = 0; i < queCout; i++)
            {
                if (Request.QueryString.Keys[i] != null && Request.QueryString.Keys[i].ToString() != "md")
                {
                    strbu.Append(Request.QueryString.Keys[i].ToString() + "=" + Request.QueryString[i].ToString());
                    strbu.Append(i != queCout - 1 ? "&" : "");
                }
            }
            string tempStr = strbu.ToString();
            return tempStr.LastIndexOf('&') > -1 ? tempStr.TrimEnd('&') : tempStr;
        }
        #endregion

        #region 解决ViewState过于庞大的问题
        /*
        //由于这里添加了目录,所以要建立App_Data/ViewState目录.
        protected override object LoadPageStateFromPersistenceMedium()
        {
            string viewStateID = (string)((Pair)base.LoadPageStateFromPersistenceMedium()).Second;
            string stateStr = (string)Cache[viewStateID];
            if (stateStr == null)
            {
                string fn = Path.Combine(this.Request.PhysicalApplicationPath, @"App_Data/ViewState/" + viewStateID + ".txt");
                stateStr = File.ReadAllText(fn);
            }
            return new ObjectStateFormatter().Deserialize(stateStr);
        }
        protected override void SavePageStateToPersistenceMedium(object state)
        {
            string value = new ObjectStateFormatter().Serialize(state);
            string viewStateID = (DateTime.Now.Ticks + (long)this.GetHashCode()).ToString();
            //产生离散的id号码           
            string fn = Path.Combine(this.Request.PhysicalApplicationPath, @"App_Data/ViewState/" + viewStateID + ".txt");
            //ThreadPool.QueueUserWorkItem(File.WriteAllText(fn, value));         
            File.WriteAllText(fn, value);
            Cache.Insert(viewStateID, value);
            base.SavePageStateToPersistenceMedium(viewStateID);
        }
        */
        #endregion

        #region 返回非负整数
        /// <summary>
        /// 返回非负整数，默认为t
        /// </summary>
        /// <param name="s">参数值</param>
        /// <returns>返回值</returns>
        public int Str2Int(string s, int t)
        {
            return Tools.Validator.StrToInt(s, t);
        }
        /// <summary>
        /// 返回非负整数，默认为0
        /// </summary>
        /// <param name="s">参数值</param>
        /// <returns>返回值</returns>
        public int Str2Int(string s)
        {
            return Str2Int(s, 0);
        }
        #endregion

        #region 其它操作
        /// <summary>
        /// 简单的防止站外提交表单
        /// <remarks>iis配置如果支持文件读写，请将写入日志的地方注释</remarks>
        /// </summary>
        /// <returns></returns>
        public bool CheckFormUrl()
        {
            if (HttpContext.Current.Request.UrlReferrer == null)
            {
                SaveVisitLog(2, 0);   //写入日志
                return false;
            }
            if ((HttpContext.Current.Request.UrlReferrer.Host) != (HttpContext.Current.Request.Url.Host))
            {
                SaveVisitLog(2, 0);   //写入日志
                return false;
            }

            return true;
        }

        /// <summary>
        /// 服务器地址
        /// </summary>
        /// <returns></returns>
        protected string ServerUrl()
        {
            if (HttpContext.Current.Request.ServerVariables["Server_Port"].ToString() == "80")
                return "http://" + HttpContext.Current.Request.Url.Host;
            else
                return "http://" + HttpContext.Current.Request.Url.Host + ":" + HttpContext.Current.Request.ServerVariables["Server_Port"].ToString();
        }

        /// <summary>
        /// 当前地址
        /// </summary>
        public string GetCurrentUrl
        {
            get
            {
                string strUrl;
                strUrl = HttpContext.Current.Request.ServerVariables["Url"];
                if (HttpContext.Current.Request.QueryString.Count == 0) //如果无参数


                    return strUrl;
                else
                    return strUrl + "?" + HttpContext.Current.Request.ServerVariables["Query_String"];
            }
        }

        /// <summary>
        /// 获得用户IP
        /// </summary>
        public static string GetUserIp
        {
            get
            {
                string ip;
                string[] temp;
                bool isErr = false;
                if (HttpContext.Current.Request.ServerVariables["HTTP_X_ForWARDED_For"] == null)
                    ip = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"].ToString();
                else
                    ip = HttpContext.Current.Request.ServerVariables["HTTP_X_ForWARDED_For"].ToString();
                if (ip.Length > 15)
                    isErr = true;
                else
                {
                    temp = ip.Split('.');
                    if (temp.Length == 4)
                    {
                        for (int i = 0; i < temp.Length; i++)
                        {
                            if (temp[i].Length > 3) isErr = true;
                        }
                    }
                    else
                        isErr = true;
                }

                if (isErr)
                    return "1.1.1.1";
                else
                    return ip;
            }
        }

        /// <summary>
        /// 当前访客
        /// </summary>
        public string ThisUser()
        {
            if (userName != null)
                return userName;
            else
                return "游客";
        }
        #endregion

        #region 记录日志
        /// <summary>
        /// 页面访问超时后记录日志
        /// </summary>
        /// <param name="_second">超时秒数</param>
        public void SavePageLog(int _second)
        {
            SaveVisitLog(1, _second);
        }
        /// <summary>
        /// 保存访问日志
        /// </summary>
        /// <param name="_type">1代表访问者,2代表非法</param>
        /// <param name="_second">脚本秒数</param>
        public void SaveVisitLog(int _type, int _second)
        {
            SaveVisitLog(_type, _second, "");
        }
        /// <summary>
        /// 保存访问日志
        /// </summary>
        /// <param name="_type">1代表访问者,2代表非法</param>
        /// <param name="_second">脚本秒数</param>
        /// <param name="_logfilename">自定义log保存路径</param>
        public void SaveVisitLog(int _type, int _second, string _logfilename)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(this.Server.MapPath("~/data_log/"));
            if (!dir.Exists)
                dir.Create();

            if (_type == 1)
            {
                string _savefile = _logfilename == "" ? "~/data_log/vister_" + DateTime.Now.ToString("yyyyMMdd") + ".log" : _logfilename;
                Single s = (Single)DateTime.Now.Subtract(HttpContext.Current.Timestamp).TotalSeconds;
                if (s > _second)
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(HttpContext.Current.Server.MapPath(_savefile), true, System.Text.Encoding.UTF8);
                    sw.WriteLine(System.DateTime.Now.ToString());
                    sw.WriteLine("\tIP 地 址：" + GetUserIp);
                    sw.WriteLine("\t访 问 者：" + ThisUser());
                    sw.WriteLine("\t浏 览 器：" + HttpContext.Current.Request.Browser.Browser + HttpContext.Current.Request.Browser.Version);
                    sw.WriteLine("\t耗    时：" + ((Single)DateTime.Now.Subtract(HttpContext.Current.Timestamp).TotalSeconds).ToString("0.000") + "秒");
                    sw.WriteLine("\t地    址：" + ServerUrl() + GetCurrentUrl);
                    sw.WriteLine("---------------------------------------------------------------------------------------------------");
                    sw.Close();
                    sw.Dispose();
                }
            }
            else
            {
                string _savefile = _logfilename == "" ? "~/data_log/hacker_" + DateTime.Now.ToString("yyyyMMdd") + ".log" : _logfilename;
                System.IO.StreamWriter sw = new System.IO.StreamWriter(HttpContext.Current.Server.MapPath(_savefile), true, System.Text.Encoding.UTF8);
                sw.WriteLine(System.DateTime.Now.ToString());
                sw.WriteLine("\tIP 地 址：" + GetUserIp);
                sw.WriteLine("\t访 问 者：" + ThisUser());
                sw.WriteLine("\t浏 览 器：" + HttpContext.Current.Request.Browser.Browser + HttpContext.Current.Request.Browser.Version);
                sw.WriteLine("\t来    源：" + ServerUrl() + GetCurrentUrl);
                sw.WriteLine("\t地    址：" + ServerUrl() + GetCurrentUrl);
                sw.WriteLine("---------------------------------------------------------------------------------------------------");
                sw.Close();
                sw.Dispose();
            }
        }
        #endregion
    }
}
