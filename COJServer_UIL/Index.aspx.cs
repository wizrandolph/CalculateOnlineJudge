using CalculateOnlineJudge.BusinessLogic_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COJServer_UIL
{
    public partial class Test1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click_Index(object sender, EventArgs e)
        {
            string UserName = Request.Form.Get("username");
            string Password = Request.Form.Get("password");
            //string username = this.username
            var userOR = UserLogic.LogInUser(UserName, Password);
            var userInfoOR = UserInfoLogic.GetUserInfo(userOR.Result);
            string prompt = userInfoOR.Prompt;
            Label1_Index.Text = UserName;
        }
        protected void Button1_Click_Index(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx"); 
        }
        protected void Button3_Click_Index(object sender, EventArgs e)
        {
            Server.Transfer("Account.aspx");
        }
    }
}