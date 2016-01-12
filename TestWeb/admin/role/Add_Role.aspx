<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add_Role.aspx.cs" Inherits="admin_role_Add_Role" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加角色</title>
    <link href="../../css/Page.css" rel="stylesheet" type="text/css" />    
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">角色管理</a> >
            添加角色
        </div>
        <table border="0" cellpadding="3" cellspacing="1" class="table">
            <tr>
                <th colspan="2">
                    添加角色
                </th>
            </tr>
            <tr>
                <td align="right" class="td1" style="width: 15%">
                    角色名称
                </td>
                <td>
                    <asp:TextBox runat="server" ID="txt_RoleName" CssClass="input"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td align="right" class="td1" style="width: 15%">
                    权限名称
                </td>
                <td>
                    <%--<asp:TextBox runat="server" ID="txt_PowerId" CssClass="input"></asp:TextBox>--%>
                    <table style="width:100%;" class="table">
                    <asp:Repeater runat="server" ID="rpt_RoleList" 
                        onitemdatabound="rpt_RoleList_ItemDataBound">
                        <ItemTemplate>
                            <tr class=<%#(Container.ItemIndex%2==0)?"\"trnull\"":"\"tr1\""%> >
                            <td align="right"  style="width: 15%">
                                <asp:CheckBox runat="server" ID="parentId" Text='<%#Eval("menuName") %>' Font-Bold="true" onclick="CheckChange(this);"/></td>
                            <td align="left">
                                <asp:CheckBoxList runat="server" ID="cbList" RepeatDirection="Horizontal" RepeatLayout="Flow" onclick="aaa(this);">
                                    </asp:CheckBoxList>
                            </td>
                        </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="right" class="td1">
                    <asp:Button ID="btnSave" runat="server" Text="确定" CssClass="button" OnClick="btnSave_Click" OnClientClick="return check();" />
                </td>
                <td>
                    <input type="button" id="btnCancel" class="button" value="返回" onclick="javascript:history.back(-1);" />
                </td>
            </tr>
        </table>
        <label id="lblMsg" runat="server">
        </label>
    </div>
    </form>    
    <script src="../../js/jquery-1.6.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        //去掉字符串两边的空格        
        function ltrim(s){//去掉左边空格
            return s.replace(/^\s*/,"");
        }        
        function rtrim(s){//去掉右边空格
            return s.replace(/\s*$/,"");
        }
        function trim(s){
             return rtrim(ltrim(s));
        }
        //================================
        function check()
        {
            var role= trim(document.getElementById("txt_RoleName").value);
            if(role=="")
            {
                alert("角色名称不能为空!");
                return false;
            }
            if($(":checkbox:checked").length<1)
            {
                alert("至少选择一个");
                return false;
            }
            return true;
        }
    </script>
    <script type="text/javascript" language="javascript">
        function CheckChange(obj)
        {
            var _checked = $(obj).attr("checked")?true:false;
            $(obj).parents('td').next().find('input').attr('checked',_checked);
        }
        
        function aaa(obj)
        {
            var _checked = true;
            $(obj).parent().parent().find('input:checked').length==$(obj).parent().parent().find('input').length?true:false;
            
            $(obj).parents('td').prev().find('input').attr('checked',_checked);
        }
    </script>
</body>
</html>
