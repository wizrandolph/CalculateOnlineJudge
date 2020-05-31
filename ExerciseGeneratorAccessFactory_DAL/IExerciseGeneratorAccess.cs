using CalculateOnlineJudge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.ExerciseGeneratorAccessFactory_DAL
{
    public interface IExerciseGeneratorAccess
    {
        Exercise GetExercise(ExerciseOption exerciseOption);
        JudgeResult JudgeExercise(Exercise exercise, ExerciseResult exerciseResult);
    }
}
