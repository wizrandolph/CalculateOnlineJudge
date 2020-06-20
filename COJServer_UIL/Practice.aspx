<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practice.aspx.cs" Inherits="COJServer_UIL.Practice" %>

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
        }
        
        li {
            border: groove;
        }
        .textbox {
            width: 278px;
            height: 28px;
            border-top-right-radius: 5px;
            border-bottom-right-radius: 5px;
            border: 0;
        }
        .exercisetext {
            width: 50%;
        }
        
        #control_frame {
            position:absolute;
            left:50%;
            text-align:center;
        }
        #debug_frame {
            width: 400px;
            height: 260px;
            padding: 13px;
            position: absolute;
            left: 80%;
            top: 80%;
            margin-left: -200px;
            margin-top: -200px;
            background-color: rgba(240, 255, 255, 0.5);
            border-radius: 10px;
            text-align: center;
        }

    </style>
</head>
<body>
    
    <form id ="form1" runat ="server">
        <div id="exercise_frame" runat ="server">
            <ul id ="Exlist" runat ="server" > </ul>      
        </div>
        <div id="control_frame">
            <asp:Button ID="Button1_Practice" runat="server" OnClick="Submit_Prac" Text="提交试题" />
            <asp:Button ID="Button2_Practice" runat="server" OnClick="Back2Menu_Click_Prac" Text="返回" />
        </div>
        <div id="debug_frame">
            <p><asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label></p>
            <p><asp:Label ID="Label2" runat="server" Text="运算类型"></asp:Label></p>
            <p><asp:Label ID="Label3" runat="server" Text="运算类型"></asp:Label></p>
            <p><asp:Label ID="Label4" runat="server" Text="运算类型"></asp:Label></p>
        </div>
    </form>

</body>
</html>
