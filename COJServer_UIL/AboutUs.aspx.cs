using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COJServer_UIL
{
    public partial class AboutUs : System.Web.UI.Page
    {
        private string UserName;
        private string UserId;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserName = Request.QueryString["username"];
            UserId = Request.QueryString["id"];
        }
        protected void Back2Menu(object sender, EventArgs e)
        {
            string url = "Menu.aspx?name=" + UserName + "&id=" + UserId;
            Response.Redirect(url);
        }
    }
}