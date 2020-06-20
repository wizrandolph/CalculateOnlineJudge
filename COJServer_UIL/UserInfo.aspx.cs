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
            if (userinfoOR.Result.Phone != null)
                phone.Text = "电话："+userinfoOR.Result.Phone;
            else
                phone.Text = "电话：暂无信息";
            if (userinfoOR.Result.Email != null)
                email.Text = "邮箱："+userinfoOR.Result.Email;
            else
                email.Text = "邮箱：暂无信息";

            Debug.WriteLine("email_load");
            if (userinfoOR.Result.Birthday != null)
                birthday.Text = "生日："+userinfoOR.Result.Birthday.ToString();
            else
                birthday.Text = "生日：暂不可用";

            Debug.WriteLine("birth_load");

        }
        protected void Change_Submit(object sender, EventArgs e)
        {
            string nphone = newphone.Text;
            string nemail = newemail.Text;
            DateTime? nbirth = null;
            CalculateOnlineJudge.Entity.UserInfo nuserinfo = new CalculateOnlineJudge.Entity.UserInfo(nbirth,nphone,nemail);
            updateresult = UserInfoLogic.UpdateUserInfo(nuserinfo, user);
            Debug.WriteLine(updateresult.Prompt);
            MessaegBox(updateresult.Prompt);
        }
        private void MessaegBox(string msg)
        {
            Page.ClientScript.RegisterClientScriptBlock(GetType(), "js", "<script>alert('" +msg+ "');</script>");
        }

    }
}