using CalculateOnlineJudge.BusinessLogic_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COJServer_UIL
{
    public partial class Index : System.Web.UI.Page
    {
        

        protected void Button2_Click_Index(object sender, EventArgs e)
        {
            string username = UserName.Text;
            string password = Password.Text;
            //string username = this.username
            var userOR = UserLogic.LogInUser(username, password);
            string prompt = userOR.Prompt;
            Label2_Index.Text = prompt;
            CalculateOnlineJudge.Entity.User user = UserLogic.LogInUser(username, password).Result;
            Label1_Index.Text = user.UserName;
            Label2_Index.Text = prompt;
            string url = "Menu.aspx?name=" + user.UserName;
            Response.Redirect(url);
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