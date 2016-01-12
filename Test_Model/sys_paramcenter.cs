/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 ÿ�����һ���
** Name: sys_paramcenter
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
    /// sys_paramcenter:ʵ����
    /// </summary>
    [Serializable]
    public partial class sys_paramcenter
    {
        public sys_paramcenter()
        { }
        #region Model
        private int _id;
        private string _name;
        private int? _value;
        private string _typetag;
        private int _adduserid;
        private string _addusername;
        private DateTime? _addtime;
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// ������
        /// </summary>
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        /// <summary>
        /// ����ֵ
        /// </summary>
        public int? value
        {
            set { _value = value; }
            get { return _value; }
        }
        /// <summary>
        /// ���
        /// </summary>
        public string typeTag
        {
            set { _typetag = value; }
            get { return _typetag; }
        }
        /// <summary>
        /// �����id
        /// </summary>
        public int addUserId
        {
            set { _adduserid = value; }
            get { return _adduserid; }
        }
        /// <summary>
        /// ���������
        /// </summary>
        public string addUserName
        {
            set { _addusername = value; }
            get { return _addusername; }
        }
        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime? addTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        #endregion Model
    }
}