/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: CCLinkButton
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
using System.Text.RegularExpressions;

namespace CCControl
{
    public class CCUtilsComplex
    {
        /// <summary>
        /// 验证正则
        /// </summary>
        private static readonly Regex reg = new Regex(@"^(?:[\S\s]*?)\?(?<parameters>[\S\s]*?)$");
        /// <summary>
        /// 对链接地址进行参数MD5加密校验
        /// </summary>
        /// <param name="baseurl"></param>
        /// <returns></returns>
        public static string UrlMD5(string baseurl)
        {
            if (!reg.IsMatch(baseurl)) return baseurl;

            Match match = reg.Match(baseurl);
            return string.Format("{0}&md={1}", baseurl, UrlEncrypt(match.Groups["parameters"].Value.ToLower()));
        }
        /// <summary>
        /// 校验参数有效性
        /// <remarks>有参数就校验，没有就不处理</remarks>
        /// </summary>
        public static string UrlEncrypt(string param)
        {
            string tempstr = string.Empty;
            tempstr = Tools.Encrypt.MD5Encrypt(Tools.Encrypt.MD5Encrypt(param));
            tempstr = tempstr.Substring(0, 8) + Tools.StringHelp.ReverseStr(tempstr).Substring(0, 8);
            tempstr = Tools.Encrypt.MD5Encrypt(tempstr).Substring(0, 16).ToUpper();//取16位转大写
            return tempstr;
        }
    }
}