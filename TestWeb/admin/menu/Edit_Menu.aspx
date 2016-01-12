<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit_Menu.aspx.cs" Inherits="admin_menu_Edit_Menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>系统文件菜单修改</title>
    <link href="../../css/Page.css" rel="stylesheet" type="text/css" />
    <style type="text/css">
        .MenuImgStle{ width:16px; height:16px; vertical-align:middle;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">菜单管理</a> > 文件菜单修改
        </div>
        <div id="content">
            <table border="0" cellspacing="1" cellpadding="3" class="table">
                <tr>
                    <th colspan="2">
                        文件菜单添加
                    </th>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        模块名称：
                    </td>
                    <td>
                        <input runat="server" type="text" id="txtMenuName" class="input" />
                    </td>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        图标地址：
                    </td>
                    <td>
                        
                        <input runat="server" type="text" class="input" id="txtMenuImg" onfocus="javascript:this.select();" value="Images/Ico/null.gif" />
                        <img alt="默认图标" src="<%= string.IsNullOrEmpty(NowImgPath) ? "../../Images/Ico/null.gif" : "../" + NowImgPath%>" class="MenuImgStle" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        排序数值：
                    </td>
                    <td>
                        <input runat="server" type="text" class="input" id="txtIntOrder" onkeyup="this.value=this.value.replace(/\D/g,'')"
                            onafterpaste="this.value=this.value.replace(/\D/g,'')" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button runat="server" class="button" ID="btnSend" Text="确认提交" OnClientClick="return CheckInfo();"
                            OnClick="btnSend_Click" />
                            <input type="button" class="button" id="btnCancel" value="取消" style="margin-left: 10px;"
                            onclick="javascript:location.href='Manage_Menu.aspx';" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>
    
    <script type="text/javascript">
        function CheckInfo(){
           var fileName=document.getElementById("txtMenuName").value;
           if(fileName==""){
                alert("菜单名称不能为空！");
                return false;
           }
        }
    </script>
</body>
</html>
