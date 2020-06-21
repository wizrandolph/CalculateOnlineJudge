<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="COJServer_UIL.AboutUs" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>关于我们</title>
<style type ="text/css">
    body {
        background-image: url("./asset/images/login/loginbg.jpg");
        background-size: 100%;
        background-repeat: no-repeat;
        background-color: #ffce34;
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

    #Button2_Index {
    font-size: 14px;
    font-family: 宋体;
    width: 120px;
    height: 28px;
    line-height: 28px;
    text-align: center;
    color: white;
    background-color: #FFA042;
    border-radius: 6px;
    border: 4px;
}
    .label_input {
    font-size: 14px;
    font-family: 宋体;
    width:120px;
    height: 28px;
    line-height: 28px;
    text-align: center;
    color: white;
    background-color: #FFA042;
    border-radius: 5px;
}
    img {
        width:48px;
        height:48px;
        border-radius:5px;
        margin-top:50px;
    }

</style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="frame">
            <img src="./asset/images/npulogo.jpg"/>
            <p><asp:label runat="server" class="label_input">西北工业大学</asp:label></p>
            <asp:Button ID="Button2_Index" runat="server" OnClick="Back2Menu" Text="返回" />
        </div>
    </form>
</body>
</html>
