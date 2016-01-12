﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Tools
{
    /// <summary>
    /// Excel表头字段类用于处理自定义表头时使用
    /// </summary>
    public class ExcelColumn
    {
        private int _width = 150;//默认宽度
        private string _name = string.Empty;//列名
        private int _mergeAcross = 0;//跨越字段
        /**/
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="width">列宽</param>
        /// <param name="name">列名</param>
        public ExcelColumn(int width, string name)
        {
            this._width = width;
            this._name = name;
            this._mergeAcross = 0;
        }
        /**/
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">列名</param>
        /// <param name="colspan">合并列数</param>
        public ExcelColumn(string name, int colspan)
        {
            this._name = name;
            this._mergeAcross = colspan - 1;
        }
        /**/
        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name">列名</param>
        public ExcelColumn(string name)
        {
            this._name = name;
        }
        public int Width
        {
            get { return _width; }
        }
        public string Name
        {
            get { return _name; }
        }
        public int MergeAcross
        {
            get { return _mergeAcross; }
        }

    }
}
