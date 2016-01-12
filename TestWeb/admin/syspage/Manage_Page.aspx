<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage_Page.aspx.cs" Inherits="admin_syspage_Manage_Page" %>

<%@ Register Assembly="CCControl" Namespace="CCControl" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>系统页面管理</title>
    <link href="../../Css/Page.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">页面文件管理</a> > <a href="#">文件模块管理</a>
        </div>
        <div id="content">
            <table border="0" cellspacing="1" cellpadding="3" class="table">
                <tr>
                    <th colspan="3">
                        会员查询
                    </th>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        所属菜单：
                    </td>
                    <td width="15%">
                        <asp:DropDownList runat="server" ID="ddlParentMenu"  Width="148px" />
                    </td>
                    <td  align="left" class="td1">
                        <input type="button" class="button" id="btnSend" value="提交查询" onclick="SearchMenu();" />
                    </td>
                </tr>
            </table>
            <table border="0" cellpadding="3" cellspacing="1" class="table">
                <tr>
                    <th colspan="8">
                        系统模块列表
                    </th>
                </tr>
                <tr align="center" class="head">
                    <td>
                        序号
                    </td>
                    <td>
                        名称
                    </td>
                    <td>
                        链接地址
                    </td>
                    <td>左侧显示</td>
                    <td>
                        所属菜单
                    </td>
                    <td>
                        添加时间
                    </td>
                    <td>
                        添加人
                    </td>
                    <td>
                        操作
                    </td>
                </tr>
                <asp:Repeater runat="server" ID="rpt_Mod" OnItemCommand="rpt_Mod_ItemCommand">
                    <ItemTemplate>
                        <tr class=<%#(Container.ItemIndex%2==0)?"\"trnull\"":"\"tr1\""%> align="center">
                            <td>
                                <%#Eval("NoLi")%>
                            </td>
                            <td>
                                <%#Eval("fielsName")%>
                            </td>
                            <td>
                                <%#Eval("filesUrl")%>
                            </td>
                            <td>
                                <%# Eval("showLeft").ToString() == "True" ? "<b>是</b>" : "<b style=\"color:#999;\">否</b>"%>
                            </td>
                            <td>
                                <%#Eval("menuName")%>
                            </td>
                            <td>
                                <%#Eval("addTime")%>
                            </td>
                            <td>
                                <%#Eval("addUser")%>
                            </td>
                            <td>
                                <cc1:CCHyperLink ID="CCHyperLink1" runat="server" Text="修改" NavigateUrl='<%#string.Format("Edit_Page.aspx?FilseId={0}&pageIndex={1}",Eval("ID"),CurrentIndex.ToString())%>' CssClass="rpt_pro_a">
                                </cc1:CCHyperLink>
                                <asp:LinkButton runat="server" CssClass="LinkButton_sty" ID="lblDelete" CommandName="del"  OnClientClick="return confirm('确定要删除吗?')">删除</asp:LinkButton>
                                <asp:HiddenField ID="hfGetId" Value='<%#Eval("id") %>' runat="server" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
             <div class="content_page" id="PageBar"><%=HtmlPageBar %></div>
        </div>
    </div>
    </form>
    
    <script src="../../js/jquery-1.6.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $(function(){
            var dv='<%=ddlValue %>';
            $("#ddlParentMenu").val(dv);
        })
        function SearchMenu()
        {
            if($("#ddlParentMenu").val()=="-1"){
                location.href="Manage_Page.aspx?menuId=-1";
            }else{
                location.href="Manage_Page.aspx?menuId="+$("#ddlParentMenu").val();
            }
        }
    </script>
</body>
</html>
