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
using System.Data;
using System.Collections.Generic;

namespace Test_BUL
{
	/// <summary>
    /// sys_sysfiles
	/// </summary>
	public partial class sys_sysfiles
	{
        private readonly Test_DAL.sys_sysfiles dal = new Test_DAL.sys_sysfiles();
		public sys_sysfiles()
		{}
		#region  Method

		/// <summary>
		/// ����һ������
		/// </summary>
		public int  Add(Test_Model.sys_sysfiles model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// ����һ������
		/// </summary>
		public bool Update(Test_Model.sys_sysfiles model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// �õ�һ������ʵ��
		/// </summary>
		public Test_Model.sys_sysfiles GetModel(int id)
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
		/// ��������б�
		/// </summary>
		public List<Test_Model.sys_sysfiles> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// ��������б�
		/// </summary>
		public List<Test_Model.sys_sysfiles> DataTableToList(DataTable dt)
		{
			List<Test_Model.sys_sysfiles> modelList = new List<Test_Model.sys_sysfiles>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Test_Model.sys_sysfiles model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Test_Model.sys_sysfiles();
					if(dt.Rows[n]["id"].ToString()!="")
					{
						model.id=int.Parse(dt.Rows[n]["id"].ToString());
					}
					model.filesUrl=dt.Rows[n]["filesUrl"].ToString();
					model.describe=dt.Rows[n]["describe"].ToString();
					if(dt.Rows[n]["addTime"].ToString()!="")
					{
						model.addTime=DateTime.Parse(dt.Rows[n]["addTime"].ToString());
					}
					if(dt.Rows[n]["addUserId"].ToString()!="")
					{
						model.addUserId=int.Parse(dt.Rows[n]["addUserId"].ToString());
					}
					model.addUser=dt.Rows[n]["addUser"].ToString();
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

