/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 ÿ�����һ���
** Name: sys_distribution
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
using System.Data;
using System.Collections.Generic;

namespace Test_BUL
{
    /// <summary>
    /// sys_distribution
    /// </summary>
    public partial class sys_distribution
    {
        private readonly Test_DAL.sys_distribution dal = new Test_DAL.sys_distribution();
        public sys_distribution()
        { }
        #region  Method

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Test_Model.sys_distribution model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Update(Test_Model.sys_distribution model)
        {
            return dal.Update(model);
        }
        
        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Test_Model.sys_distribution GetModel(int id)
        {

            return dal.GetModel(id);
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// ���ǰ��������
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Test_Model.sys_distribution> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// ��������б�
        /// </summary>
        public List<Test_Model.sys_distribution> DataTableToList(DataTable dt)
        {
            List<Test_Model.sys_distribution> modelList = new List<Test_Model.sys_distribution>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Test_Model.sys_distribution model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Test_Model.sys_distribution();
                    if (dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    if (dt.Rows[n]["userid"].ToString() != "")
                    {
                        model.userid = int.Parse(dt.Rows[n]["userid"].ToString());
                    }
                    model.receiveName = dt.Rows[n]["receiveName"].ToString();
                    model.postAddress = dt.Rows[n]["postAddress"].ToString();
                    model.province = dt.Rows[n]["province"].ToString();
                    model.city = dt.Rows[n]["city"].ToString();
                    model.telephone = dt.Rows[n]["telephone"].ToString();
                    model.phone = dt.Rows[n]["phone"].ToString();
                    model.zipCode = dt.Rows[n]["zipCode"].ToString();
                    if (dt.Rows[n]["addtime"].ToString() != "")
                    {
                        model.addtime = DateTime.Parse(dt.Rows[n]["addtime"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// ��������б�
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        #endregion  Method
    }
}

