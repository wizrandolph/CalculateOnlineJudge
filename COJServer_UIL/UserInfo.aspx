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
p1 {
    position:absolute;
        top: 85px;
        left: 30px;
        margin-top:20px;
    }
p2 {
    position:absolute;
        top: 150px;
        left: 30px;
        margin-top:20px;
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
    width: 200px;
    height: 28px;
    border-top-right-radius: 5px;
    border-bottom-right-radius: 5px;
    border: 0;
    text-align:center;
}
#text {
    position:absolute;
        top: 70px;
        left: 31px;
        width: 400px;
        left:13px;
    }
 
#submit {
    border-style: none;
        border-color: inherit;
        border-width: 4px;
        font-size: 14px;
        font-family: 宋体;
        width: 120px;
        height: 28px;
        line-height: 28px;
        text-align: center;
        color: white;
        background-color: #FFA042;
        border-radius: 6px;
        margin-top:20px;
        position:absolute;
        top: 174px;
        left: 152px;
    }
</style>
</head>
<body>
    <div id="frame" runat="server">
    <form id="form1" runat="server">
        <div id="text">
            <p id="p1">
                <asp:label runat="server" class="label_input" ID="phone" Height="28px" Width="180px">手机号码</asp:label>
                <asp:TextBox ID="newphone" class="text_field" runat="server"></asp:TextBox>
            </p >
            <p id="p2">
                <asp:label runat="server" class="label_input" ID="email" Height="28px" Width="180px">邮箱地址</asp:label>
                <asp:TextBox ID="newemail" class="text_field" runat="server"></asp:TextBox>
            </p>
        </div>
            <div>
                <asp:Button ID="submit" runat="server" OnClick="Change_Submit" Text="修改信息" />
            </div>
        
        
    </form>
    </div>
</body>
</html>
