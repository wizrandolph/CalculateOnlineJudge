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
            Label1_Account.Text = "用户名：或大写字母或小写字母或数字或中文，共6-20位\n密码：必须包含数字和小写字母和大写字母，共8-20位";
        }
        protected void Button1_Click_Account(object sender, EventArgs e)
        {
            string Username_signup = UserName.Text;
            string Password_signup = Password.Text;
            var OR = UserLogic.CreateUser(Username_signup, Password_signup);
            MessaegBox(OR.Prompt);
            Label1_Account.Text = OR.Prompt;
            System.Threading.Thread.Sleep(5000);
            if (OR.IsSuccess == true)
            {
                Server.Transfer("Index.aspx");
            }
        }
        private void MessaegBox(string msg)
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "js", "<script>alert('" + msg + "');</script>");
        }
    }
}