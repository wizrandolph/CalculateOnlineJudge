using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COJServer_UIL
{
    public partial class SetPrac : System.Web.UI.Page
    {
        private string username;
        protected void Page_Load(object sender, EventArgs e)
        {
            username = Request.QueryString["username"];
        }
        protected void Go2Prac_Click_PracSet(object sender, EventArgs e)
        {
            string practiceType = Request.Form.Get("selectType");
            string practiceTime = Request.Form.Get("selectTime");
            string practiceQuantity = Request.Form.Get("selectQuantity");
            string practiceInterval = Request.Form.Get("selectInterval");
            string url = "Practice.aspx?user=" + username + "&time=" + practiceTime + "&type=" + practiceType + "&quan=" + practiceQuantity + "&intvl=" + practiceInterval;
            Response.Redirect(url);
            //Label1.Text = practiceQuantity;
        }
        protected void Back2Menu_Click_PracSet(object sender, EventArgs e)
        {
            //Response.Write("<script languge='javascript'>alert('成功改动');");
            Server.Transfer("Menu.aspx");

        }
    }
}