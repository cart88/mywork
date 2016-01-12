/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: sys_role
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
    /// sys_role:实体类
    /// </summary>
    [Serializable]
    public partial class sys_role
    {
        public sys_role()
        { }
        #region Model
        private int _id;
        private string _rolename;
        private string _pageid;
        private string _adduser;
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
        /// 角色名字
        /// </summary>
        public string roleName
        {
            set { _rolename = value; }
            get { return _rolename; }
        }
        /// <summary>
        /// 页面id
        /// </summary>
        public string pageId
        {
            set { _pageid = value; }
            get { return _pageid; }
        }
        /// <summary>
        /// 添加人
        /// </summary>
        public string addUser
        {
            set { _adduser = value; }
            get { return _adduser; }
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