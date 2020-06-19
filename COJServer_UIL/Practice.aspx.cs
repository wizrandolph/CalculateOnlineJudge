using CalculateOnlineJudge.BusinessLogic_BLL;
using CalculateOnlineJudge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace COJServer_UIL
{
    public partial class Practice : System.Web.UI.Page
    {
        private string Username;
        private string Time;
        private string Type;
        private string Quantity;
        private string Interval;
        private ExerciseOption ExerciseOp;
        private IntervalType IntervalTp;
        private QuantityType QuantityTp;
        

        protected void Page_load(object sender, EventArgs e)
        {
            Username = Request.QueryString["user"];
            Time = Request.QueryString["time"];
            Type = Request.QueryString["type"];
            Quantity = Request.QueryString["quan"];
            Interval = Request.QueryString["intvl"];

            switch (Interval)
            {
                case "A": IntervalTp = IntervalType.LE10;break;
                case "B": IntervalTp = IntervalType.LE20;break;
                case "C": IntervalTp = IntervalType.LE50;break;
                case "D": IntervalTp = IntervalType.LE100;break;
                default: break;
            }

            switch (Quantity)
            {
                case "A": QuantityTp = QuantityType.E10;break;
                case "B": QuantityTp = QuantityType.E30;break;
                case "C": QuantityTp = QuantityType.E50;break;
                case "D": QuantityTp = QuantityType.E100;break;
                default: break;
            }

            switch (Type)
            {
                case "A": ExerciseOp = new ExerciseOption(IntervalTp, OperationType.Plus | OperationType.Sub, QuantityTp); break;
                case "B": ExerciseOp = new ExerciseOption(IntervalTp, OperationType.Mul | OperationType.Div, QuantityTp);break;
                case "C": ExerciseOp = new ExerciseOption(IntervalTp, OperationType.Plus | OperationType.Sub | OperationType.Mul | OperationType.Div, QuantityTp);break;
                case "D": ExerciseOp = new ExerciseOption(IntervalTp, OperationType.DivWithRemainder, QuantityTp);break;
                default: break;
            }
            var ExerciseOR = ExerciseLogic.GetExercise(ExerciseOp);
            
            for(int i=0;i<ExerciseOR.Result.ExerciseUnits.Length;i++)
            {
                HtmlGenericControl li = new HtmlGenericControl("li");
                li.InnerText = ExerciseOR.Result.ExerciseUnits[i].Topic;
                Exlist.Controls.Add(li);
            }
            
            //Debug Part
            Label1.Text = "题量"+Quantity;
            Label2.Text = "题型"+Type;
            Label3.Text = "范围"+Interval;


            
        }
        


        protected void Button1_Click_Prac(object sender, EventArgs e)
        {
            

        }
        protected void Back2Menu_Click_Prac(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }
        protected void Submit_Click_Prac(object sender, EventArgs e)
        {

        }
        protected void Submit_Timeover_Prac(object sender)
        {

        }
    }
}