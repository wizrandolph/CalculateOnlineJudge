using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COJServer_UIL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Go2Prac_Click_PracSet(object sender, EventArgs e)
        {
            //string practiceType = Request.Form.Get("selectType");
            //string practiceTime = Request.Form.Get("selectTime");
            Server.Transfer("Practice.aspx");
            //Label1_PracSet.Text = practiceTime;
        }
        protected void Back2Menu_Click_PracSet(object sender, EventArgs e)
        {
            //Response.Write("<script languge='javascript'>alert('成功改动');");
            Server.Transfer("Menu.aspx");

        }
    }
}