<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="COJServer_UIL.Account" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>注册</title>
    <style>
        body {
            background-image: url("./asset/images/login/loginBac.jpg");
            background-size: 100%;
            background-repeat: no-repeat;
        }
        #signup_frame {
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
        .label {
            font-size: 14px;
            font-family: 宋体;
            width: 65px;
            height: 28px;
            line-height: 28px;
            text-align: center;
            color: white;
            background-color: #3CD8FF;
            border-top-left-radius: 5px;
            border-bottom-left-radius: 5px;
        }

    </style>
</head>
<body>
    <div id="signup_frame">
    <form id="form1_Account" runat="server" method="post">
        <div>
            <p><asp:label runat="server" class="label_input">用户名</asp:label>
                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
            </p>
            <p><asp:label runat="server" class="label_input">密码</asp:label>
                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
            </p>
            <asp:Button ID="Button1_Account" runat="server" OnClick="Button1_Click_Account" Text="注册" />
        </div>
        <div>
            <asp:Label ID="Label1_Account" runat="server" Text="Label"></asp:Label>        
            <p><asp:Label ID="Label2_A" runat="server" Text="Labe2"></asp:Label></p>
            <p><asp:Label ID="Label3_A" runat="server" Text="Labe3"></asp:Label></p>
        </div>
        </form>
    </div>
</body>
</html>
