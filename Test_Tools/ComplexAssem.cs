using System;
using System.Text;
using System.Data;
using System.IO;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Globalization;

namespace Tools
{
    /// <summary>
    /// 综合性处理基类
    /// add by zhouzhilong 
    /// 2011-11-4
    /// </summary>
    public class ComplexAssem
    {
        #region 生成随机数字字符串
        /// <summary>
        /// 生成随机数字字符串
        /// </summary>
        /// <param name="int_NumberLength">数字长度</param>
        /// <returns></returns>
        public string GetRandomNumberString(int int_NumberLength, bool onlyNumber)
        {
            Random random = new Random();
            return GetRandomNumberString(int_NumberLength, onlyNumber, random);
        }
        /// <summary>
        /// 生成随机数字字符串
        /// </summary>
        /// <param name="int_NumberLength">数字长度</param>
        /// <returns></returns>
        public string GetRandomNumberString(int int_NumberLength, bool onlyNumber, Random random)
        {
            string strings = "123456789";
            if (!onlyNumber) strings += "abcdefghjkmnpqrstuvwxyz";
            char[] chars = strings.ToCharArray();
            string returnCode = string.Empty;
            for (int i = 0; i < int_NumberLength; i++)
                returnCode += chars[random.Next(0, chars.Length)].ToString();
            return returnCode;
        }
        /// <summary>
        /// 生成产品订单号，全站统一格式(年月日时分秒+4位随机数)
        /// </summary>
        /// <returns></returns>
        public string GetProductOrderNum()
        {
            return DateTime.Now.ToString("yyyyMMddHHmmss") + GetRandomNumberString(4, true);
        }
        /// <summary>
        /// 产生随机数字字符串
        /// </summary>
        /// <returns></returns>
        public string RandomStr(int Num)
        {
            int number;
            char code;
            string returnCode = String.Empty;

            Random random = new Random();

            for (int i = 0; i < Num; i++)
            {
                number = random.Next();
                code = (char)('0' + (char)(number % 10));
                returnCode += code.ToString();
            }
            return returnCode;
        }
        #endregion

        #region 普通方法DataTable导出到Excel
        /// <summary>
        /// 普通方法导出Excel
        /// </summary>
        /// <param name="tb">DataTable</param>
        /// <param name="fileName">文件名</param>
        public static void TableToExcelCustom(System.Data.DataTable tb, string fileName)
        {
            string Filename = (fileName.Trim().Length > 0) ? fileName.Trim() : DateTime.Now.ToString("yyyyMMdd_hhmmss");
            System.Web.HttpContext context = System.Web.HttpContext.Current;
            if ((tb != null))
            {
                context.Response.Clear();
                context.Response.Charset = "GB2312";
                context.Response.ContentEncoding = System.Text.Encoding.GetEncoding("GB2312");
                context.Response.ContentType = "application/ms-excel";
                context.Response.AppendHeader("content-disposition", "attachment;filename=\"" + System.Web.HttpUtility.UrlEncode(Filename, System.Text.Encoding.GetEncoding("GB2312")) + ".xls\"");

                CultureInfo cult = new CultureInfo("zh-CN", true);
                StringWriter sw = new StringWriter(cult);
                HtmlTextWriter htw = new HtmlTextWriter(sw);
                DataGrid dgrid = new DataGrid();
                dgrid.DataSource = tb.DefaultView;
                dgrid.AllowPaging = false;
                dgrid.DataBind();
                htw.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html;charset=GB2312\">");
                dgrid.RenderControl(htw);
                context.Response.Write(sw.ToString());
                context.Response.End();
            }
        }
        #endregion

        #region 数组处理
        // 假设^表示逆序
        // A = (1,2,3)    A^ = (3,2,1)
        // B = (4,5,6,7)  B^ = (7,6,5,4)
        // 则：
        // AB = (1,2,3)(4,5,6,7)
        // (A^B^)^ = BA = (4,5,6,7)(1,2,3)
        /// <summary>
        /// 数组移位
        /// </summary>
        /// <param name="array">数组</param>
        /// <param name="numberOfElements">移动到的位置</param>
        public void MoveSubArrayToTheEnd(int[] array, int numberOfElements)
        {
            Array.Reverse(array, 0, numberOfElements);
            Array.Reverse(array, numberOfElements, array.Length - numberOfElements);
            Array.Reverse(array);
        }

        /// <summary>
        /// 移除数组中的某项
        /// </summary>
        /// <param name="array">数组对象</param>
        /// <param name="index">项索引</param>
        /// <returns>移除某项以后的数组</returns>
        public static string[] Remove(string[] array, int index)
        {
            int length = array.Length;
            string[] result = new string[length - 1];
            Array.Copy(array, result, index);
            Array.Copy(array, index + 1, result, index, length - index - 1);
            return result;
        }
        #endregion

        #region 更具生日获取星座

        /// <summary>
        /// 根据生日获取星座
        /// </summary>
        /// <param name="birthday"></param>
        /// <returns></returns>
        public static string GeConstellation(DateTime birthday)
        {
            float birthdayF = 0.00F;
            if (birthday.Month == 1 && birthday.Day < 20)
            {
                birthdayF = float.Parse(string.Format("13.{0}", birthday.Day));
            }
            else
            {
                birthdayF = float.Parse(string.Format("{0}.{1}", birthday.Month, birthday.Day));
            }
            float[] atomBound = { 1.20F, 2.20F, 3.21F, 4.21F, 5.21F, 6.22F, 7.23F, 8.23F, 9.23F, 10.23F, 11.21F, 12.22F, 13.20F };
            string[] atoms = { "水瓶座", "双鱼座", "白羊座", "金牛座", "双子座", "巨蟹座", "狮子座", "处女座", "天秤座", "天蝎座", "射手座", "魔羯座" };

            string ret = "靠！外星人啊。";
            for (int i = 0; i < atomBound.Length - 1; i++)
            {
                if (atomBound[i] <= birthdayF && atomBound[i + 1] > birthdayF)
                {
                    ret = atoms[i];
                    break;
                }
            }
            return ret == "靠！外星人啊。" ? "魔羯座" : ret;
        }

        #endregion

        #region 正则表达式限制输入
        //用正则表达式限制只能输入中文：onkeyup="value=value.replace(/[^\u4E00-\u9FA5]/g,'')" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\u4E00-\u9FA5]/g,''))"
        //1.用正则表达式限制只能输入全角字符： onkeyup="value=value.replace(/[^\uFF00-\uFFFF]/g,'')" onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\uFF00-\uFFFF]/g,''))"
        //2.用正则表达式限制只能输入数字：onkeyup="value=value.replace(/[^\d]/g,'') "onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))"
        //3.用正则表达式限制只能输入数字和英文：onkeyup="value=value.replace(/[\W]/g,'') "onbeforepaste="clipboardData.setData('text',clipboardData.getData('text').replace(/[^\d]/g,''))"
        #endregion

        #region 限制图片大小
        //jQuery.fn.ImageAutoSize = function(width,height)
        //{
        //$(“img”,this).each(function()
        //{
        //var image = $(this);
        //if(image.width()>width)
        //{
        //image.width(width);
        //image.height(width/image.width()*image.height());
        //}
        //if(image.height()>height)
        //{
        //image.height(height);
        //image.width(height/image.height()*image.width());
        //}
        //});
        //}
        //调用:先引用上面的脚本或将上页的脚本放入自己的JS库,然后只要再加 $(function(){ $(“图片组所在的容器”).ImageAutoSize(限制最大宽,限制最大高);});
        #endregion
    }
}