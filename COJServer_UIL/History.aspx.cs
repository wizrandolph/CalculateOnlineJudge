using CalculateOnlineJudge.BusinessLogic_BLL;
using CalculateOnlineJudge.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COJServer_UIL
{
    
    public partial class History : System.Web.UI.Page
    {
        protected string username;
        protected string id;
        protected CalculateOnlineJudge.Entity.User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            username = Request.QueryString["username"];
            id = Request.QueryString["id"];
            Debug.WriteLine(username);
            Debug.WriteLine(id);
            user = new CalculateOnlineJudge.Entity.User(Convert.ToInt32(id), username);
            OperationResult<JudgeInfo> judgeInfoOR = JudgeInfoLogic.GetJudgeInfo(user);
            JudgeInfo judgeInfo = judgeInfoOR.Result;
            Label1.Text = "总答题数"+judgeInfo.QuestionNum.ToString();
            Label2.Text = "错题数"+judgeInfo.QuestionErrorNum.ToString();
            Label3.Text = "正确率"+judgeInfo.CorrectRate.ToString();
            Label4.Text = "错误率"+judgeInfo.ErrorRate.ToString();
            Label5.Text = "最后答题时间\n"+judgeInfo.LastestCompleteTime.ToString();
        }

        protected void Back2Menu_History(object sender, EventArgs e)
        {
            string url = "Menu.aspx?name=" + username + "&id=" + id;
            Response.Redirect(url);
        }
    }
}