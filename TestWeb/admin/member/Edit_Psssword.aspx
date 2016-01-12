<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit_Psssword.aspx.cs" Inherits="admin_member_Edit_Psssword" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>修改用户密码</title>
    <link href="../../css/Page.css" rel="stylesheet" type="text/css" />
</head>
<body>
   <form id="form1" runat="server">
   <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">页面模块管理</a> > 页面添加
        </div>
        <div id="content">
            <table border="0" cellspacing="1" cellpadding="3" class="table">
                <tr>
                    <th colspan="2" id="td_tag">
                        页面模块添加
                    </th>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        原始密码：
                    </td>
                    <td>
                        <input runat="server" type="text" class="input" id="txtrelpwd" /><span style="color:#ff0000;">*</span>
                    </td>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        新密码：
                    </td>
                    <td>
                        <input runat="server" type="text" id="txtnewpwd" class="input" /><span style="color:#ff0000;">6~16位*</span></td>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        重复密码：
                    </td>
                    <td>
                        <input type="text" runat="server" maxlength="10" class="input" id="txtchkpwd" /><span style="color:#ff0000;">*</span>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button runat="server" ID="btnCon" class="button_custom" Text="提交数据" OnClientClick="return Checkinfo();"
                            OnClick="btnCon_Click" />
                        <input type="button" id="btnCancel" class="button_custom" value="取消" onclick="javascript:location.href='Edit_Member.aspx?id=<%=ID %>';" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>

    <script src="../../js/tools.js" type="text/javascript"></script>
    <script type="text/javascript">
        function Checkinfo(){
            var a=document.getElementById("txtrelpwd");
            var b=document.getElementById("txtnewpwd");
            var c=document.getElementById("txtchkpwd");
            if(trim(a.value)==""||trim(b.value)==""||trim(c.value)==""){
                alert("请完整输入");
                return false;
            }
            if(trim(b.value).length<6||trim(b.value).length>16){
                alert("新密码输入长度与要求不符");
                return false;
            }
            if(b.value!=c.value){
                alert("新密码两次输入不一致");
                return false;
            }
            
            return true;
        }
    </script>
</body>
</html>
