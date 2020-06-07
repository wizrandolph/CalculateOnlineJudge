using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculateOnlineJudge.DataBaseAccessFactory_DAL;
using CalculateOnlineJudge.Entity;
using System.Threading.Tasks;
using CalculateOnlineJudge.ExerciseGeneratorAccessFactory_DAL;

namespace CalculateOnlineJudge.BusinessLogic_BLL
{
    public sealed class ExerciseLogic
    {
        private ExerciseLogic() { }
        public static OperationResult<JudgeResult> JudgeExercise(Exercise exercise, ExerciseResult exerciseResult, User user)
        {
            JudgeResult judgeResult = null;
            try
            {
                judgeResult = ExerciseGeneratorFactory.DriveGenerator().JudgeExercise(exercise, exerciseResult);
                JudgeInfo judgeInfo = DataBaseFactory.DriveDataBase().GetJudgeInfo(user.UserID);
                if(judgeInfo == null)
                {
                    return new OperationResult<JudgeResult>("批改失败！", true, null);
                }
                judgeInfo.QuestionNum += judgeResult.TotalNum;
                judgeInfo.QuestionErrorNum += judgeResult.ErrorNum;
                judgeInfo.LastestCompleteTime = DateTime.Now;
                if(!JudgeInfoLogic.UpdateJudgeInfo(judgeInfo, user))
                {
                    return new OperationResult<JudgeResult>("更改批改信息失败！", true, null);
                }
            }
            catch (Exception e)
            {
                return new OperationResult<JudgeResult>("批改失败！" + e.Message, true, null);
            }
            return new OperationResult<JudgeResult>("批改成功！", true, judgeResult);
        }
        public static OperationResult<Exercise> GetExercise(ExerciseOption exerciseOption)
        {
            Exercise exercise = null;
            try
            {
                exercise = ExerciseGeneratorFactory.DriveGenerator().GetExercise(exerciseOption);
            }
            catch (Exception e)
            {
                return new OperationResult<Exercise>("生成失败！" + e.Message, true, null);
            }
            return new OperationResult<Exercise>("生成成功！", true, exercise);
        }
    }
}
