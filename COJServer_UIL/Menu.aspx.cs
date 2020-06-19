using CalculateOnlineJudge.BusinessLogic_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COJServer_UIL
{
    public partial class Menu : System.Web.UI.Page
    {
        private string UserId;
        private string UserName;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserName = Request.QueryString["name"];
            UserId = Request.QueryString["id"];

        }

        
        protected void Go2Practice(object sender, EventArgs e)
        {
            string url = "SetPrac.aspx?username=" + UserName +"&id="+UserId;
            Response.Redirect(url);
            //Server.Transfer("SetPrac.aspx");
        }
        protected void Go2History(object sender, EventArgs e)
        {
            Server.Transfer("History.aspx");
        }
        protected void GetMyInfo(object senderm, EventArgs e)
        {

        }
    }
}