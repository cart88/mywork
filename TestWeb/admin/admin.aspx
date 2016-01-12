<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="admin_admin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>企业费用系统管理中心</title>
    <meta http-equiv="Content-Type" content="text/html; charset=gb2312" />
    <link href="../css/admin.css" rel="stylesheet" type="text/css" charset="gb2312" />      
</head>
<body scroll="no">    
    <div id="top">
        <div id="top_left_bg">
            <div id="top_right_bg">
                <div id="top_logo"></div>
                <div id="top_nav">
                    <a href="member/Manage_Member.aspx" target="main_iframe">会员管理</a>
                    <a href="javascript:void(0);" target="main_iframe">财务报表</a>
                    <a href="javascript:void(0);" target="main_iframe">积分兑换</a>
                    <a title="点击刷新左侧菜单" id="FreshMenu" onclick="FreshMenu();" class="FreshMenu">刷新菜单</a>
                </div>
            </div>
        </div>
    </div>
    <div id="welcome">
        <span class="name">欢迎您，<%=adminGetCount%>[<%=adminGetRoleName%>]&nbsp;&nbsp;职位：Donet软件工程师</span> <span class="date">今天是：<span id="top_times"></span></span>
    </div>    
    <div id="content">
        <table width="100%" border="0" cellspacing="0" cellpadding="0" id="main_table">
            <tr>
                <td valign="top" id="menu">
                    <div id="menu_out">
                        <a href="admin.aspx" class="home">管理首页</a> <a id="exitLogin" href="adminexit.aspx" class="exit">退出系统</a>
                    </div>
                    <div id="menu_div">
                    <div id="menu_top">
                        <span></span><a ></a>
                    </div>
                    <form id="form1" runat="server">
                    <div runat="server" id="menu_all">
                    </div>
                    </form>
                    </div>
                </td>
                <td valign="top" id="switch">
                    <div id="switch_out"></div>
                    <div id="switch_go"></div>
                </td>
                <td valign="top" id="page">
                    <iframe src="desktop.aspx" width="100%" frameborder="0" name="main_iframe" id="main_iframe"></iframe>
                </td>
            </tr>
        </table>            
    </div>
    <div id="downmsg_emessage" style="display: none">
        <div id="downmsgBar">
            <div id="donwmsg_head">系统提示信息</div>
            <a href="javascript:showHideDiv()" class="msg-hidden-btn-1" id="msg_hidden_btn"></a>
        </div>
        <div id="donwmsg_content" runat="server"></div>
    </div>
    
    <script src="../js/jquery-1.6.min.js" type="text/javascript"></script>
    <script src="../js/admin/Index.js" type="text/javascript"></script>        
    <script type="text/javascript">    
        function FreshMenu()
        {
            $("#menu_all").html('<img alt="" src="../images/Main/loading_16x16.gif" class="LoadImg" />正在加载...');            
            $.ajax({
               type: "post",
               url: "../ajax/handler.aspx",
               data: "oper=loadmenu&pd="+(new Date().getTime()),
               success: function(msg){
                    $("#menu_all").html("");
                    $("#menu_all").append(msg);
                    formatMenu();
               }
            });
        }
    </script>
</body>
</html>
