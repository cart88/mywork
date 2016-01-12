/******************************************************************
**-----------------------------------------------------------------
** Copyright (c) 2013 每天进步一点点
** Name: Manage_Member
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
using System.Web.UI.WebControls;

public partial class Manage_Member : BasePage.PageUI
{
    public string HtmlPageBar;
    public Test_BUL.sys_Common common = new Test_BUL.sys_Common();
    public Test_BUL.sys_userinfo bllUser = new Test_BUL.sys_userinfo();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }
    }

    #region 获取request对象
    /// <summary>
    /// 获取当前页码
    /// </summary>
    public int CurrentIndex
    {
        get
        {
            return string.IsNullOrEmpty(q("p")) ? 1 : Tools.StringHelp.GetInt(q("p"));//注意，不为空时是1
        }
    }

    /// <summary>
    /// 查询该菜单下的页面文件
    /// </summary>
    public string name
    {
        get
        {
            return string.IsNullOrEmpty(q("name")) ? "" : Tools.StringHelp.GetString(q("name"));//注意，不为空时是-1
        }
    }
    #endregion

    /// <summary>
    /// 获取数据
    /// </summary>
    /// <returns></returns>
    public DataSet GetModelList()
    {
        string fileds = "ID,userName,trueName ,currentScore , totalScore,sex ,province,city,isBusiness,registNumber,department,position,phone,address,addTime";
        DataSet ds = common.Up2PageInfo("tb_sys_userinfo", "userName,addTime", fileds, (name != "" ? "userName='" + name + "'" : ""), 10, CurrentIndex, 2);
        if (Tools.Validator.CheckDataSet(ds))
            return ds;
        else
            return null;
    }

    /// <summary>
    /// 绑定页面数据    
    /// </summary>
    public void BindData()
    {
        DataSet ds = GetModelList();
        if (Tools.Validator.CheckDataSet(ds, 1))
        {
            int row = ds.Tables[1].Rows.Count;
            ds.Tables[1].Columns.Add("NoLi");
            for (int i = 0; i < row; i++)
            {
                ds.Tables[1].Rows[i]["NoLi"] = (i + 1).ToString();
            }
            this.rpt_Mod.DataSource = ds.Tables[1];
            this.rpt_Mod.DataBind();

            //生成分页控件
            if (ds.Tables[2] != null || ds.Tables[2].Rows.Count > 0)
            {
                int pageCount = Tools.StringHelp.GetInt(ds.Tables[2].Rows[0]["pageCount"]);
                int recordCount = Tools.StringHelp.GetInt(ds.Tables[2].Rows[0]["recordCount"]);
                HtmlPageBar = common.CreatePageBar(10, CurrentIndex, pageCount, recordCount, "Manage_Member.aspx", GetRequestQuery());
            }
        }
    }

    /// <summary>
    /// 删除记录
    /// </summary>
    protected void rpt_Mod_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            HiddenField hfGetId = (HiddenField)e.Item.FindControl("hfGetId");
            int id = Tools.StringHelp.GetInt(hfGetId.Value);
            try
            {
                if (common.Delete("tb_sys_userinfo", id))
                {
                    BindData();
                    foreach (RepeaterItem rpItem in rpt_Mod.Items)
                    {
                        LinkButton lbbDel = (LinkButton)rpItem.FindControl("lblDelete");
                        lbbDel.Attributes.Add("onclick", "if(!confirm('确定删除？')) return false;");
                    }
                }
            }
            catch (Exception ex)
            {
                FinalMessage("删除失败" + ex.Message, "Manage_Member.aspx", 1);
            }
        }
    }
}
