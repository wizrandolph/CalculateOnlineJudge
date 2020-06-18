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
        

        
        protected void Go2Practice(object sender, EventArgs e)
        {
            Server.Transfer("Webform1.aspx");
        }
        protected void Go2History(object sender, EventArgs e)
        {
            Server.Transfer("History.aspx");
        }
    }
}