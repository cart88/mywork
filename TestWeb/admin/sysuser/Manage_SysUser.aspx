<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage_SysUser.aspx.cs" Inherits="admin_sysuser_Manage_SysUser" %>

<%@ Register Assembly="CCControl" Namespace="CCControl" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>系统用户管理</title>
    <link href="../../Css/Page.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">系统用户管理</a>
        </div>
        <div id="content">            
            <table border="0" cellpadding="3" cellspacing="1" class="table">
                <tr>
                    <th colspan="9">
                        系统模块列表
                    </th>
                </tr>
                <tr align="center" class="head">
                    <td>
                        序号
                    </td>
                    <td>
                        账号
                    </td>
                    <td>
                        行政级别
                    </td>
                    <td>
                        手机号码
                    </td>
                    <td>
                        性别
                    </td>
                    <td>
                        登录时间
                    </td>
                    <td>
                        账号状态
                    </td>
                    <td>
                        所属角色
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
                                <%#Eval("count")%>
                            </td>
                            <td>
                                <%#Eval("PowerLeave")%>
                            </td>
                            <td>
                                <%#Eval("telephone")%>
                            </td>
                            <td>
                                <%# Eval("sex").ToString() == "True" ? "男" : "女"%>
                            </td>
                            <td>
                                <%#Eval("loginTime")%>
                            </td>
                            <td>
                                <%# Eval("AccountState").ToString() == "20" ? "<font style=\"color:#CA0000;text-decoration:line-through;\">冻结</font>" : "正常"%>
                            </td>
                            <td>
                                <%#Eval("roleName")%>
                            </td>
                            <td>
                                <cc1:CCHyperLink ID="CCHyperLink1" runat="server" Text="修改" NavigateUrl='<%#string.Format("Edit_SysUser.aspx?id={0}",Eval("ID"))%>' CssClass="rpt_pro_a"></cc1:CCHyperLink>
                                <cc1:CCLinkButton runat="server" Visible='<%# !CehckState(Eval("AccountState")) %>' CssClass="freeze" ID="lblfreeze" CommandName="freeze" OnClientClick="return confirm('确定要冻结吗?');">冻结</cc1:CCLinkButton>
                                <cc1:CCLinkButton runat="server" Visible='<%# CehckState(Eval("AccountState")) %>' CssClass="LinkButton_sty_dj" ID="lblopen" CommandName="open"  OnClientClick="return confirm('确定要启用吗?');">启用</cc1:CCLinkButton>                                
                                <asp:LinkButton runat="server" CssClass="LinkButton_sty" ID="lblDelete" CommandName="del"  OnClientClick="return confirm('确定要删除吗?');">删除</asp:LinkButton>
                                <asp:HiddenField ID="hfGetId" Value='<%#Eval("id") %>' runat="server" />
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
        </div>
    </div>
    </form>
</body>
</html>