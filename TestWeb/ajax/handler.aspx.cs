using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

/// <summary>
/// 常用操作
/// </summary>
public partial class ajax_handler : BasePage.FrontAjax
{
    private string _operType = string.Empty;
    private string _response = string.Empty;
    private Test_BUL.sys_Common common = new Test_BUL.sys_Common();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!CheckAdminLogin())//是否是登陆后操作
            Response.End();

        Server.ScriptTimeout = 8;//脚本过期时间
        this._operType = f("oper");
        switch (this._operType)
        {
            case "loadmenu":
                LoadMenu();//admin.aspx
                break;
            case "updateOrder":
                UpdateOrder();//Manage_Menu.aspx
                break;
            case "getcity":
                GetCity();//Add_Address.aspx
                break;           
            default:
                DefaultResponse();
                break;
        }

        Response.Write(this._response);
    }

    #region 获取用户菜单
    /// <summary>
    /// 获取菜单HTML 
    /// </summary>
    private void LoadMenu()
    {
        //重新获取用户权限页面id集合，并写入缓存
        DataSet SysAdminDS = common.GetList(" select pageId from tb_sys_role where id=" + adminGetRoleId);
        Tools.CacheUtil.InsertCach(Test_BUL.sysParam.CachePageIdDs, (object)SysAdminDS, Test_BUL.sysParam.CachePageIdDsTimes, 2);

        string FileItems = SysAdminDS.Tables[0].Rows[0]["pageId"].ToString();//1,2,3,4,5,6,7,8,9...
        if (string.IsNullOrEmpty(FileItems))
            return;

        //获取所有系统菜单
        DataSet ds = common.GetList(" select id,menuName,imgUrl from tb_sys_sysmenu order by menuOrder asc ");
        if (Tools.Validator.CheckDataSet(ds, 0))
        {
            Test_BUL.sys_sysmenu bulMenu = new Test_BUL.sys_sysmenu();
            _response = bulMenu.GetSystemMenu(ds, FileItems);
        }
    }
    #endregion

    #region 更新菜单排序
    private void UpdateOrder()
    {
        string str = f("OrderString") != null ? f("OrderString") : "";
        if (str != "" && str.Trim().Length > 0)
        {
            string[] upArrry = str.Substring(0, str.LastIndexOf("|")).Split('|');
            int count = upArrry.Length;
            string[] childArry;
            List<String> list = new List<string>();
            for (int i = 0; i < count; i++)
            {
                childArry = upArrry[i].ToString().Split(',');
                list.Add(" update tb_sys_sysmenu set menuOrder=" + childArry[0].ToString() + " where id=" + childArry[1].ToString());
            }
            if (common.ExecuteManySqlTran(list))
                _response = "100";
            else
                _response = "81";
        }
        else
            _response = "81";//网络传输错误
    }
    #endregion

    #region 获取城市
    private void GetCity()
    {
        string domainid = f("domainid");
        if (!string.IsNullOrEmpty(domainid) && Tools.Validator.IsPositiveInt(domainid))
        {
            string strSQL = " select CityCode, CityName from tb_sys_city where DomainID=" + domainid.Trim();
            DataSet ds = common.GetList(strSQL);
            if (Tools.Validator.CheckDataSet(ds, 0))
            {
                StringBuilder strb = new StringBuilder("");
                int _count = ds.Tables[0].Rows.Count;
                if (f("gettypecity") == "address")
                {
                    for (int i = 0; i < _count; i++)
                        strb.Append(" <option value=\"" + ds.Tables[0].Rows[i]["CityName"].ToString() + "\">"
                            + ds.Tables[0].Rows[i]["CityName"].ToString() + "</option> ");
                }
                else if (f("gettypecity") == "weather")
                    for (int j = 0; j < _count; j++)
                        strb.Append(" <option value=\"" + ds.Tables[0].Rows[j]["CityCode"].ToString() + "\">"
                        + ds.Tables[0].Rows[j]["CityName"].ToString() + "</option> ");

                _response = strb.ToString();
            }
        }
    }
    #endregion

    private void DefaultResponse()
    {
        this._response = "未知操作";
    }
}
