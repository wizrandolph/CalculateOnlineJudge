<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practice.aspx.cs" Inherits="COJServer_UIL.Practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>导航</title>
    <style type ="text/css">

    </style>
</head>
<body>
    
    <div id="exercise_frame">
        <ul id ="Exlist" runat ="server" > </ul>
        
        
     </div>
    <div id="control_frame">
        <form id="form1_Prac" runat="server">
        <asp:Button ID="Button1_Practice" runat="server" OnClick="Submit_Click_Prac" Text="提交试题" />
        <asp:Button ID="Button2_Practice" runat="server" OnClick="Back2Menu_Click_Prac" Text="返回" />
        <!--<asp:Label ID="Label1_Prac" runat="server" Text="Label"></asp:Label> -->
        </form>
    </div>
    <div id="debug_frame">
        <p><asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label></p>
        <p><asp:Label ID="Label2" runat="server" Text="运算类型"></asp:Label></p>
        <p><asp:Label ID="Label3" runat="server" Text="运算类型"></asp:Label></p>
        <p><asp:Label ID="Label4" runat="server" Text="运算类型"></asp:Label></p>
    </div>

</body>
</html>
