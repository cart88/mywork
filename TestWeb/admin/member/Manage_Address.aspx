<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage_Address.aspx.cs" Inherits="admin_member_Manage_Address" %>

<%@ Register Assembly="CCControl" Namespace="CCControl" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>系统页面管理</title>
    <link href="../../Css/Page.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">会员管理</a> > <a href="#">配送地址管理</a>
        </div>
        <div id="content">            
            <table border="0" cellpadding="3" cellspacing="1" class="table">
                <tr>
                    <th colspan="10">
                        配送地址列表
                    </th>
                </tr>
                <tr align="center" class="head">
                    <td>
                        序号
                    </td>
                    <td>
                        收货人
                    </td>
                    <td>
                        收货地址
                    </td>
                    <td>
                        所在省
                    </td>
                    <td>
                        所在市
                    </td> 
                    <td>
                        手机号码
                    </td>
                    <td>
                        固定电话
                    </td>  
                    <td>
                        邮政编码
                    </td>         
                    <td>
                        添加时间                    </td>
                    <td>
                        操作
                    </td>
                </tr>
                <asp:Repeater runat="server" ID="rpt_Address" OnItemCommand="rpt_Address_ItemCommand">
                    <ItemTemplate>
                        <tr class=<%#(Container.ItemIndex%2==0)?"\"trnull\"":"\"tr1\""%> align="center">
                            <td>
                                <%#Eval("NoLi")%>
                            </td>
                            <td>
                                <%#Eval("receiveName")%>
                            </td>
                            <td>
                                <%#Eval("postAddress")%>
                            </td>
                            <td>
                                <%# Eval("province") %>
                            </td>
                            <td>
                                <%#Eval("city")%>
                            </td>
                            <td>
                                <%#Eval("telephone")%>
                            </td>
                            <td>
                                <%#Eval("phone")%>
                            </td>
                            <td>
                                <%#Eval("zipCode")%>
                            </td>
                            <td>
                                <%#Eval("addtime")%>
                            </td>
                            <td>
                                <cc1:CCHyperLink ID="CCHyperLink1" runat="server" Text="修改" NavigateUrl='<%#string.Format("Edit_Address.aspx?id={0}&pageIndex={1}",Eval("ID"),CurrentIndex.ToString())%>' CssClass="rpt_pro_a">
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
    </body>
</html>