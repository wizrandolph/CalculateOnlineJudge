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
        private string UserName;
        private string UserId;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserName = Request.QueryString["username"];
            UserId = Request.QueryString["id"];
        }
        protected void Go2Prac_Click_PracSet(object sender, EventArgs e)
        {
            string practiceType = Request.Form.Get("selectType");
            string practiceTime = Request.Form.Get("selectTime");
            string practiceQuantity = Request.Form.Get("selectQuantity");
            string practiceInterval = Request.Form.Get("selectInterval");
            string url = "Practice.aspx?user=" + UserName + "&time=" + practiceTime + "&type=" + practiceType + "&quan=" + practiceQuantity + "&intvl=" + practiceInterval +"&id="+UserId;
            Response.Redirect(url);
            //Label1.Text = practiceQuantity;
        }
        protected void Back2Menu_Click_PracSet(object sender, EventArgs e)
        {
            string url = "Menu.aspx?user=" + UserName + "&id=" + UserId;
            Response.Redirect(url);
        }
    }
}