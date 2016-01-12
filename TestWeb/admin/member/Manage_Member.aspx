<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage_Member.aspx.cs" Inherits="Manage_Member" %>

<%@ Register Assembly="CCControl" Namespace="CCControl" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>会员信息管理</title>
    <link href="../../Css/Page.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">会员管理</a> > <a href="#">会员信息管理</a>
        </div>
        <div id="content">
            <table border="0" cellspacing="1" cellpadding="3" class="table">
                <tr>
                    <th colspan="2">
                        会员查询
                    </th>
                </tr>
                <tr>
                    <td align="right" class="td1" width="10%">
                        会员昵称：
                    </td>
                    <td>
                        <input runat="server" type="text" class="input" id="txtUserName" maxlength="10" />
                        <input type="button" class="button" id="btnSend" value="提交查询" onclick="SearchMenu();" />
                    </td>                    
                </tr>
            </table>
            <table border="0" cellpadding="3" cellspacing="1" class="table">
                <tr>
                    <th colspan="11">
                        会员信息列表
                    </th>
                </tr>
                <tr align="center" class="head">
                    <td>
                        序号
                    </td>
                    <td>
                        会员昵称
                    </td>
                    <td>
                        真实姓名
                    </td>
                    <td>
                        当前积分
                    </td>
                    <td>
                        总积分
                    </td>
                    <td>
                        性别
                    </td>
                    <td>
                        所在省市
                    </td>                    
                    <td>
                        企业用户
                    </td>
                    <td>
                         手机号码
                    </td>
                     <%--<td>
                         联系地址
                    </td>
                    <td>
                         部门
                    </td>
                    <td>
                         职位
                    </td>
                    <td>
                         税务登记号
                    </td>--%>
                    <td>
                         添加时间
                    </td>
                    <td>
                        操作
                    </td>
                </tr>
                <asp:Repeater runat="server" ID="rpt_Mod" onitemcommand="rpt_Mod_ItemCommand">
                    <ItemTemplate>
                        <tr class=<%#(Container.ItemIndex%2==0)?"\"trnull\"":"\"tr1\""%> align="center">
                            <td>
                                <%#Eval("NoLi")%>
                            </td>
                            <td>
                                <%#Eval("userName")%>
                            </td>
                            <td>
                                <%#Eval("trueName")%>
                            </td>
                            <td>
                                <%#Eval("currentScore")%>
                            </td>
                            <td>
                                <%#Eval("totalScore")%>
                            </td>
                            <td>
                                <%#Eval("sex").ToString() == "True" ? "男" : "女" %>
                            </td>
                            <td>
                                <%#Eval("province")%><%#Eval("city")%>
                            </td>                            
                            <td>
                                <%#Eval("isBusiness").ToString() == "True" ? "是" : "<b style=\"color:#666;\">否</b>"%>
                            </td>
                            <td>
                                <%# string.IsNullOrEmpty(Eval("phone").ToString()) ? "暂无" : Eval("phone") %>
                            </td>
                           <%--<td>
                                <%#Eval("address")%>
                            </td>
                           <td>
                                <%#Eval("department")%>
                            </td>
                            <td>
                                <%#Eval("position")%>
                            </td>
                            <td>
                                <%#Eval("registNumber")%>
                            </td>--%>
                            <td>
                                <%# Convert.ToDateTime(Eval("addTime").ToString()).ToString("yyyy-MM-dd")%>
                            </td>
                            <td>
                                <cc1:CCHyperLink ID="CCHyperLink1" runat="server" Text="修改" LevelPower="M7" NavigateUrl='<%#string.Format("Edit_Member.aspx?id={0}&pageIndex={1}",Eval("ID"),CurrentIndex.ToString())%>' CssClass="rpt_pro_a">
                                </cc1:CCHyperLink>
                                <%--<a href="Edit_Member.aspx?id=<%#Eval("ID") %>&pageIndex=<%=CurrentIndex %>;" class="rpt_pro_a">修改</a>--%>
                                <cc1:CCLinkButton runat="server" CssClass="LinkButton_sty" ID="lblDelete" CommandName="del"  OnClientClick="return confirm('确定要删除吗?')">删除</cc1:CCLinkButton>
                                <asp:HiddenField ID="hfGetId" Value='<%#Eval("ID") %>' runat="server" />                                
                            </td>
                        </tr>
                    </ItemTemplate>
                </asp:Repeater>
            </table>
             <div class="content_page" id="PageBar"><%=HtmlPageBar %></div>
        </div>
    </div>
    </form>
    <script src="../../js/tools.js" type="text/javascript"></script>
    <script type="text/javascript">
        window.onload=function(){
            var serstr='<%=name %>';
            if(serstr!=""){
                document.getElementById("txtUserName").value=serstr;
            }
        }
    
        function SearchMenu(){
            var srt=document.getElementById("txtUserName").value;    
            if(trim(srt)==""){
                location.href="Manage_Member.aspx";
            }else{
                location.href="Manage_Member.aspx?name="+trim(srt);
            }
        }      
    </script>
</body>
</html>
