using System;
using System.Collections.Generic;
using System.Text;
//
using System.Web;
using System.Text.RegularExpressions;

namespace Tools
{
    /// <summary>
    /// 页面Request对象检查

    /// </summary>
    public class RequestCheck
    {
        private HttpRequest request;
        private const string StrKeyWord = @"select|insert|delete|from|count(|drop table|update|truncate|asc(|mid(|char(|xp_cmdshell|exec master|netlocalgroup administrators|:|net user|""|or|and";
        private const string StrRegex = @"[-|;|,|/|(|)|[|]|}|{|@|*|!|']";

        /// <summary>
        /// 构造函数

        /// </summary>
        public RequestCheck(System.Web.HttpRequest _request)
        {
            this.request = _request;
        }

        /// <summary>
        /// 只读属性 SQL关键字

        /// </summary>
        public static string KeyWord
        {
            get
            {
                return StrKeyWord;
            }
        }
        /// <summary>
        /// 只读属性过滤特殊字符

        /// </summary>
        public static string RegexString
        {
            get
            {
                return StrRegex;
            }
        }

        /// <summary>
        /// 检查URL参数中是否带有SQL注入可能关键字。

        /// </summary>
        /// <param name="_request">当前HttpRequest对象</param>
        /// <returns>存在注入活特殊关键字true存在，false不存在</returns>
        public bool CheckRequestQuery()
        {
            if (request.QueryString.Count != 0)
            {
                //若URL中参数存在，逐个比较参数。

                for (int i = 0; i < request.QueryString.Count; i++)
                {
                    // 检查参数值是否合法。

                    if (CheckKeyWord(request.QueryString[i].ToString()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// 检查提交表单中是否存在SQL注入可能关键字

        /// </summary>
        /// <param name="_request">当前HttpRequest对象</param>
        /// <returns>存在SQL注入关键字true存在，false不存在</returns>
        public bool CheckRequestForm()
        {
            if (request.Form.Count > 0)
            {
                //获取提交的表单项不为0 逐个比较参数
                for (int i = 0; i < request.Form.Count; i++)
                {
                    //检查参数值是否合法

                    if (CheckKeyWord(request.Form[i]))
                    {
                        //存在SQL关键字

                        return true;
                    }
                }
            }
            return false;
        }

        #region 改方法已废弃
        /// <summary>
        /// 静态方法，检查_sword是否包涵SQL关键字

        /// </summary>
        /// <param name="_sWord">被检查的字符串</param>
        /// <returns>存在SQL关键字返回true，不存在返回false</returns>
        //public static bool CheckKeyWord(string _sWord)
        //{
        //    if (Regex.IsMatch(_sWord, StrKeyWord, RegexOptions.IgnoreCase) || Regex.IsMatch(_sWord, StrRegex))
        //        return true;
        //    return false;
        //}
        #endregion

        /// <summary>
        /// 静态方法，检查_sword是否包含非法关键字

        /// </summary>
        /// <param name="_sWord">被检查的字符串</param>
        /// <returns>存在SQL关键字返回true，不存在返回false</returns>
        public static bool CheckKeyWord(string _sWord)
        {
            string[] arry_sql = StrKeyWord.Split('|');
            string[] arry_key = StrRegex.Split('|');
            foreach (string paramSQL in arry_sql)
            {
                if (_sWord.Contains(paramSQL))
                {
                    return true;
                }
            }
            foreach (string paramKEY in arry_key)
            {
                if (_sWord.Contains(paramKEY))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
