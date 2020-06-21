<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="COJServer_UIL.Menu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>导航</title>
    <style type ="text/css">
    body {
        background-image: url("./asset/images/login/loginbg.jpg");
        background-size: 100%;
        background-repeat: no-repeat;
        background-color: #ffce34;
    }
    form p > * {
        display: inline-block;
        vertical-align: middle;
    }
    form p {
        display: inline-block;
        vertical-align: middle;
    }
    #frame {
        width: 400px;
        height: 260px;
        padding: 13px;
        position: absolute;
        left: 50%;
        top: 50%;
        margin-left: -200px;
        margin-top: -200px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 10px;
        text-align: center;
    }
    #control_frame1 {
        position:absolute;
        width: 400px;
        left: 13px;
        top: 50%;
    }
    #control_frame2 {
        position:absolute;
        width: 400px;
        left: 13px;
        top: 70%;
    }
    #text_frame {
        position: absolute;
        width: 200px;
        height:50px;
        left:25%;
        top: 50px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 6px;
        border: 4px;
    }
    #Label1_Menu {
        height: 50px;
        width: 200px;
        text-align: center;
        line-height: 50px;
        font-family: 'Microsoft YaHei';
        font-size: 18px;
    }
    #Button1_Menu {
        font-size: 14px;
        font-family: 微软雅黑;
        width: 120px;
        height: 28px;
        line-height: 28px;
        text-align: center;
        color: white;
        background-color: #FFA042;
        border-radius: 6px;
        border: 4px;
    }
    #Button2_Menu {
        font-size: 14px;
        font-family: 微软雅黑;
        width: 120px;
        height: 28px;
        line-height: 28px;
        text-align: center;
        color: white;
        background-color: #FFA042;
        border-radius: 6px;
        border: 4px;
    }
    #Button3_Menu {
        font-size: 14px;
        font-family: 微软雅黑;
        width: 120px;
        height: 28px;
        line-height: 28px;
        text-align: center;
        color: white;
        background-color: #FFA042;
        border-radius: 6px;
        border: 4px;
    }
    #Button4_Menu {
        font-size: 14px;
        font-family: 微软雅黑;
        width: 120px;
        height: 28px;
        line-height: 28px;
        text-align: center;
        color: white;
        background-color: #FFA042;
        border-radius: 6px;
        border: 4px;
    }
    #Button5_Menu {
        font-size: 14px;
        font-family: 微软雅黑;
        width: 120px;
        height: 28px;
        line-height: 28px;
        text-align: center;
        color: white;
        background-color: #FFA042;
        border-radius: 6px;
        border: 4px;
    }
    #Button6_Menu {
        font-size: 14px;
        font-family: 微软雅黑;
        width: 120px;
        height: 28px;
        line-height: 28px;
        text-align: center;
        color: white;
        background-color: #FFA042;
        border-radius: 6px;
        border: 4px;
    }

    </style>
</head>
<body>
    
    <div id="frame">
        <form id="form1_Menu" runat="server">
            <div id="text_frame">
                <asp:label ID="Label1_Menu" runat="server" Text="用户名"></asp:label>
            </div>
            <div id="control_frame1">
                <asp:Button ID="Button1_Menu" runat="server" OnClick="Go2Practice" Text="开始练习" />
                <asp:Button ID="Button2_Menu" runat="server" OnClick="Go2History" Text="历史反馈" />
                <asp:Button ID="Button3_Menu" runat="server" OnClick="GetMyInfo" Text="我的信息" />
            </div>
            <div id="control_frame2">
                <asp:Button ID="Button4_Menu" runat="server" OnClick="AboutUs" Text="关于我们" />
                <asp:Button ID="Button5_Menu" runat="server" OnClick="DeleteAccount" Text="删除账号" />
                <asp:Button ID="Button6_Menu" runat="server" OnClick="Logoff" Text="退出登录" />
            </div>
    </form>
        
</div>

</body>
</html>
