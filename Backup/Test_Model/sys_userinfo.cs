/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: sys_userinfo
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
    /// sys_userinfo:实体类
    /// </summary>
    [Serializable]
    public partial class sys_userinfo
    {
        public sys_userinfo()
        { }
        #region Model
        private int _id;
        private string _username;
        private string _password;
        private string _truename;
        private int? _currentscore;
        private int? _totalscore;
        private bool? _sex;
        private string _province;
        private string _city;
        private bool? _isbusiness;
        private string _registnumber;
        private string _department;
        private string _position;
        private string _phone;
        private string _address;
        private DateTime? _addtime;
        /// <summary>
        /// 
        /// </summary>
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// 会员名
        /// </summary>
        public string userName
        {
            set { _username = value; }
            get { return _username; }
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
        /// 真实姓名
        /// </summary>
        public string trueName
        {
            set { _truename = value; }
            get { return _truename; }
        }
        /// <summary>
        /// 当前积分
        /// </summary>
        public int? currentScore
        {
            set { _currentscore = value; }
            get { return _currentscore; }
        }
        /// <summary>
        /// 总积分
        /// </summary>
        public int? totalScore
        {
            set { _totalscore = value; }
            get { return _totalscore; }
        }
        /// <summary>
        /// 性别,男1，女0
        /// </summary>
        public bool? sex
        {
            set { _sex = value; }
            get { return _sex; }
        }
        /// <summary>
        /// 所在省
        /// </summary>
        public string province
        {
            set { _province = value; }
            get { return _province; }
        }
        /// <summary>
        /// 所在市
        /// </summary>
        public string city
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// 是否是企业用户，1是，0否
        /// </summary>
        public bool? isBusiness
        {
            set { _isbusiness = value; }
            get { return _isbusiness; }
        }
        /// <summary>
        /// 税务登记号
        /// </summary>
        public string registNumber
        {
            set { _registnumber = value; }
            get { return _registnumber; }
        }
        /// <summary>
        /// 部门
        /// </summary>
        public string department
        {
            set { _department = value; }
            get { return _department; }
        }
        /// <summary>
        /// 职位
        /// </summary>
        public string position
        {
            set { _position = value; }
            get { return _position; }
        }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 联系地址
        /// </summary>
        public string address
        {
            set { _address = value; }
            get { return _address; }
        }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime? addTime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        #endregion Model
    }
}