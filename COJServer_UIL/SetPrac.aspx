<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SetPrac.aspx.cs" Inherits="COJServer_UIL.SetPrac" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>设置题目选项</title>
    <style>
        body {
            background-image: url("./asset/images/login/loginbg.jpg");
            background-size: 100%;
            background-repeat: no-repeat;
            background-color: #ffce34;
        }
        #select_frame {
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
    
    
 
    
    <form id="form1_practiceset" runat="server">
        <div id="select_frame">   
            <select name="DropDownList" id="selectTime" runat="server">
                <option value="A">5分钟</option>
                <option value="B">10分钟</option>
                <option value="C">30分钟</option>
                <option value="D">1小时</option>
            </select>
            <select name="DropDownList" id="selectType" runat="server">
                <option value="A">加减运算</option>
                <option value="B">乘除运算</option>
                <option value="C">加减乘除综合</option>
                <option value="D">带余数的除法</option>
            </select>
            <select name="DropDownList" id="selectQuantity" runat="server">
                <option value="A">10道</option>
                <option value="B">30道</option>
                <option value="C">50道</option>
                <option value="D">100道</option>
            </select>
            <select name="DropDownList" id="selectInterval" runat="server">
                <option value="A">10以内</option>
                <option value="B">20以内</option>
                <option value="C">50以内</option>
                <option value="D">100以内</option>
            </select>
            <div id="control_frame">
                <asp:Button ID="Button1_practice" runat="server" OnClick="Go2Prac_Click_PracSet" Text="我选好了！" />
                <asp:Button ID="Button2_practice" runat="server" OnClick="Back2Menu_Click_PracSet" Text="返回" />
            </div>
            <div id="debug_frame">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label> 
            </div>
        </div>
        
    </form>
        

</body>
</html>
