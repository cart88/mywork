/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
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
using System.Data;
using System.Collections.Generic;
using System.Text;

namespace Test_BUL
{
    /// <summary>
    /// sys_sysmenu
    /// </summary>
    public partial class sys_sysmenu
    {
        private readonly Test_DAL.sys_sysmenu dal = new Test_DAL.sys_sysmenu();
        public sys_sysmenu()
        { }
        #region  Method

        /// <summary>
        /// 加载用户菜单
        /// </summary>
        /// <param name="ds">系统所有菜单</param>
        /// <param name="FileItems">用户权限页面id集合</param>
        /// <returns></returns>
        public string GetSystemMenu(DataSet ds, string FileItems)
        {
            if (ds == null || string.IsNullOrEmpty(FileItems))
                return "";

            StringBuilder strbu = new StringBuilder("");
            int tempCount = ds.Tables[0].Rows.Count;
            for (int i = 0; i < tempCount; i++)
            {
                Test_BUL.sys_Common common = new sys_Common();
                DataSet tempChildDs = common.GetList(" select * from tb_sys_sysfiles where id in(" + FileItems + ") and showLeft=1 and ClassId=" + ds.Tables[0].Rows[i]["id"].ToString());
                if (sysCheck.CheckDataSet(tempChildDs, 0))
                {
                    strbu.Append(" <dl> ");//start nod
                    strbu.Append(" <dt><span style=\"background-image: url("
                        + ds.Tables[0].Rows[i]["imgUrl"].ToString() + ");\">"
                        + ds.Tables[0].Rows[i]["menuName"].ToString() + "</span></dt> ");
                    strbu.Append(" <dd class=\"hide\"><ul> ");
                    for (int j = 0; j < tempChildDs.Tables[0].Rows.Count; j++)//add Child Node
                    {
                        strbu.Append(" <li><a href=\"./" + tempChildDs.Tables[0].Rows[j]["filesUrl"].ToString()
                            + "\" target=\"main_iframe\" >" + tempChildDs.Tables[0].Rows[j]["fielsName"].ToString() + "</a></li> ");
                    }
                    strbu.Append(" </ul></dd> ");
                    strbu.Append(" </dl> ");//end nod
                }
            }
            return strbu.ToString();
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Test_Model.sys_sysmenu model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Test_Model.sys_sysmenu model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Test_Model.sys_sysmenu GetModel(int id)
        {
            return dal.GetModel(id);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            return dal.GetList(Top, strWhere, filedOrder);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Test_Model.sys_sysmenu> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Test_Model.sys_sysmenu> DataTableToList(DataTable dt)
        {
            List<Test_Model.sys_sysmenu> modelList = new List<Test_Model.sys_sysmenu>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Test_Model.sys_sysmenu model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new Test_Model.sys_sysmenu();
                    if (dt.Rows[n]["id"].ToString() != "")
                    {
                        model.id = int.Parse(dt.Rows[n]["id"].ToString());
                    }
                    model.menuName = dt.Rows[n]["menuName"].ToString();
                    if (dt.Rows[n]["menuOrder"].ToString() != "")
                    {
                        model.menuOrder = int.Parse(dt.Rows[n]["menuOrder"].ToString());
                    }
                    model.imgUrl = dt.Rows[n]["imgUrl"].ToString();
                    model.addName = dt.Rows[n]["addName"].ToString();
                    if (dt.Rows[n]["addTime"].ToString() != "")
                    {
                        model.addTime = DateTime.Parse(dt.Rows[n]["addTime"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        #endregion  Method
    }
}

