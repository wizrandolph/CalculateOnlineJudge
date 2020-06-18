<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Practice.aspx.cs" Inherits="COJServer_UIL.Webform1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>导航</title>
    <style type ="text/css">

    </style>
</head>
<body>
    <div id="exercise_frame">
        <ul id="jst_dingbu_biaoti_shezhi"><li>耗时：<span id="jst_haoshi"></span></li><li>题数：<script type="text/javascript">t_y_y(1, 20, "sj_tishu");</script></li><li>得分：<span id="jst_defen"></span></li></ul><div id="neirong_html"><ul id="neirong_ul"><li>1＋3＝ <input type="text" size="2" zqda="4" onkeyup="quanjiao_zhuan_banjiao(this);" /><span class="daan_show"></span> <i class="s_jieguo">4</i></li><li>3＋1＝ <input type="text" size="2" zqda="4" onkeyup="quanjiao_zhuan_banjiao(this);" /><span class="daan_show"></span> <i class="s_jieguo">4</i></li><li>3＋2＝ <input type="text" size="2" zqda="5" onkeyup="quanjiao_zhuan_banjiao(this);" /><span class="daan_show"></span> <i class="s_jieguo">5</i></li><li>1＋2＝ <input type="text" size="2" zqda="3" onkeyup="quanjiao_zhuan_banjiao(this);" /><span class="daan_show"></span> <i class="s_jieguo">3</i></li><li>4＋1＝ <input type="text" size="2" zqda="5" onkeyup="quanjiao_zhuan_banjiao(this);" /><span class="daan_show"></span> <i class="s_jieguo">5</i></li><li>2＋3＝ <input type="text" size="2" zqda="5" onkeyup="quanjiao_zhuan_banjiao(this);" /><span class="daan_show"></span> <i class="s_jieguo">5</i></li><li>1＋4＝ <input type="text" size="2" zqda="5" onkeyup="quanjiao_zhuan_banjiao(this);" /><span class="daan_show"></span> <i class="s_jieguo">5</i></li><li>3＋2＝ <input type="text" size="2" zqda="5" onkeyup="quanjiao_zhuan_banjiao(this);" /><span class="daan_show"></span> <i class="s_jieguo">5</i></li><li>2＋1＝ <input type="text" size="2" zqda="3" onkeyup="quanjiao_zhuan_banjiao(this);" /><span class="daan_show"></span> <i class="s_jieguo">3</i></li><li>1＋1＝ <input type="text" size="2" zqda="2" onkeyup="quanjiao_zhuan_banjiao(this);" /><span class="daan_show"></span> <i class="s_jieguo">2</i></li><li>2＋2＝ <input type="text" size="2" zqda="4" onkeyup="quanjiao_zhuan_banjiao(this);" /><span class="daan_show"></span> <i class="s_jieguo">4</i></li></ul><div id="jst_dibu_tishi">※总分：100分， 共计：10道题， 每题：10分。</div></div>

     </div>
    <div id="control_frame">
 
    
        
        
    
        <form id="form1_Prac" runat="server">
        <asp:Button ID="Button1_Practice" runat="server" OnClick="Submit_Click_Prac" Text="提交试题" />
        <asp:Button ID="Button2_Practice" runat="server" OnClick="Back2Menu_Click_Prac" Text="返回" />
        <!--<asp:Label ID="Label1_Prac" runat="server" Text="Label"></asp:Label> -->
        </form>
        
    </div>
   

</body>
</html>
