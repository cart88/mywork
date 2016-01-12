/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: SysParam
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
using System.Collections.Generic;
using System.Text;

namespace Test_BUL
{
    /// <summary>
    /// 系统参数配置类
    /// </summary>
    public class sysParam
    {
        #region user cookies
        /*
         * 用model存储更合理些，序列化存储，用时再反序列化,回头再改吧 
         */

        public static string adminId = "test_sys_admin_id";                 //管理员id
        public static string adminCount = "test_sys_admin_count";           //管理员账户
        public static string adminRoleId = "test_sys_admin_roleid";         //管理员角色id
        public static string adminRoleName = "test_sys_admin_roleName";     //管理员角色名称
        public static string adminAdminTag = "test_sys_admin_adminTag";     //管理员级别标记
        public static string adminConState = "test_sys_admin_AccountState"; //管理员账户状态
        public static string adminPowerLeave = "text_sys_adminPowerLeave";   //管理员行政级别

        //=============================================================================

        public static string userId = "test_sys_userinfo_id";             //用户id
        public static string userName = "test_sys_userinfo_iname";        //用户真实姓名        
        public static string userNikeName = "test_sys_userinfo_nikename"; //用户昵称        
        public static string userCity = "test_sys_userinfo_sz_city";      //所在城市
        public static string userEmail = "test_sys_userinfo_email";       //Email
        public static string userEmailOK = "test_sys_userinfo_email_ok";  //Email是否验证
        public static string userBirthday = "test_sys_userinfo_bday";     //出生日期
        public static string userSex = "test_sys_userinfo_sex";           //用户性别
        public static string userLoginIp = "test_sys_userinfo_ip";        //用户登录ip
        public static string userAddress = "test_sys_userinfo_address";   //用户地址
        public static string userPhone = "test_sys_userinfo_phone";       //用户联系电话  
        public static string userIDcard = "test_sys_userinfo_code";       //用户身份证号

        /// <summary>
        /// cookie保存时间:一个星期
        /// </summary>
        public static int setCookiesTime = 24 * 7;
        /// <summary>
        /// cookies作用域
        /// </summary>        
        public static string CookiesDomain = "";//本地测试用的
        //public static string userCookiesDomain = "www.xxxxxxxx.com"; //发布后使用
        #endregion

        #region 缓存配置
        /// <summary>
        /// 用户访问页面文件id
        /// </summary>
        public static string CachePageIdDs = "pagefilesid";
        public static int CachePageIdDsTimes = 30;
        /// <summary>
        /// 省份信息
        /// </summary>
        public static string CacheCapital_info = "capital_info";
        #endregion

        #region 站点配置
        /// <summary>
        /// 站点路径
        /// </summary>
        public static string UrlSite = "";
        /// <summary>
        /// 图片路径
        /// </summary>
        public static string UrlImagePath = "";
        /// <summary>
        /// 超级管理员标记
        /// </summary>
        public static string AdministratorTagH = "100";
        /// <summary>
        /// 普通管理员标记
        /// </summary>
        public static string AdministratorTagN = "10";
        #endregion

        #region 错误提示
        /// <summary>
        /// 错误页面提示
        /// </summary>
        /// <param name="Tag">提示标记</param>
        public static string ErrorPageTip(string Tag)
        {
            string _response = string.Empty;
            switch (Tag)
            {
                #region common
                case "0":
                    _response = "网路延迟，刷新重试下";
                    break;
                case "1":
                    _response = "URL解析错误";
                    break;
                case "2":
                    _response = "您无权限访问该页面";
                    break;
                case "3":
                    _response = "表单或地址栏中含有尝试注入的非法关键词";
                    break;
                case "4":
                    _response = "此ip地址已被禁止授权访问";
                    break;
                case "5":
                    _response = "非正常操作";
                    break;
                case "6":
                    _response = "盗链请求";
                    break;
                case "7":
                    _response = "服务器未接受到页面请求";
                    break;
                #endregion

                #region admin login
                case "8":
                    _response = "您输入的账号不存在";
                    break;
                case "9":
                    _response = "您输入的密码有误";
                    break;
                case "10":
                    _response = "恭喜您登陆成功";
                    break;
                case "11":
                    _response = "此账号已被冻结，请与管理员联系";
                    break;
                case "12":
                    _response = "此账号已被禁用，请与管理员联系";
                    break;
                case "13":
                    _response = "亲爱的会员同志，您尚未登录";
                    break;
                case "14":
                    _response = "您的系统身份不合法，请与管理员联系";
                    break;
                case "15":
                    _response = "验证码输入错误，请重新填写";
                    break;
                #endregion

                #region tip
                case "16":
                    _response = "请确认所填信息的完整性";
                    break;

                #endregion

                #region site message
                case "17":
                    _response = "站内信获取失败，请刷新重试";
                    break;
                #endregion
            }

            return _response;
        }
        #endregion
    }
}
