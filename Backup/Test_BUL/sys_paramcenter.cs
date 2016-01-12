/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
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

namespace Test_BUL
{
    /// <summary>
    /// sys_paramcenter
    /// </summary>
    public partial class sys_paramcenter
    {
        private readonly Maticsoft.DAL.sys_paramcenter dal = new Maticsoft.DAL.sys_paramcenter();
        public sys_paramcenter() { }

        #region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Test_Model.sys_paramcenter model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Test_Model.sys_paramcenter model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Test_Model.sys_paramcenter GetModel(int id)
        {
            return dal.GetModel(id);
        }

        #endregion  Method
    }
}

