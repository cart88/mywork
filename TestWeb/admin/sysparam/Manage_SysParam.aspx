<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage_SysParam.aspx.cs" Inherits="admin_sysparam_Manage_SysParam" %>

<%@ Register Assembly="CCControl" Namespace="CCControl" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>系统参数列表</title>
    <link href="../../Css/Page.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .th_img{width:14px; height:14px; cursor:pointer;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">系统参数列表</a>
        </div>
        <div id="content">        
            <table border="0" cellspacing="1" cellpadding="3" class="table">
                <tr>
                    <th colspan="3">
                        参数查询
                    </th>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        参数关键词：
                    </td>
                    <td width="15%">
                        <input type="text" id="txtKetWord" class="input" />
                    </td>
                    <td  align="left" class="td1">
                        <input type="button" class="button" id="btnSend" value="提交查询" onclick="SearchMenu();" />
                    </td>
                </tr>
            </table>
            <table border="0" cellpadding="3" cellspacing="1" class="table">
                <tr>
                    <th>
                        <img title="新增参数" class="th_img" src="../../images/Page/add.jpg" onclick="javascript:location.href='Add_SysParam.aspx';" />
                    </th>
                    <th colspan="5">
                        系统参数列表
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
                        关键词
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
                                <%#Eval("name")%>
                            </td>
                            <td>
                                <%#Eval("typeTag")%>
                            </td>                            
                            <td>
                                <%#Eval("addTime")%>
                            </td>
                            <td>
                                <%#Eval("addUserName")%>
                            </td>
                            <td>
                                <cc1:CCHyperLink ID="CCHyperLink1" runat="server" Text="修改" NavigateUrl='<%#string.Format("Edit_SysParam.aspx?id={0}&pageIndex={1}",Eval("ID"),CurrentIndex.ToString())%>' CssClass="rpt_pro_a">
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

    <script src="../../js/tools.js" type="text/javascript"></script>
    <script type="text/javascript">
        window.onload=function(){
            var serP='<%=txtValue %>';
            if(trim(serP)!=""){
                document.getElementById("txtKetWord").value=serP;
            }
        }
        
        function SearchMenu(){
            var ser=document.getElementById("txtKetWord").value;
            if(trim(ser)!=""){
                location.href="Manage_SysParam.aspx?txtValue="+ser;
            }else{
                location.href="Manage_SysParam.aspx";
            }
        }
    </script>
</body>
</html>
