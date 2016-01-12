<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add_SysUser.aspx.cs" Inherits="admin_sysuser_Add_SysUser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>新增系统用户</title>
    <link href="../../css/Page.css" rel="stylesheet" type="text/css" />
    <script src="../../js/DatePicker/WdatePicker.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">系统用户管理</a> > <a href="#">添加系统用户</a>
        </div>
        <div id="content">
            <table border="0" cellspacing="1" cellpadding="3" class="table" align="right">
                <tr>
                    <th colspan="4" id="MsgShow">
                        系统用户添加
                    </th>
                </tr>                
                <tr>
                    <td align="right" class="td1">
                        <%--行政级别：--%>
                        看着写，或者删掉，注意页面排版
                    </td>
                    <td>
                         <asp:DropDownList runat="server" ID="ddlPowerLeave" Width="155px" />
                         <span class="td_span_red">*</span>
                    </td>
                    <%if (adminGetadminTag == Test_BUL.sysParam.AdministratorTagH)
                      { %>
                    <td width="15%" align="right" class="td1">
                        超管标记：
                    </td>
                    <td>
                        <input runat="server" type="checkbox" id="chkIsAdmin" value="100" style="font-size: 12px;" />
                        <span class="td_span_red">(请慎重考虑)</span>
                    </td>
                    <%}
                      else
                      { %>
                    <td width="15%" align="right" class="td1">
                        &nbsp;
                    </td>
                    <td>&nbsp;</td>
                    <%} %>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">登录账号：</td>
                    <td id="td_resetSty">
                        <style type="text/css">
                            #td_resetSty label
                            {
                                font-size: 12px;
                            }
                        </style>
                        <input runat="server" type="text" class="input" id="txtcount" maxlength="18" /><span class="td_span_red">*</span></td>
                    <td align="right" class="td1" style="width: 15%">
                        角色类型：
                    </td>
                    <td style="font-size: 12px;">
                        <asp:DropDownList runat="server" ID="ddlRole" Width="128px" />
                        <span class="td_span_red">*</span>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        手机号码：
                    </td>
                    <td>
                        <input runat="server" type="text" class="input" id="txtTelephone" maxlength="11"
                            onkeyup="this.value=this.value.replace(/\D/g,'')" onafterpaste="this.value=this.value.replace(/\D/g,'')" /><span
                                class="td_span_red">*</span>
                    </td>
                    <td align="right" class="td1" style="width: 15%">
                        性别：
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="rbSex" RepeatDirection="Horizontal" Width="125px">
                            <asp:ListItem Value="1" Text="男" Selected="True" />
                            <asp:ListItem Value="0" Text="女" />
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        登录密码：
                    </td>
                    <td>
                        <asp:TextBox ID="txtPwd" runat="server" class="input" TextMode="Password" />
                        <span class="td_span_red">*</span>
                    </td>
                    <td align="right" class="td1" style="width: 15%">
                        出生日期：
                    </td>
                    <td>
                        <input runat="server" type="text" class="input Wdate" id="txtBirthday" size="12"
                            style="width: 128px;" onclick="WdatePicker()" /><span class="td_span_red">*</span>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        确认密码：
                    </td>
                    <td>
                        <input runat="server" type="password" class="input" id="txtCheckPwd" />
                        <span class="td_span_red">*</span>
                    </td>
                    <td align="right" class="td1" style="width: 15%">
                        Email地址：</td>
                    <td>
                        <input runat="server" type="text" class="input" id="txtEmail" style="width: 300px;" /></td>
                </tr>
                <tr>
                    <td colspan="4" align="center">
                        <asp:Button runat="server" class="button" ID="btnSend" Text="确定" OnClick="btnSend_Click"
                            OnClientClick="return CheckInfo();" />
                        <input type="button" class="button" id="Button1" value="取消" style="margin-left: 10px;"
                            onclick="javascript:history.back(-1);" />
                    </td>
                </tr>
            </table>
            <%--<div id="test_div" runat="server"></div>--%>
        </div>
    </div>
    </form>    
    <script src="../../js/jquery-1.6.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function CheckInfo() {
            if ($("#ddlPowerLeave").val() == "-1") {
                alert("请选择行政级别");
                return false;
            }
            if ($("#txtcount").val() == "") {
                alert("请填写账号");
                $("#txtcount").focus();
                return false;
            }
            if ($("#ddlRole").val() == "-1") {
                alert("请选择角色类型");
                return false;
            }
            if ($("#txtTelephone").val() == "") {
                alert("手机号码不能为空");
                $("#txtTelephone").focus();
                return false;
            }
            if ($("#txtTelephone").val().length != 11) {
                alert("手机号码不合理");
                $("#txtTelephone").select();
                return false;
            }
            if ($("#txtPwd").val() == "") {
                alert("请填写管理员密码");
                $("#txtPwd").focus();
                return false;
            }
            if ($("#txtCheckPwd").val() == "") {
                alert("请确认管理员密码");
                $("#txtCheckPwd").focus();
                return false;
            }
            if ($("#txtCheckPwd").val() != $("#txtPwd").val()) {
                alert("两次密码输入不一致");
                $("#txtPwd").select();
                $("#txtCheckPwd").attr("value", "");
                return false;
            }
            if ($("#txtBirthday").val() == "") {
                alert("您忘记填写出生日期了");
                return false;
            }
            var temstr = $.trim($("#txtEmail").val());
            if (temstr != "") {
                var result = temstr.match(/^\w+((-\w+)|(\.\w+))*\@[A-Za-z0-9]+((\.|-)[A-Za-z0-9]+)*\.[A-Za-z0-9]+$/);
                if (result == null) {
                    alert("邮箱地址不符合要求");
                    $("#txtEmail").select();
                    return false;
                }
            }

            return true;
        }
    </script>    
</body>
</html>
