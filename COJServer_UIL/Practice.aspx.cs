using CalculateOnlineJudge.BusinessLogic_BLL;
using CalculateOnlineJudge.Entity;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Timers;
using System.Diagnostics;

namespace COJServer_UIL
{
    public partial class Practice : System.Web.UI.Page
    {
        public string Username;
        private string UserId;
        private string Time;
        private string Type;
        private string Quantity;
        private string Interval;
        private ExerciseOption ExerciseOp;
        private IntervalType IntervalTp;
        private QuantityType QuantityTp;
        private int num;
        private OperationResult<Exercise> ExerciseOR;
        public int jstime;
        public object jssender;
        public EventArgs jse;
        //private System.Timers.Timer Timer;

        
        
        

        protected void Page_load(object sender, EventArgs e)
        {
            jssender = sender;
            jse = e;

            {


                Username = Request.QueryString["user"];
                UserId = Request.QueryString["id"];
                Time = Request.QueryString["time"];
                Type = Request.QueryString["type"];
                Quantity = Request.QueryString["quan"];
                Interval = Request.QueryString["intvl"];
                int inttime;

                switch (Interval)
                {
                    case "A": IntervalTp = IntervalType.LE10; break;
                    case "B": IntervalTp = IntervalType.LE20; break;
                    case "C": IntervalTp = IntervalType.LE50; break;
                    case "D": IntervalTp = IntervalType.LE100; break;
                    default: break;
                }

                switch (Quantity)
                {
                    case "A": QuantityTp = QuantityType.E10; break;
                    case "B": QuantityTp = QuantityType.E30; break;
                    case "C": QuantityTp = QuantityType.E50; break;
                    case "D": QuantityTp = QuantityType.E100; break;
                    default: break;
                }

                switch (Type)
                {
                    case "A": ExerciseOp = new ExerciseOption(IntervalTp, OperationType.Plus | OperationType.Sub, QuantityTp); break;
                    case "B": ExerciseOp = new ExerciseOption(IntervalTp, OperationType.Mul | OperationType.Div, QuantityTp); break;
                    case "C": ExerciseOp = new ExerciseOption(IntervalTp, OperationType.Plus | OperationType.Sub | OperationType.Mul | OperationType.Div, QuantityTp); break;
                    case "D": ExerciseOp = new ExerciseOption(IntervalTp, OperationType.DivWithRemainder, QuantityTp); break;
                    default: break;
                }
                switch (Time)
                {
                    case "A": inttime = 5; break;
                    case "B": inttime = 10; break;
                    case "C": inttime = 1800; break;
                    case "D": inttime = 3600; break;
                    default: inttime = 0; break;
                }
                jstime = inttime;

                if (!IsPostBack)
                {
                    ExerciseOR = ExerciseLogic.GetExercise(ExerciseOp);
                    Session["ExerciseORSession"] = ExerciseOR;
                    Debug.WriteLine("if");
                    //Timer = new System.Timers.Timer(inttime);
                }
                else
                {
                    ExerciseOR = (OperationResult<Exercise>)Session["ExerciseORSession"];
                    Debug.WriteLine("else");
                }
                    

                
                Label2.Text = Type;
                Label1.Text = ExerciseOR.Prompt;

                num = ExerciseOR.Result.ExerciseUnits.Length;
                Debug.WriteLine("106");

                for (int i = 0; i < num; i++)
                {
                    HtmlGenericControl li = new HtmlGenericControl("li");
                    li.InnerText = ExerciseOR.Result.ExerciseUnits[i].Topic;

                    TextBox t = new TextBox();
                    t.ID = "result" + i.ToString();
                    t.Attributes["class"] = "textbox";


                    Label l = new Label();
                    l.ID = "dynalabel" + i.ToString();
                    l.Attributes["class"] = "exercisetext";

                    li.Controls.Add(t);
                    if (Type == "D")
                    {
                        TextBox trm = new TextBox();
                        trm.ID = "remainder" + i.ToString();
                        trm.Attributes["class"] = "textbox";
                        li.Controls.Add(trm);
                    }

                    li.Controls.Add(l);

                    Exlist.Controls.Add(li);
                    //Exlist.Controls.Add(t);
                    Debug.WriteLine("135");
                }
                /*
                if (!IsPostBack)
                {
                    Timer.Interval = 1000;
                    Timer.Elapsed += new System.Timers.ElapsedEventHandler(Time_Remainder);
                    Timer.Enabled = true;
                    Timer.AutoReset = true;
                }
                */

                //CreateTextBoxList(num);
                Debug.WriteLine("148");

            }
        }
        protected void Back2Menu_Click_Prac(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }
        protected void JsFunction()
        {
            Submit_Prac(jssender, jse);
        }
        protected void Submit_Prac(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            {

                Debug.WriteLine("Submit_Prac_Start");
                TextBox txt;
                //HtmlGenericControl p = new HtmlGenericControl("p");

                ExerciseResult ExerciseResult = new ExerciseResult()
                {
                    ExerciseResultUnit = new ExerciseResultUnit[num]
                };

                for (int i = 0; i < num; i++)
                {
                    txt = exercise_frame.FindControl("result" + i.ToString()) as TextBox;
                    ExerciseResult.ExerciseResultUnit[i].Remainder = 0;
                    if (Regex.IsMatch(txt.Text, @"^[_0-9]{1,20}$"))
                        ExerciseResult.ExerciseResultUnit[i].Result = Convert.ToInt32(txt.Text);
                    else
                        ExerciseResult.ExerciseResultUnit[i].Result = -1;
                }

                if (Type == "D")
                {
                    for (int i = 0; i < num; i++)
                    {
                        txt = exercise_frame.FindControl("remainder" + i.ToString()) as TextBox;
                        if (Regex.IsMatch(txt.Text, @"^[_0-9]{1,20}$"))
                            ExerciseResult.ExerciseResultUnit[i].Remainder = Convert.ToInt32(txt.Text);
                        else
                            ExerciseResult.ExerciseResultUnit[i].Remainder = -1;
                    }
                }
                CalculateOnlineJudge.Entity.User user = new CalculateOnlineJudge.Entity.User(Convert.ToInt32(UserId), Username);
                var judgeResult = ExerciseLogic.JudgeExercise(ExerciseOR.Result, ExerciseResult, user);
                Label2.Text = judgeResult.Prompt;

                for (int i = 0; i < num; i++)
                {
                    Label jdglabel;
                    jdglabel = exercise_frame.FindControl("dynalabel" + i.ToString()) as Label;
                    jdglabel.Text = "√";
                }
                for (int i = 0; i < judgeResult.Result.ErrorExerciseIndex.Length; i++)
                {
                    Label jdglabel;
                    jdglabel = exercise_frame.FindControl("dynalabel" + judgeResult.Result.ErrorExerciseIndex[i].ToString()) as Label;
                    jdglabel.Text = "×";
                }
                

                //Label3.Text = judgeResult.Result.TotalNum.ToString();
                Label4.Text = judgeResult.Result.ErrorNum.ToString();
            }
            
        }
        

    }
}