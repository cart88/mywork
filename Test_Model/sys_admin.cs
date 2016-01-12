/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 ÿ�����һ���
** Name: sys_admin
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
    /// sys_admin:ʵ����
    /// </summary>
    [Serializable]
    public partial class sys_admin
    {
        public sys_admin()
        { }
        #region Model
        private int _id;
        private string _count;
        private string _password;
        private string _loginip;
        private DateTime? _logintime;
        private string _telephone;
        private string _email;
        private bool? _sex;
        private DateTime? _birthday;
        private DateTime? _createtime;
        private int? _roleid;
        private int? _admintag;
        private int? _accountstate;
        private string _powerleave = "M12";
        /// <summary>
        /// 
        /// </summary>
        public int id
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// �˺�
        /// </summary>
        public string count
        {
            set { _count = value; }
            get { return _count; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// ��¼IP
        /// </summary>
        public string loginIP
        {
            set { _loginip = value; }
            get { return _loginip; }
        }
        /// <summary>
        /// ��¼ʱ��
        /// </summary>
        public DateTime? loginTime
        {
            set { _logintime = value; }
            get { return _logintime; }
        }
        /// <summary>
        /// �ֻ�����
        /// </summary>
        public string telephone
        {
            set { _telephone = value; }
            get { return _telephone; }
        }
        /// <summary>
        /// email
        /// </summary>
        public string email
        {
            set { _email = value; }
            get { return _email; }
        }
        /// <summary>
        /// �Ա�
        /// </summary>
        public bool? sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// ����
        /// </summary>
        public DateTime? birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// �˺Ŵ���ʱ��
        /// </summary>
        public DateTime? createTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// ��ɫid
        /// </summary>
        public int? roleid
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// ���ܱ��:100
        /// </summary>
        public int? adminTag
        {
            set { _admintag = value; }
            get { return _admintag; }
        }
        /// <summary>
        /// �˺�״̬��10������20���ᣬ30����
        /// </summary>
        public int? AccountState
        {
            set { _accountstate = value; }
            get { return _accountstate; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string PowerLeave
        {
            set { _powerleave = value; }
            get { return _powerleave; }
        }
        #endregion Model
    }
}