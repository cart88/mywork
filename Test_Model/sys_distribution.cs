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
namespace Test_Model
{
    /// <summary>
    /// sys_distribution:ʵ����
    /// </summary>
    [Serializable]
    public partial class sys_distribution
    {
        public sys_distribution()
        { }
        #region Model
        private int _id;
        private int? _userid;
        private string _receivename;
        private string _postaddress;
        private string _province;
        private string _city;
        private string _telephone;
        private string _phone;
        private string _zipcode;
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
        /// �û�id
        /// </summary>
        public int? userid
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// �ջ�������
        /// </summary>
        public string receiveName
        {
            set { _receivename = value; }
            get { return _receivename; }
        }
        /// <summary>
        /// �ջ��˵�ַ
        /// </summary>
        public string postAddress
        {
            set { _postaddress = value; }
            get { return _postaddress; }
        }
        /// <summary>
        /// ʡ
        /// </summary>
        public string province
        {
            set { _province = value; }
            get { return _province; }
        }
        /// <summary>
        /// ��
        /// </summary>
        public string city
        {
            set { _city = value; }
            get { return _city; }
        }
        /// <summary>
        /// �ֻ�����
        /// </summary>
        public string telephone
        {
            set { _telephone = value; }
            get { return _telephone; }
        }
        /// <summary>
        /// �̶��绰
        /// </summary>
        public string phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// ��������
        /// </summary>
        public string zipCode
        {
            set { _zipcode = value; }
            get { return _zipcode; }
        }
        /// <summary>
        /// ���ʱ��
        /// </summary>
        public DateTime? addtime
        {
            set { _addtime = value; }
            get { return _addtime; }
        }
        #endregion Model
    }
}