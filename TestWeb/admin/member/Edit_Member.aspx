<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Edit_Member.aspx.cs" EnableEventValidation="false" EnableViewState="false"  Inherits="admin_member_Edit_Member" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>会员信息修改</title>
    <link href="../../css/Page.css" rel="stylesheet" type="text/css" />
    <script src="../../js/DatePicker/WdatePicker.js" type="text/javascript"></script>
    <style type="text/css">
        .tddt
        {
            width: 308px;
        }       
        .tr_hide{  display:none;}
        .pwd_a{ color:#ff0000; text-decoration:underline;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">会员管理</a> > <a href="#">会员信息修改</a>
        </div>
        <div id="content">
            <table border="0" cellspacing="1" cellpadding="3" class="table" align="right">
                <tr>
                    <th colspan="4" id="MsgShow">
                        会员信息修改
                    </th>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">会员名：</td>
                    <td class="tddt">
                        <input runat="server" type="text" class="input" disabled="disabled" id="txtUserName" maxlength="10" /><span class="td_span_red">*</span>
                        <input type="hidden" runat="server" id="hidName" />
                    </td>
                    <td align="right" class="td1" style="width: 15%">
                        修改密码：
                    </td>
                    <td>
                        <asp:LinkButton ID="lkbtn" runat="server" CssClass="pwd_a" onclick="lkbtn_Click">修改</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        真实姓名：
                    </td>
                    <td>
                       <input runat="server" type="text" class="input" id="txtTrueName" maxlength="15" /><span class="td_span_red">*</span>
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
                        所在省市：
                    </td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlProcince" Width="122px" Height="22px" />
                        &nbsp; 省&nbsp;&nbsp;
                        <asp:DropDownList runat="server" id="ddlCity" width="90px" height="22px" />
                        市
                        <input type="hidden" id="hidProvince" runat="server" />
                        <input type="hidden" id="hidCity" runat="server" />
                        <span class="td_span_red">*</span>
                    </td>
                    <td align="right" class="td1" style="width: 15%">
                        用户类型：
                    </td>
                    <td>
                        <asp:RadioButtonList runat="server" ID="rbIsBusiness" 
                            RepeatDirection="Horizontal" Width="125px">
                            <asp:ListItem Value="0" Text="个人" Selected="True" />
                            <asp:ListItem Value="1" Text="企业" />
                        </asp:RadioButtonList>
                        <span class="td_span_red">修改成个人用户时，企业信息会清空*</span>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        联系地址：
                    </td>
                    <td>                        
                        <input runat="server" type="text" class="input" id="txtAddress" maxlength="100"  /><span class="td_span_red">*</span>
                    </td>
                    <td align="right" class="td1" style="width: 15%">
                        手机号码：</td>
                    <td>
                        <input runat="server" type="text" class="input" id="txtPhone" onkeyup="this.value=this.value.replace(/\D/g,'')" 
                        onafterpaste="this.value=this.value.replace(/\D/g,'')" maxlength="11" />
                    </td>
                </tr>
                <tr class="tr_hide">
                    <td align="right" class="td1">
                        部门：
                    </td>
                    <td>
                         <input runat="server" type="text" class="input" id="txtDepartment" maxlength="10" />
                         <span class="td_span_red">(企业用户填写)</span>
                    </td>
                    <td align="right" class="td1">
                        职位：
                    </td>
                    <td>
                        <input runat="server" type="text" class="input" id="txtPosition" maxlength="10" />
                        <span class="td_span_red">(企业用户填写)</span>
                    </td>
                </tr>
                <tr class="tr_hide">
                    <td align="right" class="td1">
                        税务登记号：</td>
                    <td>
                        <span class="td_span_red">
                       <input runat="server" type="text" class="input" id="txtRegistNumber" maxlength="18" />(企业用户填写)*</span></td>
                    <td class="td1">
                    </td>
                    <td>
                    </td>
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
        </div>
    </div>
    </form>    
    <script src="../../js/jquery-1.6.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        function CheckInfo(){            
            if($("#txtPassword").val()=="")
            {
                alert("请输入密码");
                $("#txtPassword").focus();
                return false;
            }
            if($("#txtTrueName").val()=="")
            {
                alert("请输入真实姓名");
                $("#txtPassword").focus();
                return false;
            }
            if($("#ddlProcince").val()=="-1")
            {
                alert("请选择所在省市");
                return false;
            }
            if($("#txtAddress").val()=="")
            {
                alert("请输入联系地址");
                $("#txtAddress").focus();
                return false;
            }
            if($("#txtPhone").val().length!=0){
                if($("#txtPhone").val().length!=11)
                {
                    alert("手机号码不合理");
                    $("#txtPhone").select();
                    return false;
                }
            }
            var ckrb;
            $("#rbIsBusiness").find("input[type=radio]").each(function(){
                if($(this).attr("checked")=="checked"){
                    ckrb=$(this).attr("value");
                }
            })
            if(ckrb=="1")
            {
               if($.trim($("#txtRegistNumber").val())==""){
                    alert("请输入税务登记号");
                    $("#txtRegistNumber").focus();
                    return false;   
                } 
            }       
                          
            return true;                   
        }
    </script> 
    <script type="text/javascript">
        $(function(){
            var isbss='<%=isbenuessTag %>';
            if(parseInt(isbss)==1){
                $("table tr[class=tr_hide]").show();
            }
        
            $("#rbIsBusiness input[type=radio]").change(function(){
                if(parseInt($(this).attr("value"))==1){                
                    $("table tr[class=tr_hide]").show();
                }else{
                   $("table tr[class=tr_hide]").hide();                    
                }                
            })
            
            $("#ddlProcince").change(function(){
                var value=$(this).val();
                if(value!="-1"){
                    $("#hidProvince").val($(this).find("option:selected").text());                
                    $.ajax({
                       type: "post",
                       url: "../../ajax/handler.aspx",
                       data: "oper=getcity&gettypecity=address&domainid="+value+"&pDate="+(new Date().getTime()),
                       success: function(msg){
                            $("#ddlCity").html(msg);
                            $("#hidCity").val($("#ddlCity option").eq(0).text());
                       },
                       error: function(){
                            alert("参数出错，刷新后重试");
                       }
                    });
                }else{
                    $("#ddlCity").html('');
                }
            })

            $("#ddlCity").change(function(){            
                $("#hidCity").val($(this).find("option:selected").text());
            })
            
        })
    </script>   
</body>
</html>
