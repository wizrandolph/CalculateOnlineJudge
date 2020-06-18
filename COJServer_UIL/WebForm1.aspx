<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="COJServer_UIL.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <div id="login_frame">
 
    <p ><img id="image_logo" src="./asset/images/login/fly.jpg"/></p>
    <form id="form1_practiceset" runat="server">
        <div>
        </div>
        <select name="DropDownList" id="selectTime" runat="server">
            <option value="A">时间1</option>
            <option value="B">时间2</option>
            <option value="C">时间3</option>
            <option value="D">时间4</option>
        </select>
        <select name="DropDownList" id="selectType" runat="server">
            <option value="A">题型1</option>
            <option value="B">题型2</option>
            <option value="C">题型3</option>
            <option value="D">题型4</option>
        </select>

        <asp:Button ID="Button1_practice" runat="server" OnClick="Go2Prac_Click_PracSet" Text="我选好了！" />
        <asp:Button ID="Button2_practice" runat="server" OnClick="Back2Menu_Click_PracSet" Text="返回" />
        <asp:Label ID="Label1_PracSet" runat="server" Text="Label"></asp:Label> 
        
    </form>
        
</div>

</body>
</html>
