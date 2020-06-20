<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserInfo.aspx.cs" Inherits="COJServer_UIL.UserInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>个人信息</title>
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
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="frame" runat="server">
            <p>
                <asp:label runat="server" class="label_input" ID="phone"></asp:label>
                <asp:TextBox ID="newphone" class="text_field" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:label runat="server" class="label_input" ID="email">用户名</asp:label>
                <asp:TextBox ID="newemail" class="text_field" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:label runat="server" class="label_input" ID="birthday">用户名</asp:label>
                <asp:TextBox ID="newbirth" class="text_field" runat="server"></asp:TextBox>
            </p>
        </div>
        <div>
            <asp:Button ID="submit" runat="server" OnClick="Change_Submit" Text="登录" />
        </div>
    </form>
</body>
</html>
