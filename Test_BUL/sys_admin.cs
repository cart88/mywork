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

using System.Data;
using System;

namespace Test_BUL
{
    /// <summary>
    /// sys_admin
    /// </summary>
    public partial class sys_admin
    {
        private readonly Test_DAL.sys_admin dal = new Test_DAL.sys_admin();
        public sys_admin()
        { }
        #region  Method

        /// <summary>
        /// ����һ������
        /// </summary>
        public int Add(Test_Model.sys_admin model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// ����һ������
        /// </summary>
        public bool Update(Test_Model.sys_admin model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// ���µ�¼��Ϣ
        /// </summary>
        /// <param name="count">�û���</param>
        /// <param name="ip">ip</param>
        /// <param name="datetime">��¼ʱ��</param>
        /// <returns></returns>
        public bool UpdateLogin(string count, string ip, DateTime datetime)
        {
            return dal.UpdateLogin(count, ip, datetime);
        }

        /// <summary>
        /// ���¹���Ա����
        /// </summary>
        /// <param name="userid"0>ϵͳ�û�id</param>
        /// <param name="oldpassword">�û�ԭʼ����</param>
        /// <param name="password">�û���ǰ����</param>
        public bool UpdatePwd(int userid, string oldpassword, string password)
        {
            return dal.UpdatePwd(userid, oldpassword, password);
        }

        /// <summary>
        /// �õ�һ������ʵ��
        /// </summary>
        public Test_Model.sys_admin GetModel(int id)
        {
            return dal.GetModel(id);
        }

        /// <summary>
        /// ��ȡ���ݼ�
        /// </summary>
        /// <returns></returns>
        public DataSet GetList()
        {
            string strSql = @"select tb_sys_admin.id,[count],telephone,loginTime,sex,AccountState,PowerLeave,tb_sys_role.roleName from tb_sys_admin
                                left join tb_sys_role on tb_sys_role.id=tb_sys_admin.roleid ";
            Test_BUL.sys_Common common = new Test_BUL.sys_Common();

            return common.GetList(strSql);
        }
        #endregion  Method
    }
}

