/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 ÿ�����һ���
** Name: sys_sysmenu
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
    /// sys_sysmenu:ʵ����
    /// </summary>
    [Serializable]
    public partial class sys_sysmenu
    {
        public sys_sysmenu()
        { }
        #region Model
        private int _id;
        private string _menuname;
        private int? _menuorder;
        private string _imgurl;
        private string _addname;
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
        /// �˵�����
        /// </summary>
        public string menuName
        {
            set { _menuname = value; }
            get { return _menuname; }
        }
        /// <summary>
        /// ������ֵ
        /// </summary>
        public int? menuOrder
        {
            set { _menuorder = value; }
            get { return _menuorder; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string imgUrl
        {
            set { _imgurl = value; }
            get { return _imgurl; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string addName
        {
            set { _addname = value; }
            get { return _addname; }
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