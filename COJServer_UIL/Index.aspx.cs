using CalculateOnlineJudge.BusinessLogic_BLL;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
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
            bool checkname = Regex.IsMatch(UserName.Text, @"^[_A-Za-z0-9\u4E00-\u9FA5]{6,20}$");
            bool checkpwd = Regex.IsMatch(password, @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).{8,20}$");
            if (checkname && checkpwd)
            {
                var userOR = UserLogic.LogInUser(username, password);
                Debug.WriteLine(userOR.Prompt);
                CalculateOnlineJudge.Entity.User user = UserLogic.LogInUser(username, password).Result;
                if (user != null)
                {
                    string url = "Menu.aspx?name=" + user.UserName + "&id=" + user.UserID.ToString();
                    Response.Redirect(url);
                }
                else
                    MessaegBox(userOR.Prompt);
            }
            else MessaegBox("用户名：或大写字母或小写字母或数字或中文，共6-20位\n密码：必须包含数字和小写字母和大写字母，共8-20位");


        }
        protected void Button1_Click_Index(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx"); 
        }
        protected void Button3_Click_Index(object sender, EventArgs e)
        {
            Server.Transfer("Account.aspx");
        }
        private void MessaegBox(string msg)
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "js", "<script>alert('" + msg + "');</script>");
        }
    }
}