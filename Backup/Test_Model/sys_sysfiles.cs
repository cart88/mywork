/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 ÿ�����һ���
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
    /// sys_sysfiles:ʵ����
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
        /// ��id
        /// </summary>
        public int? classId
        {
            set { _classid = value; }
            get { return _classid; }
        }
        /// <summary>
        /// �ļ���
        /// </summary>
        public string fielsName
        {
            set { _fielsname = value; }
            get { return _fielsname; }
        }
        /// <summary>
        /// �ļ�·��
        /// </summary>
        public string filesUrl
        {
            set { _filesurl = value; }
            get { return _filesurl; }
        }
        /// <summary>
        /// ����˵��
        /// </summary>
        public string describe
        {
            set { _describe = value; }
            get { return _describe; }
        }
        /// <summary>
        /// ������ֵ
        /// </summary>
        public int? filesOrder
        {
            set { _filesOrder = value; }
            get { return _filesOrder; }
        }
        /// <summary>
        /// �Ƿ��������ʾ
        /// </summary>
        public bool? showLeft
        {
            set { _showleft = value; }
            get { return _showleft; }
        }
        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime? addTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        /// <summary>
        /// �����id
        /// </summary>
        public int? addUserId
        {
            set { _adduserid = value; }
            get { return _adduserid; }
        }
        /// <summary>
        /// �����
        /// </summary>
        public string addUser
        {
            set { _adduser = value; }
            get { return _adduser; }
        }
        #endregion Model
    }
}