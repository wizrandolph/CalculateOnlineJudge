﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="COJServer_UIL.Test1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>导航</title>
    <style type ="text/css">
    body {
        background-image: url("./asset/images/login/loginBac.jpg");
        background-size: 100%;
        background-repeat: no-repeat;
    }

    </style>
</head>
<body>
    
    <div id="login_frame">
 
    <p ><img id="image_logo" src="./asset/images/login/fly.jpg"/></p>
        <form id="form1_Menu" runat="server">
            
        <div id =" UserInfo">

        </div>
        <asp:Button ID="Button1_Menu" runat="server" OnClick="Go2Practice" Text="开始练习" />
        <asp:Button ID="Button2_Menu" runat="server" OnClick="Go2History" Text="历史反馈" />
        <!--<asp:Label ID="Label1_Menu" runat="server" Text="Label"></asp:Label> -->
    </form>
        
</div>

</body>
</html>