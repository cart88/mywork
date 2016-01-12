<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="admin_login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>系统登录</title>
    <link href="../css/adminLogin.css" rel="stylesheet" type="text/css" />  
</head>
<body onkeydown="onEnterDown();">
    <div id="top">
    </div>
    <div id="login">
        <div id="login_box">
            <div class="title">
            </div>
            <div class="content">
                <div class="left">
                </div>
                <div class="main">
                    <form id="login_form" action="Handel/Ulogin.ashx">
                    <div class="login_userid">
                        <span>账　号：</span>
                        <input name="userid" type="text" class="input" id="userid" autocomplete="off" />
                    </div>
                    <div class="login_password">
                        <span>密　码：</span>
                        <input name="password" type="password" class="input" id="password" />
                    </div>
                    <div class="login_code">
                        <span>验证码：</span>
                        <input name="code" type="text" class="input" id="code" style="width:50px;" maxlength="4" autocomplete="off" />
                        <img alt="" src="../Control/validate.aspx" id="getcode_img" title="看不清请点击！" />
                    </div>
                    <div class="login_button">
                        <input type="button" name="submit" id="submit" value="" onclick="submit_login();" />
                        <input type="reset" name="reset" id="reset" value="" onclick="doReset();" />
                    </div>
                    </form>
                    <div class="note">
                        * 不要在公共场合保存登录信息；<br />
                        * 为了保证您的帐号安全，退出系统时请注销登录
                        <span id="msg_tip"></span>
                    </div>
                </div>
                <div class="right">
                </div>
            </div>
        </div>
    </div>
    <div id="foot">
        <p style="padding-top:20px;">版权所有：XXXXXXXXX科技有限公司 地址：XXXXXXXXXXXXXXXXXXXXXX</p>
        <p>联系人：XXXXXXX   电话：0000-00000000   联系传真：0000-00000000</p></div>

    <script src="../js/jquery-1.6.min.js" type="text/javascript"></script>
    <script src="../js/login/js_login.js" type="text/javascript"></script>

    <script type="text/javascript">
        $(document).ready(function() {
            $("#userid").focus();
            $("#getcode_img").click(ShowValidImage);
        })
    
        function onEnterDown(){//body的onkeydown事件时调用
            if(window.event.keyCode == 13){
                submit_login();
            }
        }
    </script>        
</body>
</html>