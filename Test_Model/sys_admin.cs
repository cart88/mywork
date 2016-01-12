/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
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
    /// sys_admin:实体类
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
        /// 账号
        /// </summary>
        public string count
        {
            set { _count = value; }
            get { return _count; }
        }
        /// <summary>
        /// 密码
        /// </summary>
        public string password
        {
            set { _password = value; }
            get { return _password; }
        }
        /// <summary>
        /// 登录IP
        /// </summary>
        public string loginIP
        {
            set { _loginip = value; }
            get { return _loginip; }
        }
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime? loginTime
        {
            set { _logintime = value; }
            get { return _logintime; }
        }
        /// <summary>
        /// 手机号码
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
        /// 性别
        /// </summary>
        public bool? sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 账号创建时间
        /// </summary>
        public DateTime? createTime
        {
            set { _createtime = value; }
            get { return _createtime; }
        }
        /// <summary>
        /// 角色id
        /// </summary>
        public int? roleid
        {
            set { _roleid = value; }
            get { return _roleid; }
        }
        /// <summary>
        /// 超管标记:100
        /// </summary>
        public int? adminTag
        {
            set { _admintag = value; }
            get { return _admintag; }
        }
        /// <summary>
        /// 账号状态：10正常，20冻结，30禁用
        /// </summary>
        public int? AccountState
        {
            set { _accountstate = value; }
            get { return _accountstate; }
        }
        /// <summary>
        /// 行政级别
        /// </summary>
        public string PowerLeave
        {
            set { _powerleave = value; }
            get { return _powerleave; }
        }
        #endregion Model
    }
}