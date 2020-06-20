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
        position: absolute;
        width: 200px;
        height:50px;
        left:25%;
        top: 50px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 6px;
        border: 4px;
    }
    #l2 {
        position: absolute;
        width: 200px;
        height:50px;
        left:25%;
        top: 100px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 6px;
        border: 4px;
    }
    #l3 {
        position: absolute;
        width: 200px;
        height:50px;
        left:25%;
        top: 150px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 6px;
        border: 4px;
    }
    #l4 {
        position: absolute;
        width: 200px;
        height:50px;
        left:25%;
        top: 200px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 6px;
        border: 4px;
    }
    #l5 {
        position: absolute;
        width: 200px;
        height:50px;
        left:25%;
        top: 250px;
        background-color: rgba(240, 255, 255, 0.5);
        border-radius: 6px;
        border: 4px;
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

        </div>

            
        
        <asp:Button ID="Button2_History" runat="server" OnClick="Back2Menu_History" Text="返回导航" />
        <!--<asp:Label ID="Label1_History" runat="server" Text="Label"></asp:Label> -->
    </form>
        


</body>
</html>
