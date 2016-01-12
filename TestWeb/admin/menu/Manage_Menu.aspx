<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Manage_Menu.aspx.cs" Inherits="admin_menu_Manage_Menu" %>

<%@ Register Assembly="CCControl" Namespace="CCControl" TagPrefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>系统菜单管理</title>
    <link href="../../css/Page.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .ChagenText{ font-family:Verdana; font-weight:bold; color:Red;}
        .thisUrlImg{vertical-align: middle; width: 16px; height: 16px;}
    </style>        
</head>
<body>
    <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">菜单管理</a> > <a href="#">菜单模块列表</a>
        </div>
        <div id="content">
            <table border="0" cellpadding="3" cellspacing="1" class="table">
                <tr>
                    <th colspan="7">                    
                        菜单模块列表
                    </th>
                </tr>
                <tr align="center" class="head">
                    <td>
                        序号
                    </td>
                    <td>
                        模块名称
                    </td>
                    <td>
                        小图标
                    </td>
                    <td>
                        排序数值
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
                <form id="form1" runat="server">
                <asp:Repeater runat="server" ID="rpt_Menu" OnItemCommand="rpt_Menu_ItemCommand">
                    <ItemTemplate>
                        <tr class=<%#(Container.ItemIndex%2==0)?"\"trnull\"":"\"tr1\""%> align="center">
                            <td>
                                <%#Eval("NoLi")%>
                            </td>
                            <td>
                                <%#Eval("menuName")%>
                            </td>
                            <td>
                                <%#Eval("imgUrl")%><img alt="<%#Eval("menuName")%>" src="../<%#Eval("imgUrl")%>" class="thisUrlImg" />
                            </td>
                            <td>
                                <input type="text" id="txtOrderBy" name="<%#Eval("menuOrder")%>" class="new_input" value="<%#Eval("menuOrder")%>" />  
                            </td>
                            <td>
                                <%#Eval("addTime")%>
                            </td>
                            <td>
                                <%#Eval("addName")%>
                            </td>
                            <td>
                                <cc1:CCHyperLink ID="CCHyperLink1" runat="server" Text="修改" NavigateUrl='<%#string.Format("Edit_Menu.aspx?menuId={0}",Eval("ID"))%>' CssClass="rpt_pro_a">
                                </cc1:CCHyperLink>
                                <cc1:CCHyperLink ID="CCHyperLink2" runat="server" Text="查看子菜单" NavigateUrl='<%#string.Format("../syspage/Manage_Page.aspx?menuId={0}",Eval("ID"))%>' CssClass="LinkButton_sty_dj">
                                </cc1:CCHyperLink>
                                <asp:LinkButton runat="server" CssClass="LinkButton_sty" ID="lblDelete" CommandName="del" OnClientClick="return confirm('确定要删除吗?')">删除</asp:LinkButton>
                                <asp:HiddenField ID="hfGetId" Value='<%#Eval("id") %>' runat="server" />
                            </td>
                        </tr>                      
                    </ItemTemplate>
                </asp:Repeater>
                </form>
                <tr>
                    <td colspan="7">
                        <input id="btnSaveOrder" type="button" class="button" value="保存排序" onclick="SaveOrder();" />
                    </td>
                </tr>
            </table>
            <div class="content_page" id="PageBar"><%=PageBarHTML %></div>
        </div>
    </div>    
    <script src="../../js/jquery-1.6.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function SaveOrder()
        {
            var o=$("td").find("input:text");
            var c=o.length;
            var jsonCnt="";
            var _id;
            
            var tag=0;
            var i;
            for(i=0;i<c;i++){
                if($(o[i]).css("color")=="red")
                {
                    _id=$(o[i]).parents('td').nextAll().find("input").val()
                    jsonCnt+=$(o[i]).val()+","+_id;
                    jsonCnt+="|"
                    tag=1;
                    //break;
                }
            }           
            if(tag==0){
                alert("您当前未作任何排序修改！");
                return;
            }else{
                //alert(jsonCnt);
                $.ajax({
                   type: "post",
                   url: "../../ajax/handler.aspx",
                   data: "oper=updateOrder&OrderString="+jsonCnt+"&pDate="+(new Date().getTime()),
                   success: function(msg){
                        var reg=parseInt(msg);
                        if(reg==81){
                            alert("网络传输错误更新失败，请刷新后重试！");
                            return false;
                        }
                        if(reg==100){                           
                            location.href="Manage_Menu.aspx";
                        }
                   },
                   error: function(){
                        alert("参数出错，刷新后重试");
                   }
                });
            }
        }

        $(document).ready(function() {
            $("td").find("input:text").hover(
                function() {
                    $(this).select();
                    $(this).css("background-color", "yellow");
                },
                function() {
                    $(this).css("background-color", "#e8f3f9");
                    if ($(this).val() != $(this).attr("name")) {
                        $(this).addClass("ChagenText");
                    } else {
                        $(this).removeClass("ChagenText");
                    }
                    $(this).blur();
                }
            );
        })
    </script>
</body>
</html>
