using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CalculateOnlineJudge.BusinessLogic_BLL;
using CalculateOnlineJudge.Entity;

namespace COJServer_UIL
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click_Account(object sender, EventArgs e)
        {
            string Username_signup = UserName.Text;
            string Password_signup = Password.Text;
            Label2_A.Text = "上次登录账号："+Username_signup;
            Label3_A.Text = "上次登录密码："+Password_signup;
            var OR = UserLogic.CreateUser(Username_signup, Password_signup);
            string prompt = OR.Prompt;
            Label1_Account.Text = "上次登陆结果："+prompt;

        }
    }
}