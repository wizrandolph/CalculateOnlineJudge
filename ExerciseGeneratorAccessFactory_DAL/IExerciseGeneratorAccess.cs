using CalculateOnlineJudge.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.DataBaseAccessFactory_DAL
{
    public interface IExerciseGeneratorAccess
    {
        Exercise GetExercise(ExerciseOption exerciseOption);
        ExerciseResult JudgeExercise(Exercise exercise);
    }
}
