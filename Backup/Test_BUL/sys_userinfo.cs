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
using System.Data;
using System.Collections.Generic;
namespace Test_BUL
{
	/// <summary>
    /// sys_userinfo
	/// </summary>
	public partial class sys_userinfo
	{  
        private Test_DAL.sys_userinfo dal = new Test_DAL.sys_userinfo();
		public sys_userinfo()
		{}
		#region  Method

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string userName)
		{
			return dal.Exists(userName);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int  Add(Test_Model.sys_userinfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
        public bool Update(Test_Model.sys_userinfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			return dal.Delete(ID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			return dal.DeleteList(IDlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
        public Test_Model.sys_userinfo GetModel(int ID)
		{
			
			return dal.GetModel(ID);
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
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
        public List<Test_Model.sys_userinfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
        public List<Test_Model.sys_userinfo> DataTableToList(DataTable dt)
		{
            List<Test_Model.sys_userinfo> modelList = new List<Test_Model.sys_userinfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
                Test_Model.sys_userinfo model;
				for (int n = 0; n < rowsCount; n++)
				{
                    model = new Test_Model.sys_userinfo();
					if(dt.Rows[n]["ID"].ToString()!="")
					{
						model.ID=int.Parse(dt.Rows[n]["ID"].ToString());
					}
					model.userName=dt.Rows[n]["userName"].ToString();
					model.password=dt.Rows[n]["password"].ToString();
					model.trueName=dt.Rows[n]["trueName"].ToString();
					if(dt.Rows[n]["currentScore"].ToString()!="")
					{
						model.currentScore=int.Parse(dt.Rows[n]["currentScore"].ToString());
					}
					if(dt.Rows[n]["totalScore"].ToString()!="")
					{
						model.totalScore=int.Parse(dt.Rows[n]["totalScore"].ToString());
					}
					if(dt.Rows[n]["sex"].ToString()!="")
					{
						if((dt.Rows[n]["sex"].ToString()=="1")||(dt.Rows[n]["sex"].ToString().ToLower()=="true"))
						{
						model.sex=true;
						}
						else
						{
							model.sex=false;
						}
					}
					model.province=dt.Rows[n]["province"].ToString();
					model.city=dt.Rows[n]["city"].ToString();
					if(dt.Rows[n]["isBusiness"].ToString()!="")
					{
						if((dt.Rows[n]["isBusiness"].ToString()=="1")||(dt.Rows[n]["isBusiness"].ToString().ToLower()=="true"))
						{
						model.isBusiness=true;
						}
						else
						{
							model.isBusiness=false;
						}
					}
					model.registNumber=dt.Rows[n]["registNumber"].ToString();
					model.department=dt.Rows[n]["department"].ToString();
					model.position=dt.Rows[n]["position"].ToString();
					model.phone=dt.Rows[n]["phone"].ToString();
					model.address=dt.Rows[n]["address"].ToString();
					if(dt.Rows[n]["addTime"].ToString()!="")
					{
						model.addTime=DateTime.Parse(dt.Rows[n]["addTime"].ToString());
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

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}