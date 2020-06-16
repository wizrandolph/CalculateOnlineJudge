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
        

        protected void Button1_Click_Menu(object sender, EventArgs e)
        {
            string userName = "FREEstrikerABbos";
            string password = "1236zccg99326TEST";
            var OR = UserLogic.CreateUser(userName, password);
            string prompt = OR.Prompt;
            //Test1.Label1.Text = prompt;
        }
        protected void Go2Practice(object sender, EventArgs e)
        {
            Server.Transfer("PracticeSet.aspx");
        }
        protected void Go2History(object sender, EventArgs e)
        {

        }
    }
}