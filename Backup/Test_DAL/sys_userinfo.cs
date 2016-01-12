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
using System.Text;
using System.Data.SqlClient;
//Please add references
using Test_DBUtility;

namespace Test_DAL
{
    /// <summary>
    /// 数据访问类:sys_userinfo
    /// </summary>
    public partial class sys_userinfo
    {
        public readonly string connectionString = SqlHelper.LocalSqlServer;
        public sys_userinfo()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string userName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select [userName] from tb_sys_userinfo");
            strSql.Append(" where [userName]='" + userName + "'");
            SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.NVarChar,4)
            };
            parameters[0].Value = userName;

            return SqlHelper.ExistsRecord(connectionString, strSql.ToString(), parameters);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(Test_Model.sys_userinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_sys_userinfo(");
            strSql.Append("userName,password,trueName,currentScore,totalScore,sex,province,city,isBusiness,registNumber,department,position,phone,address,addTime)");
            strSql.Append(" values (");
            strSql.Append("@userName,@password,@trueName,@currentScore,@totalScore,@sex,@province,@city,@isBusiness,@registNumber,@department,@position,@phone,@address,@addTime)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.NVarChar,10),
					new SqlParameter("@password", SqlDbType.NVarChar,40),
					new SqlParameter("@trueName", SqlDbType.NVarChar,15),
					new SqlParameter("@currentScore", SqlDbType.Int,4),
					new SqlParameter("@totalScore", SqlDbType.Int,4),
					new SqlParameter("@sex", SqlDbType.Bit,1),
					new SqlParameter("@province", SqlDbType.NVarChar,10),
					new SqlParameter("@city", SqlDbType.NVarChar,10),
					new SqlParameter("@isBusiness", SqlDbType.Bit,1),
					new SqlParameter("@registNumber", SqlDbType.NVarChar,18),
					new SqlParameter("@department", SqlDbType.NVarChar,10),
					new SqlParameter("@position", SqlDbType.NVarChar,10),
					new SqlParameter("@phone", SqlDbType.NVarChar,11),
					new SqlParameter("@address", SqlDbType.NVarChar,100),
					new SqlParameter("@addTime", SqlDbType.DateTime)};
            parameters[0].Value = model.userName;
            parameters[1].Value = model.password;
            parameters[2].Value = model.trueName;
            parameters[3].Value = model.currentScore;
            parameters[4].Value = model.totalScore;
            parameters[5].Value = model.sex;
            parameters[6].Value = model.province;
            parameters[7].Value = model.city;
            parameters[8].Value = model.isBusiness;
            parameters[9].Value = model.registNumber;
            parameters[10].Value = model.department;
            parameters[11].Value = model.position;
            parameters[12].Value = model.phone;
            parameters[13].Value = model.address;
            parameters[14].Value = model.addTime;

            object obj = SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Test_Model.sys_userinfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_sys_userinfo set ");
            strSql.Append("userName=@userName,");
            strSql.Append("trueName=@trueName,");
            strSql.Append("currentScore=@currentScore,");
            strSql.Append("totalScore=@totalScore,");
            strSql.Append("sex=@sex,");
            strSql.Append("province=@province,");
            strSql.Append("city=@city,");
            strSql.Append("isBusiness=@isBusiness,");
            strSql.Append("registNumber=@registNumber,");
            strSql.Append("department=@department,");
            strSql.Append("position=@position,");
            strSql.Append("phone=@phone,");
            strSql.Append("address=@address");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@userName", SqlDbType.NVarChar,10),					
					new SqlParameter("@trueName", SqlDbType.NVarChar,15),
					new SqlParameter("@currentScore", SqlDbType.Int,4),
					new SqlParameter("@totalScore", SqlDbType.Int,4),
					new SqlParameter("@sex", SqlDbType.Bit,1),
					new SqlParameter("@province", SqlDbType.NVarChar,10),
					new SqlParameter("@city", SqlDbType.NVarChar,10),
					new SqlParameter("@isBusiness", SqlDbType.Bit,1),
					new SqlParameter("@registNumber", SqlDbType.NVarChar,18),
					new SqlParameter("@department", SqlDbType.NVarChar,10),
					new SqlParameter("@position", SqlDbType.NVarChar,10),
					new SqlParameter("@phone", SqlDbType.NVarChar,11),
					new SqlParameter("@address", SqlDbType.NVarChar,100),					
					new SqlParameter("@ID", SqlDbType.Int,4)};
            parameters[0].Value = model.userName;
            parameters[1].Value = model.trueName;
            parameters[2].Value = model.currentScore;
            parameters[3].Value = model.totalScore;
            parameters[4].Value = model.sex;
            parameters[5].Value = model.province;
            parameters[6].Value = model.city;
            parameters[7].Value = model.isBusiness;
            parameters[8].Value = model.registNumber;
            parameters[9].Value = model.department;
            parameters[10].Value = model.position;
            parameters[11].Value = model.phone;
            parameters[12].Value = model.address;
            parameters[13].Value = model.ID;

            int rows = SqlHelper.ExecuteSql(connectionString, strSql.ToString(), parameters);
            return rows > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_sys_userinfo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
                     new SqlParameter("@ID", SqlDbType.Int,4)
             };
            parameters[0].Value = ID;

            int rows = SqlHelper.ExecuteSql(connectionString, strSql.ToString());
            return rows > 0;
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string IDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_sys_userinfo ");
            strSql.Append(" where ID in (" + IDlist + ")  ");
            int rows = SqlHelper.ExecuteSql(connectionString, strSql.ToString());

            return rows > 0;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Test_Model.sys_userinfo GetModel(int ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 ID,userName,password,trueName,currentScore,totalScore,sex,province,city,isBusiness,registNumber,department,position,phone,address,addTime from tb_sys_userinfo ");
            strSql.Append(" where ID=@ID");
            SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
            };
            parameters[0].Value = ID;

            Test_Model.sys_userinfo model = new Test_Model.sys_userinfo();
            DataSet ds = SqlHelper.ExecuteDataSet(connectionString, strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["ID"].ToString() != "")
                {
                    model.ID = int.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["userName"] != null)
                {
                    model.userName = ds.Tables[0].Rows[0]["userName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["password"] != null)
                {
                    model.password = ds.Tables[0].Rows[0]["password"].ToString();
                }
                if (ds.Tables[0].Rows[0]["trueName"] != null)
                {
                    model.trueName = ds.Tables[0].Rows[0]["trueName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["currentScore"].ToString() != "")
                {
                    model.currentScore = int.Parse(ds.Tables[0].Rows[0]["currentScore"].ToString());
                }
                if (ds.Tables[0].Rows[0]["totalScore"].ToString() != "")
                {
                    model.totalScore = int.Parse(ds.Tables[0].Rows[0]["totalScore"].ToString());
                }
                if (ds.Tables[0].Rows[0]["sex"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["sex"].ToString() == "1") || (ds.Tables[0].Rows[0]["sex"].ToString().ToLower() == "true"))
                    {
                        model.sex = true;
                    }
                    else
                    {
                        model.sex = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["province"] != null)
                {
                    model.province = ds.Tables[0].Rows[0]["province"].ToString();
                }
                if (ds.Tables[0].Rows[0]["city"] != null)
                {
                    model.city = ds.Tables[0].Rows[0]["city"].ToString();
                }
                if (ds.Tables[0].Rows[0]["isBusiness"].ToString() != "")
                {
                    if ((ds.Tables[0].Rows[0]["isBusiness"].ToString() == "1") || (ds.Tables[0].Rows[0]["isBusiness"].ToString().ToLower() == "true"))
                    {
                        model.isBusiness = true;
                    }
                    else
                    {
                        model.isBusiness = false;
                    }
                }
                if (ds.Tables[0].Rows[0]["registNumber"] != null)
                {
                    model.registNumber = ds.Tables[0].Rows[0]["registNumber"].ToString();
                }
                if (ds.Tables[0].Rows[0]["department"] != null)
                {
                    model.department = ds.Tables[0].Rows[0]["department"].ToString();
                }
                if (ds.Tables[0].Rows[0]["position"] != null)
                {
                    model.position = ds.Tables[0].Rows[0]["position"].ToString();
                }
                if (ds.Tables[0].Rows[0]["phone"] != null)
                {
                    model.phone = ds.Tables[0].Rows[0]["phone"].ToString();
                }
                if (ds.Tables[0].Rows[0]["address"] != null)
                {
                    model.address = ds.Tables[0].Rows[0]["address"].ToString();
                }
                if (ds.Tables[0].Rows[0]["addTime"].ToString() != "")
                {
                    model.addTime = DateTime.Parse(ds.Tables[0].Rows[0]["addTime"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ID,userName,password,trueName,currentScore,totalScore,sex,province,city,isBusiness,registNumber,department,position,phone,address,addTime ");
            strSql.Append(" FROM tb_sys_userinfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SqlHelper.ExecuteDataSet(connectionString, strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" ID,userName,password,trueName,currentScore,totalScore,sex,province,city,isBusiness,registNumber,department,position,phone,address,addTime ");
            strSql.Append(" FROM tb_sys_userinfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return SqlHelper.ExecuteDataSet(connectionString, strSql.ToString());
        }

        #endregion  Method
    }
}