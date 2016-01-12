/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: sys_sysfiles
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
namespace Test_Model
{
    /// <summary>
    /// sys_sysfiles:实体类
    /// </summary>
    [Serializable]
    public partial class sys_sysfiles
    {
        public sys_sysfiles()
        { }
        #region Model
        private int _id;
        private int? _classid;
        private string _fielsname;
        private string _filesurl;
        private string _describe;
        private int? _filesOrder;
        private bool? _showleft;
        private DateTime? _addtime;
        private int? _adduserid;
        private string _adduser;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 父id
        /// </summary>
        public int? classId
        {
            set { _classid = value; }
            get { return _classid; }
        }
        /// <summary>
        /// 文件名
        /// </summary>
        public string fielsName
        {
            set { _fielsname = value; }
            get { return _fielsname; }
        }
        /// <summary>
        /// 文件路径
        /// </summary>
        public string filesUrl
        {
            set { _filesurl = value; }
            get { return _filesurl; }
        }
        /// <summary>
        /// 描述说明
        /// </summary>
        public string describe
        {
            set { _describe = value; }
            get { return _describe; }
        }
        /// <summary>
        /// 排序数值
        /// </summary>
        public int? filesOrder
        {
            set { _filesOrder = value; }
            get { return _filesOrder; }
        }
        /// <summary>
        /// 是否在左边显示
        /// </summary>
        public bool? showLeft
        {
            set { _showleft = value; }
            get { return _showleft; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? addTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        /// <summary>
        /// 添加人id
        /// </summary>
        public int? addUserId
        {
            set { _adduserid = value; }
            get { return _adduserid; }
        }
        /// <summary>
        /// 添加人
        /// </summary>
        public string addUser
        {
            set { _adduser = value; }
            get { return _adduser; }
        }
        #endregion Model
    }
}