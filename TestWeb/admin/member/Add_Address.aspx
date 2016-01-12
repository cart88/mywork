<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Add_Address.aspx.cs" Inherits="admin_member_Add_Address" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>新增配送地址</title>
    <link href="../../css/Page.css" rel="stylesheet" type="text/css" />
    <link href="../../css/skins/default.css" rel="stylesheet" type="text/css" />
     <style type="text/css">
        .th_img{width:14px; height:14px; cursor:pointer;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="main">
        <div id="nav">
            <a href="#">无聊管理系统</a> > <a href="#">会员管理</a> > <a href="#">新增配送地址</a>
        </div>
        <div id="content">
            <table border="0" cellspacing="1" cellpadding="3" class="table" align="right">
                <tr>
                    <th colspan="4" id="MsgShow">
                        配送地址新增
                    </th>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        收货人：
                    </td>
                    <td id="td_resetSty" width="30%">
                        <input runat="server" type="text" class="input" id="txtReceiveName" maxlength="8" /><span
                            class="td_span_red">*</span>
                    </td>
                    <td align="right" class="td1" style="width: 15%">手机号码：</td>
                    <td>
                        <asp:TextBox ID="txtTelephone" runat="server" class="input" maxlength="11" onkeyup="this.value=this.value.replace(/\D/g,'')" 
                        onafterpaste="this.value=this.value.replace(/\D/g,'')" Height="22px" 
                            Width="127px"  />
                        <span class="td_span_red">*</span></td>
                </tr>
                <tr>
                    <td align="right" class="td1" style="width: 15%">所在省市：</td>
                    <td>
                        <asp:DropDownList runat="server" ID="ddlProcince" Width="128px" Height="23px" />
                        &nbsp; 省&nbsp;&nbsp;
                        <select name="ddlCity" id="ddlCity" style="width:97px; height: 23px;"></select>
                        市
                        <input type="hidden" id="hidProvince" runat="server" />
                        <input type="hidden" id="hidCity" runat="server" />
                        <span class="td_span_red">*</span></td>
                    <td align="right" class="td1" style="width: 15%">
                        固定电话：
                    </td>
                    <td>
                        <asp:TextBox ID="txtPhone" MaxLength="15" runat="server" class="input" /><i style="color:#666; font-family:Arial;">0000-0000000</i>
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        关联用户：</td>
                    <td>
                        <img alt="单击绑定用户" title="单击绑定用户" class="th_img" src="../../images/Page/add.jpg" />
                    </td>
                    <td align="right" class="td1" style="width: 15%">邮政编码：</td>
                    <td>
                        <asp:TextBox ID="txtZipCode" runat="server" class="input" MaxLength="6" onkeyup="this.value=this.value.replace(/\D/g,'')" 
                        onafterpaste="this.value=this.value.replace(/\D/g,'')"  />
                        <span class="td_span_red">*</span></td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        收货地址：
                    </td>
                    <td colspan="3">
                        <span class="td_span_red"><input runat="server" type="text" class="input" id="txtAddress" maxlength="100" style="width: 300px;" />*</span></td>
                </tr>
                <tr>
                    <td colspan="4" align="center">
                        <asp:Button runat="server" class="button" ID="btnSend" Text="确定" OnClick="btnSend_Click"
                            OnClientClick="return CheckInfo();" />
                        <input type="button" class="button" id="btnBack" value="取消" style="margin-left: 10px;" onclick="javascript:history.back(-1);" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
    </form>

    <script src="../../js/jquery-1.6.min.js" type="text/javascript"></script>
    <script src="../../js/artDialog.min.js" type="text/javascript"></script>
    <script src="../../js/artDialog.plugins.js" type="text/javascript"></script>
    <script type="text/javascript">
        function CheckInfo(){            
            if($("#txtReceiveName").val()=="")
            {
                alert("收货人不能为空!");
                $("#txtReceiveName").focus();
                return false;
            }
            if($("#txtTelephone").val()=="")
            {
                alert("手机号码不能为空!");
                $("#txtTelephone").focus();
                return false;
            }
            if($("#txtAddress").val()=="")
            {
                alert("收获地址不能为空!");
                $("#txtAddress").focus();
                return false;
            }
            if($("#ddlProcince").val()=="-1")
            {
                alert("请选择所在省");
                return false;
            }
            if($("#ddlCity").val()=="-1")
            {
                alert("请选择所在市");
                return false;
            }           
            if($("#txtTelephone").val().length!=11)
            {
                alert("手机号码不合理!");
                $("#txtTelephone").select();
                return false;
            }
            if($("#txtZipCode").val()==""){
                alert("邮政编码不能为空");
                $("#txtZipCode").focus();
                return false;
            }
            
            return true;                   
        }
    </script>
    <script type="text/javascript">
        $(function() {
            $(".th_img").click(function() {
                art.dialog({
                    id: 'artdg_person',
                    title: '选择关联用户',
                    width: 500,
                    height: 330,
                    zIndex: 9999,
                    lock: true,
                    background: '#999',
                    opacity: 0.37,
                    fixed: true,
                    esc: false,
                    focus: false,
                    content: '', //document.getElementById('oobj')
                    initialize: function() {
                        //$("#J_showSpan").html("<label>"+tpname+"</label>");                                     
                    }
                });
            })
            //close dialog
            //$("#J_cancle").click(function(){
            //    var dialog = art.dialog.get('artdg_person');
            //    dialog.close();
            //})

            $("#ddlProcince").change(function() {
                var value = $(this).val();
                if (value != "-1") {
                    $("#hidProvince").val($(this).find("option:selected").text());//省
                    $.ajax({
                        type: "post",
                        url: "../../ajax/handler.aspx",
                        data: "oper=getcity&gettypecity=address&domainid=" + value + "&pDate=" + (new Date().getTime()),
                        success: function(msg) {
                            $("#ddlCity").html(msg);
                            $("#hidCity").val($("#ddlCity option").eq(0).text());//市
                        },
                        error: function() {
                            alert("参数出错，刷新后重试");
                        }
                    });
                } else {
                    $("#ddlCity").html('');
                }
            })

            $("#ddlCity").change(function() {
                $("#hidCity").val($(this).find("option:selected").text());//修改市
            })
        })
    </script>
</body>
</html>
