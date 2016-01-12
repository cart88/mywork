<%@ Page Language="C#" AutoEventWireup="true" CodeFile="error.aspx.cs" Inherits="error" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>系统提示</title>
    <script type="text/javascript">
        //此页面的参数可做修改，由其他页面传过来接收，具体的根据需要修改
        var seed=5;
        var url;
        function loadUrl(objurl)
        {
            url=objurl;
            for(var i=seed;i>0;i--)
            {
                window.setTimeout('doUpdate('+i+')',(seed-i)*1000);   
            }
        }
        function doUpdate(num)
        {
            document.getElementById("showInfo").innerHTML="<span style=\"color:Red; font-weight:bold;\">"+num+"</span>秒后将跳转返回";
            if(num==1){window.location.href=url;}
            //if(num==1){window.history.go(-2);}
        }
    </script>
</head>
<body>
    <div style="width: 900px; height: 350px; background-color: #e4e4e4; padding: 15px;
        margin: 0 auto;">
        <div style="width: 896px; height: 346px; background-color: #fff; border-left: 1px solid #cecece;
            border-top: 1px solid #cecece; border-right: 3px solid #cecece; border-bottom: 3px solid #cecece;">
            <div style="float: left; width: 460px; height: 346px; background: url('Images/pagetag/error404.jpg') 0px 0px no-repeat;">
            </div>
            <div style="float: right; width: 436px; height: 316px; padding-top: 30px;">
                <h6 style="font-size: 14px; margin: 0px; padding: 0px; width: 365px; border-bottom: 1px dashed #d1d1d1;
                    height: 30px; line-height: 30px;">
                    很抱歉，访问的页面有误</h6>
                <div style="width: 365px; margin-top: 20px;">
                    <ul style="margin: 0px; padding: 0px; width: 365px; list-style: none; font-size: 12px;
                        color: #6c6c6c; line-height: 25px;">
                        <%=strMsg.ToString() %>
                    </ul>
                </div>
                <div id="showInfo" style="margin-top: 20px; height: 140px; text-align: center; line-height: 140px;
                    font-size: 14px;">
                </div>
            </div>
            <div style="clear: both;">
            </div>
        </div>
    </div>

    <script type="text/javascript">
        loadUrl('<%=Go2Url %>');
    </script>
</body>
</html>
