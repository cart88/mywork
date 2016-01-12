<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage_Role.aspx.cs" Inherits="Manage_Role" %>

<%@ Register Assembly="CCControl" Namespace="CCControl" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>角色列表</title>
    <link href="../../css/Page.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        function DreUrl(pURL)
        {
            location.href=pURL;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">角色管理</a> > 角色列表
        </div>
        <div id="content">
            <table border="0" cellpadding="3" cellspacing="1" class="table">
                <tr>
                    <th colspan="6">
                        角色列表
                    </th>
                </tr>
                <tr align="center" class="head">
                    <td>
                        序号
                    </td>
                    <td>
                        角色名称
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
                <asp:Repeater runat="server" ID="rpt_roleList" OnItemCommand="rpt_roleList_ItemCommand">
                    <ItemTemplate>
                        <tr class=<%#(Container.ItemIndex%2==0)?"\"trnull\"":"\"tr1\""%> align="center">
                            <td>
                                <%#Eval("number")%>
                            </td>
                            <td>
                                <%#Eval("roleName")%>
                            </td>                            
                            <td>
                                <%#Eval("addTime")%>
                            </td>
                            <td>
                                <%#Eval("addUser")%>
                            </td>
                            <td>
                                <cc1:CCHyperLink ID="CCHyperLink1" runat="server" Text="修改" NavigateUrl='<%#string.Format("Edit_Role.aspx?id={0}",Eval("id"))%>' CssClass="rpt_pro_a">
                                </cc1:CCHyperLink>
                                <asp:LinkButton runat="server" CssClass="LinkButton_sty" ID="lblDelete" CommandName="del"
                                    OnClientClick="return confirm('确定要删除吗?')">删除</asp:LinkButton>
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
