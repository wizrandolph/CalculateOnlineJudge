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

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userName = "FREEstrikerABbos";
            string password = "1236zccg99326TEST";
            var OR = UserLogic.CreateUser(userName, password);
            Label1.Text = OR.Prompt;
        }
    }
}