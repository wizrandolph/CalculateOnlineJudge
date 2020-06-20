<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practice.aspx.cs" Inherits="COJServer_UIL.Practice" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>导航</title>
    <script type="text/javascript">
        //alert("js开启正常");
        var i = <%=jstime%>;
        window.onload = TimerFunct();
        var btn = document.getElementById("btn");
        function TimerFunct() {
            //document.getElementById("time").innerText = i.toString();
            if (i >= 0) {
                setTimeout("TimerFunct()", 1000);
                var info = i.toString();
                document.getElementById("time").innerText = i.toString();
                i--;
            }
            else {
                var str = i.toString();
                alert("你设定的时间已经到了！点击“提交”按钮查看成绩吧！");
            }
        }
        
        //var i = 5;
        // 获取登录事件，并处理自动跳转
        
    </script>
    <style type ="text/css">
        body {
            background-image: url("./asset/images/login/loginbg.jpg");
            background-size: 100%;
            background-repeat: no-repeat;
            background-color: #ffce34;
        }
        
        ul{
            list-style-type:none;
            counter-reset:sectioncounter;
            width:800px;
        }
        ul li:before {
            content:counter(sectioncounter) "、"; 
            counter-increment:sectioncounter;
            width:70px;
            height: 28px;
            position:absolute;
            left:13px;
        }
        .rtextbox {
            width: 180px;
            height: 28px;
            border-radius: 5px;
            border: 0;
            margin-top: 10px;
            margin-left: 10px;
        }
        
        .textbox {
            width: 180px;
            height: 28px;
            border-radius: 5px;
            border: 0;
            margin-top: 10px;
            margin-left: 10px;
        }
        .rwlabel {
            color:red;
            font-size: 18px;
        }
        .label {
            font-size: 18px;
            font-family: 宋体;
            width:180px;
            height: 28px;
            position: absolute;
            left:80px;
            line-height: 28px;
            text-align: center;
            color: white;
            background-color: #FFA042;
            border-radius: 5px;
            margin-top: 10px;
            margin-left:10px;
        }
        
        #control_frame {
            position:relative;
            width:400px;
            text-align:center;
        }
        #debug_frame {
            width: 400px;
            height: 260px;
            padding: 13px;
            position: fixed;
            right: 9%;
            top:16%;
            background-color: rgba(240, 255, 255, 0.5);
            border-radius: 10px;
            text-align: center;
        }
        #exercise_frame {
            width: 800px;
            padding: 13px;
            position: absolute;
            left:9%;
            top:16%;
            background-color: rgba(240, 255, 255, 0.5);
            border-radius: 10px;
            text-align: center;
        }
        #Button1_Practice {
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
        #Button2_Practice {
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
    <form id ="form1" runat ="server">
        <div id="exercise_frame" runat ="server">
            <ul id ="Exlist" runat ="server" > </ul>      
        </div>
        <div id="debug_frame">
            <div>
                时间还剩<span id ="time"></span>秒
            </div>
            <p><asp:Label ID="Label2" runat="server" ></asp:Label></p>
            <p><asp:Label ID="Label3" runat="server" ></asp:Label></p>
            <p><asp:Label ID="Label4" runat="server" ></asp:Label></p>
            <div id="control_frame">
                <asp:Button ID="Button1_Practice" runat="server" OnClick="Submit_Prac" Text="提交试题" />
                <asp:Button ID="Button2_Practice" runat="server" OnClick="Back2Menu_Click_Prac" Text="返回" />
            </div>
        </div>
    </form>

</body>
</html>
