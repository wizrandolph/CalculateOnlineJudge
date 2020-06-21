using CalculateOnlineJudge.BusinessLogic_BLL;
using CalculateOnlineJudge.Entity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COJServer_UIL
{
    public partial class UserInfo : System.Web.UI.Page
    {
        protected OperationResult<CalculateOnlineJudge.Entity.UserInfo> userinfoOR;
        protected OperationResult updateresult;
        protected string lastphone;
        protected string lastemail;
        CalculateOnlineJudge.Entity.User user;
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.QueryString["username"];
            string id = Request.QueryString["id"];
            Debug.WriteLine(username);
            Debug.WriteLine(id);
            user = new CalculateOnlineJudge.Entity.User(Convert.ToInt32(id), username);
            userinfoOR = UserInfoLogic.GetUserInfo(user);
            Debug.WriteLine(userinfoOR.Prompt);
            if (!IsPostBack)
            {
                if (userinfoOR.Result.Phone != null)
                    newphone.Text = userinfoOR.Result.Phone;
                else
                    newphone.Text = null;
                if (userinfoOR.Result.Email != null)
                    newemail.Text = userinfoOR.Result.Email;
                else
                    newemail.Text = null;
                lastphone = userinfoOR.Result.Phone;
                lastemail = userinfoOR.Result.Email;
                Session["LastPhone"] = lastphone;
                Session["LastEmail"] = lastemail;
                Debug.WriteLine("加载页面");
                Debug.WriteLine("getphone=" + userinfoOR.Result.Phone);
                Debug.WriteLine("getemail=" + userinfoOR.Result.Email);
            }

        }
        protected void Change_Submit(object sender, EventArgs e)
        {
            string nphone = newphone.Text;
            string nemail = newemail.Text;
            Debug.WriteLine("beforupdatephone=" + nphone);
            Debug.WriteLine("befupdateemail=" + nemail);
            DateTime? nbirth = null;
            CalculateOnlineJudge.Entity.UserInfo nuserinfo = new CalculateOnlineJudge.Entity.UserInfo(nbirth,nphone,nemail);
            updateresult = UserInfoLogic.UpdateUserInfo(nuserinfo, user);
            if(!updateresult.IsSuccess)
            {
                newphone.Text = Session["LastPhone"].ToString();
                newemail.Text = Session["LastEmail"].ToString();
            }
            else
            {
                Session["LastPhone"]=newphone.Text;
                Session["LastEmail"]=newemail.Text;
            }
            Debug.WriteLine("aftupdatephone=" + nphone);
            Debug.WriteLine("aftupdateemail=" + nemail);
            MessaegBox(updateresult.Prompt);
        }
        private void MessaegBox(string msg)
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "js", "<script>alert('" +msg+ "');</script>");
        }

    }
}