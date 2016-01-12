using System;
using System.Data;
using System.Web.UI.WebControls;

public partial class admin_sysparam_Manage_SysParam : BasePage.PageUI
{
    public string txtValue;
    public string HtmlPageBar;
    public Test_BUL.sys_Common common = new Test_BUL.sys_Common();
    public Test_BUL.sys_paramcenter bllparam = new Test_BUL.sys_paramcenter();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            BindData();
        }

        txtValue = SearchValue.ToString();
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
    public string SearchValue
    {
        get
        {
            return string.IsNullOrEmpty(q("txtValue")) ? "" : Tools.StringHelp.FilterSymbolStr(q("txtValue"));
        }
    }
    #endregion

    /// <summary>
    /// 获取数据
    /// </summary>
    /// <returns></returns>
    public DataSet GetModelList()
    {
        string fileds = "id,name,value,typeTag,addUserId,addUserName,addTime ";
        if (Tools.RequestCheck.CheckKeyWord(SearchValue))
            FinalMessage("查找对象含有非法关键词", "Manage_SysParam.aspx", 1);

        DataSet ds = common.Up2PageInfo("tb_sys_paramcenter", "typeTag", fileds, (SearchValue != "" ? "typeTag like '%" + SearchValue.Trim() + "%'" : ""), 10, CurrentIndex);
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
                HtmlPageBar = common.CreatePageBar(20, CurrentIndex, pageCount, recordCount, "Manage_SysParam.aspx", GetRequestQuery());
            }
        }
    }

    /// <summary>
    /// 禁用
    /// </summary>
    protected void rpt_Mod_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "del")
        {
            HiddenField hfGetId = (HiddenField)e.Item.FindControl("hfGetId");//获取隐藏控件的Id,这是每条新闻的对应Id
            int id = Tools.StringHelp.GetInt(hfGetId.Value);
            try
            {
                if (common.Delete("tb_sys_paramcenter", id))
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
                FinalMessage("删除失败" + ex.Message, "Manage_SysParam.aspx", 1);
            }
        }
    }
}
