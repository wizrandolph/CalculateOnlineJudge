using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateOnlineJudge.BusinessLogic_BLL;
using CalculateOnlineJudge.Entity;

namespace CalculateOnlineJudge.ExampleTest_UIL
{
    public class Test
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("输入创建用户名，例如：FREEstrikerABbo");
            string userName = Console.ReadLine();
            Console.WriteLine("输入创建密码，例如：1236zccg99326TEST");
            string password = Console.ReadLine();
            Console.WriteLine(UserLogic.CreateUser(userName, password).Prompt);
            var userOR = UserLogic.LogInUser(userName, password);
            Console.WriteLine(userOR.Prompt);
            var userInfoOR = UserInfoLogic.GetUserInfo(userOR.Result);
            Console.WriteLine(userInfoOR.Prompt);
            var judgeInfoOR = JudgeInfoLogic.GetJudgeInfo(userOR.Result);
            Console.WriteLine(judgeInfoOR.Prompt);
            ExerciseOption exerciseOption = new ExerciseOption(IntervalType.LE10,
                OperationType.Plus |
                OperationType.Sub |
                OperationType.Mul |
                OperationType.Div, QuantityType.E10);
            var exerciseOR = ExerciseLogic.GetExercise(exerciseOption);
            Console.WriteLine(exerciseOR.Prompt);
            for (int i = 0; i < exerciseOR.Result.ExerciseUnits.Length; i++)
            {
                Console.WriteLine(exerciseOR.Result.ExerciseUnits[i].Topic);
            }
            Console.WriteLine("输入答案：");
            ExerciseResult exerciseResult = new ExerciseResult()
            {
                ExerciseResultUnit = new ExerciseResultUnit[exerciseOR.Result.ExerciseUnits.Length]
            };
            for (int i = 0; i < exerciseOR.Result.ExerciseUnits.Length; i++)
            {
                exerciseResult.ExerciseResultUnit[i].Remainder = 0;
                exerciseResult.ExerciseResultUnit[i].Result = Convert.ToInt32(Console.ReadLine());
            }
            var judgeResultOR = ExerciseLogic.JudgeExercise(exerciseOR.Result, exerciseResult, userOR.Result);
            Console.WriteLine(judgeResultOR.Prompt);
            userInfoOR = UserInfoLogic.GetUserInfo(userOR.Result);
            Console.WriteLine(userInfoOR.Prompt);
            judgeInfoOR = JudgeInfoLogic.GetJudgeInfo(userOR.Result);
            Console.WriteLine(judgeInfoOR.Prompt);
            Console.WriteLine(UserLogic.DeleteUser(userOR.Result).Prompt);
            Console.ReadKey();

        }
    }
}
