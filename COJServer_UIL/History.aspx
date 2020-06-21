<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="COJServer_UIL.History" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
<title>历史成绩</title>
<style type ="text/css">
    div {
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 10px;
    }
    body {
        background-image: url("./asset/images/login/loginbg.jpg");
        background-size: 100%;
        background-repeat: no-repeat;
        background-color: #ffce34;
    }
    .label_input{
        line-height:45px;
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
    #l1 {
        border-style: none;
        border-color: inherit;
        border-width: 4px;
        position: absolute;
        width: 180px;
        height:45px;
        left:7%;
        top: 22px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 6px;
        }
    #l2 {
        border-style: none;
        border-color: inherit;
        border-width: 4px;
        position: absolute;
        width: 180px;
        height:45px;
        left:7%;
        top: 82px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 6px;
        }
    #l3 {
        border-style: none;
        border-color: inherit;
        border-width: 4px;
        position: absolute;
        width: 180px;
        height:45px;
        left:7%;
        top: 142px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 6px;
        }
    #l4 {
        border-style: none;
        border-color: inherit;
        border-width: 4px;
        position: absolute;
        width: 180px;
        height:45px;
        left:7%;
        top: 202px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 6px;
        }
    #l5 {
        border-style: none;
        border-color: inherit;
        border-width: 4px;
        position: absolute;
        width: 180px;
        height:98px;
        left:52%;
        top: 26px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 6px;
        margin-top: 3px;
    }
    #Button2_History {
    border-style: none;
        border-color: inherit;
        border-width: 4px;
        font-size: 14px;
        font-family: 宋体;
        width: 180px;
        height: 98px;
        line-height: 28px;
        text-align: center;
        color: white;
        background-color: #FFA042;
        border-radius: 6px;
        position: absolute;
        top: 141px;
        left: 221px;
    }
</style>
</head>
<body>
    
    
 
        <form id="form1_History" runat="server">
        <div id="frame">
        <div id="l1">
            <asp:label runat="server" class="label_input" ID="Label1"></asp:label>
        </div>
        <div id="l2">
            <asp:label runat="server" class="label_input" ID="Label2"></asp:label>
        </div>
        <div id="l3">
            <asp:label runat="server" class="label_input" ID="Label3"></asp:label>
        </div>
        <div id="l4">
            <asp:label runat="server" class="label_input" ID="Label4"></asp:label>
        </div>
        <div id="l5">
            <asp:label runat="server" class="label_input" ID="Label5"></asp:label>
        </div>
            <asp:Button ID="Button2_History" runat="server" OnClick="Back2Menu_History" Text="返回导航" />
        </div>
        <!--<asp:Label ID="Label1_History" runat="server" Text="Label"></asp:Label> -->
    </form>
        


</body>
</html>
