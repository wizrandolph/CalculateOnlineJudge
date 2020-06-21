using CalculateOnlineJudge.BusinessLogic_BLL;
using CalculateOnlineJudge.Entity;
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
        protected CalculateOnlineJudge.Entity.User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            UserName = Request.QueryString["name"];
            UserId = Request.QueryString["id"];
            user = new CalculateOnlineJudge.Entity.User(Convert.ToInt32(UserId), UserName);
            Label1_Menu.Text = "当前用户： "+UserName;
        }

        
        protected void Go2Practice(object sender, EventArgs e)
        {
            string url = "SetPrac.aspx?username=" + UserName +"&id="+UserId;
            Response.Redirect(url);
        }
        protected void Go2History(object sender, EventArgs e)
        {
            string url = "History.aspx?username=" + UserName + "&id=" + UserId;
            Response.Redirect(url);
        }
        protected void GetMyInfo(object sender, EventArgs e)
        {
            string url = "UserInfo.aspx?username=" + UserName + "&id=" + UserId;
            Response.Redirect(url);
        }
        protected void DeleteAccount(object sender, EventArgs e)
        {
            OperationResult deleteOR;
            deleteOR = UserLogic.DeleteUser(user);
            MessaegBox(deleteOR.Prompt);
            System.Threading.Thread.Sleep(5000);
            Server.Transfer("Index.aspx");
        }
        protected void Logoff(object sender, EventArgs e)
        {
            Context.Session.Clear();    //从会话状态集合中移除所有的键和值
            Context.Session.Abandon();  //取消当前会话
            Server.Transfer("Index.aspx");

        }
        protected void AboutUs(object sender, EventArgs e)
        {
            string url = "AboutUs.aspx?username=" + UserName + "&id=" + UserId;
            Response.Redirect(url);
        }
        private void MessaegBox(string msg)
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "js", "<script>alert('" + msg + "');</script>");
        }
    }
}