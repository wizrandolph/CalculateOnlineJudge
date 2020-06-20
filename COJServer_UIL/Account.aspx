<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Account.aspx.cs" Inherits="COJServer_UIL.Account" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>注册</title>
    <style>
        body {
        background-image: url("./asset/images/login/loginbg.jpg");
        background-size: 100%;
        background-repeat: no-repeat;
        background-color: #ffce34;
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
 
form p > * {
    display: inline-block;
    vertical-align: middle;
}
form p {
    display: inline-block;
    vertical-align: middle;
}
 
.label_input {
    font-size: 14px;
    font-family: 宋体;
    width:80px;
    height: 28px;
    line-height: 28px;
    text-align: center;
    color: white;
    background-color: #FFA042;
    border-top-left-radius: 5px;
    border-bottom-left-radius: 5px;
}
 
.text_field {
    width: 278px;
    height: 28px;
    border-top-right-radius: 5px;
    border-bottom-right-radius: 5px;
    border: 0;
}
#content{    
    position: absolute;
    width: 400px;
    height: 260px;
    margin:auto;
            top: 50px;
            left: 13px;
        }
#Button1_Account {
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
#Button3_Index {
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

    </style>
</head>
<body>
    <div id="signup_frame">
    <form id="form1_Account" runat="server" method="post">
        <div id ="content">
            <p><asp:label runat="server" class="label_input">用户名</asp:label>
                <asp:TextBox ID="UserName" class="text_field" runat="server" ></asp:TextBox>
            </p>
            <p><asp:label runat="server" class="label_input">密码</asp:label>
                <asp:TextBox ID="Password" class="text_field" runat="server" TextMode="Password"></asp:TextBox>
            </p>
            <p><asp:Button ID="Button1_Account" runat="server" OnClick="Button1_Click_Account" Text="注册" /></p>
        </div>
        <div id ="debug_frame">
            <asp:Label ID="Label1_Account" runat="server" ></asp:Label>
        </div>
        </form>
    </div>
</body>
</html>
