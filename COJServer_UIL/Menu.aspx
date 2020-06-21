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
        top: 40%;
    }
    #control_frame2 {
        position:absolute;
        width: 400px;
        left: 13px;
        top: 70%;
    }
    #text_frame {
        border-style: none;
            border-color: inherit;
            border-width: 4px;
            position: absolute;
            width: 300px;
            height:50px;
        left:15%;
            top: 50px;
            background-color: rgba(240, 255, 255, 0.5);
            border-radius: 6px;
        }
    #Label1_Menu {
        height: 50px;
        width: 300px;
        text-align: center;
        line-height: 50px;
        font-family: 'Microsoft YaHei';
        font-size: 18px;
        position:absolute;
            top: -2px;
            left: 0px;
        }
    #Button1_Menu {
        border-style: none;
            border-color: inherit;
            border-width: 4px;
            font-size: 14px;
            font-family: 微软雅黑;
            line-height: 28px;
            text-align: center;
            color: white;
            background-color: #FFA042;
            border-radius: 6px;
            position:absolute;
            top: 30px;
            left: 23px;
            height: 94px;
            width: 111px;
        }
    #Button2_Menu {
        border-style: none;
            border-color: inherit;
            border-width: 4px;
            font-size: 14px;
            font-family: 微软雅黑;
            line-height: 28px;
            text-align: center;
            color: white;
            background-color: #FFA042;
            border-radius: 6px;
            position:absolute;
            top: 30px;
            width: 100px;
            height: 40px;
            left: 283px;
        }
    #Button3_Menu {
        border-style: none;
            border-color: inherit;
            border-width: 4px;
            font-size: 14px;
            font-family: 微软雅黑;
            line-height: 28px;
            text-align: center;
            color: white;
            background-color: #FFA042;
            border-radius: 6px;
            position:absolute;
            height: 40px;
            top: 30px;
            left: 160px;
            width: 100px;
        }
    #Button4_Menu {
        border-style: none;
            border-color: inherit;
            border-width: 4px;
            font-size: 14px;
            font-family: 微软雅黑;
            line-height: 28px;
            text-align: center;
            color: white;
            background-color: #FFA042;
            border-radius: 6px;
            position:absolute;
            height: 40px;
            top: 197px;
            left: 296px;
            width: 100px;
        }
    #Button6_Menu {
            border-style: none;
            border-color: inherit;
            border-width: 4px;
            font-size: 14px;
            font-family: 微软雅黑;
            line-height: 28px;
            text-align: center;
            color: white;
            background-color: #FFA042;
            border-radius: 6px;
            position:absolute;
            height: 40px;
            top: 83px;
            left: 160px;
            width: 100px;
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
                <asp:Button ID="Button6_Menu" runat="server" OnClick="Logoff" Text="切换账号" />
            </div>
                <asp:Button ID="Button4_Menu" runat="server" OnClick="AboutUs" Text="关于我们" />
    </form>
        
</div>

</body>
</html>
