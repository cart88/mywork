<%@ Page Language="C#" AutoEventWireup="true" CodeFile="desktop.aspx.cs" Inherits="admin_desktop" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>首页</title>
    <link href="../css/Page.css" rel="stylesheet" type="text/css" />
    <script src="../js/jquery-1.6.min.js" type="text/javascript"></script>    
</head>
<body>
    <div id="main">       
        <div id="content">
            <div id="content_nav">
                <a href="#" class="add">新增会员</a> <a href="#" class="addgood">新增产品</a>
                 <a href="#" class="sound">发布公告</a> <a href="page.aspx" class="refresh">刷新</a>
            </div>
            <table border="0" cellpadding="3" cellspacing="1" class="table">
                <tr>
                    <th colspan="4">今日新增订单</th>
                    <th><span><a href="orders/Manage_Order.aspx">更多>></a></span></th>
                </tr>
                <tr align="center" class="head">
                    <td>
                        姓名
                    </td>
                    <td>
                        性别
                    </td>
                    <td>
                        年龄
                    </td>
                    <td>
                        卡号
                    </td>
                    <td>
                        操作
                    </td>
                </tr>
                <tr align="center">
                    <td>
                        <a href="#">测试</a>
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr class="tr1">
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr class="tr1">
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
            </table>
            <table border="0" cellspacing="1" cellpadding="3" class="table">
                <tr>
                    <th colspan="2">
                        添加数据
                    </th>
                </tr>
                <tr>
                    <td width="15%" align="right" class="td1">
                        卡号：
                    </td>
                    <td>
                        <input name="button3" type="button" class="button" id="button3" value="测试你懂的" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        姓名：
                    </td>
                    <td>
                        <input name="textfield4" type="text" class="input" id="textfield4" />
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td align="right" class="td1">
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <input name="button2" type="submit" class="button" id="button2" value="提交数据" />
                    </td>
                </tr>
            </table>
            <div class="content_page">
                <div class="left">
                    共有 <b>345</b> 条数据，当前第 <b>1</b> 页</div>
                <div class="right">
                    <a href="#" class="no">首页</a> <a href="#" class="no">1</a> <a href="#">2</a> <a href="#">
                        3</a> <a href="#">4</a> <a href="#">5</a> <a href="#">6</a><a href="javascript:void(null);">...</a> <a href="#">下一页</a> <a href="#">尾页</a>
                </div>
            </div>            
        </div>
    </div>    
</body>
</html>
