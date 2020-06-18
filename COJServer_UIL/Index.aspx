<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="COJServer_UIL.Test1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登陆</title>
    <style type ="text/css">
    body {
        background-image: url("./asset/images/login/loginBac.jpg");
        background-size: 100%;
        background-repeat: no-repeat;
    }
 
#login_frame {
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
 
#image_logo {
    margin-top: 22px;
    width: 50%;
    height: 50%;
    left: 50%;
    top: 50%

}
 
.label_input {
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
 
.text_field {
    width: 278px;
    height: 28px;
    border-top-right-radius: 5px;
    border-bottom-right-radius: 5px;
    border: 0;
}
 
#Button1_Index {
    font-size: 14px;
    font-family: 宋体;
 
    width: 120px;
    height: 28px;
    line-height: 28px;
    text-align: center;
 
    color: white;
    background-color: #3BD9FF;
    border-radius: 6px;
    border: 4px;
 
    float: left;
}
#Button2_Index {
    font-size: 14px;
    font-family: 宋体;
 
    width: 120px;
    height: 28px;
    line-height: 28px;
    text-align: center;
 
    color: white;
    background-color: #3BD9FF;
    border-radius: 6px;
    border: 4px;
 
    float: left;
}
 
 
#forget_pwd:hover {
    color: blue;
    text-decoration: underline;
}
 
#login_control {
    padding: 0 28px;
}


</style>
</head>
<body>
    
    <div id="login_frame">
 
    <p ><img id="image_logo" src="./asset/images/login/fly.jpg"/></p>
        
       
        <form id="form1" runat="server" method="post">
        <div>
            <p><label class="label_input">用户名</label><input type="text" name="username" id="username" /></p>
            <p><label class="label_input">密码</label><input type="text" name="password" id ="password"/></p>
        </div>

            <asp:Button ID="Button1_Index" runat="server" OnClick="Button1_Click_Index" Text="进入导航" />
            <asp:Button ID="Button2_Index" runat="server" OnClick="Button2_Click_Index" Text="登录" />
            <asp:Button ID="Button3_Index" runat="server" OnClick="Button3_Click_Index" Text="注册" />
        <asp:Label ID="Label1_Index" runat="server" Text="Label"></asp:Label>
    </form>
        
</div>

</body>
</html>
