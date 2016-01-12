<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit_Page.aspx.cs" Inherits="admin_syspage_Edit_Page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>系统页面修改</title>
    <link href="../../css/Page.css" rel="stylesheet" type="text/css" />   
</head>
<body>
    <form id="form1" runat="server">
        <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">页面模块管理</a>
        </div>
        <div id="content">
            <table border="0" cellspacing="1" cellpadding="3" class="table">
                <tr>
                    <th colspan="4" id="td_tag">
                        页面模块修改
                    </th>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        页面名称：
                    </td>
                    <td>
                        <input runat="server" type="text" class="input" id="txtName" />
                    </td>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        所属父级：
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlParentMD" Width="128px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        排序数值：
                    </td>
                    <td>
                        <input runat="server" type="text" id="txtIntOrder" class="input" onkeyup="this.value=this.value.replace(/\D/g,'')"
                            onafterpaste="this.value=this.value.replace(/\D/g,'')" /><span style="color:#999;">菜单下子集的排序</span>
                    </td>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        左侧显示：
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="rdShowLeft" RepeatDirection="Horizontal">
                            <asp:ListItem Value="10" Text="是" Selected="True" />
                            <asp:ListItem Value="20" Text="否" />
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        模块地址：
                    </td>
                    <td>
                        <input runat="server" type="text" class="input" id="txtPath" style="width: 400px;" />
                    </td>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        模块描述：
                    </td>
                    <td>
                        <input type="text" runat="server" class="input" maxlength="20" id="txtDescribe" style="width: 400px;" /><span style="color:#999;">20个字</span>
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
    
    <script src="../../js/jquery-1.6.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function Checkinfo(){
            var _name=document.getElementById("txtName").value;
            var _path=document.getElementById("txtPath").value;
            var checkPid=$("#ddlParentMD");
            if(_name==""){
                alert("模块名称不能为空");
                return false;
            }
            if(_path==""){
                alert("模块路径不能为空");
                return false;
            }
            if(checkPid.val()=="-1")
            {
                alert("请选择所属菜单");
                return false;
            }      
            return true;
        }
    </script>    
</body>
</html>
