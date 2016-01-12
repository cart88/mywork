<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit_SysParam.aspx.cs" Inherits="admin_sysparam_Edit_SysParam" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>系统参数修改</title>
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
                        参数名称：
                    </td>
                    <td>
                        <input runat="server" type="text" class="input" id="txtName" /><span style="color:#ff0000;">*</span>
                    </td>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        参数值：
                    </td>
                    <td>
                        <input runat="server" type="text" id="txtValue" class="input" onkeyup="this.value=this.value.replace(/\D/g,'')"
                            onafterpaste="this.value=this.value.replace(/\D/g,'')" /></td>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        所属标记：
                    </td>
                    <td>
                        <input type="text" runat="server" maxlength="10" class="input" id="txtTypeTag" style="width: 400px;" /><span style="color:#ff0000;">10个字*</span>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button runat="server" ID="btnCon" class="button_custom" Text="提交数据" OnClientClick="return Checkinfo();"
                            OnClick="btnCon_Click" />
                        <input type="button" id="btnCancel" class="button_custom" value="返回" onclick="javascript:history.back(-1);" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>

    <script src="../../js/tools.js" type="text/javascript"></script>
    <script type="text/javascript">
        function Checkinfo(){
            var _name=document.getElementById("txtName");
            var _typetag=document.getElementById("txtTypeTag");
            if(trim(_name.value)==""){
                alert("参数名不能为空！");
                _name.focus();
                return false;
            }
            if(trim(_typetag.value)==""){
                alert("标记类型不能为空！");
                _typetag.focus();
                return false;
            }
            
            return true;
        }
    </script>
</body>
</html>
