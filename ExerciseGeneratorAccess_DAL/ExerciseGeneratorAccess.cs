using CalculateOnlineJudge.Entity;
using CalculateOnlineJudge.ExerciseGeneratorAccessFactory_DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.ExerciseGeneratorAccess_DAL
{
    public class ExerciseGeneratorAccess : IExerciseGeneratorAccess
    {
        public Exercise GetExercise(ExerciseOption exerciseOption)
        {
            var quantites = QuantityParser.GetQuantity(exerciseOption.QuantityType, exerciseOption.OperationType);
            var exerciseUnits = new ExerciseUnit[quantites[0]];
            int index = 0;
            int enumIndex = 1;
            for (int i = 1; i < quantites.Length; i++)
            {
                OperationType t = (OperationType)enumIndex;
                for (int j = 0; j < quantites[i]; j++)
                {
                    GeneratorParser.GetGenerator(exerciseOption.OperationType & (OperationType)enumIndex, exerciseOption.ResultIntervalType).Generate(ref exerciseUnits[index++]);
                }
                enumIndex *= 2;
            }
            return new Exercise(DateTime.Now, exerciseOption.OperationType, exerciseOption.ResultIntervalType, exerciseOption.QuantityType, exerciseUnits);
        }


        public JudgeResult JudgeExercise(Exercise exercise, ExerciseResult exerciseResult)
        {
            List<ExerciseUnit> exerciseUnits = new List<ExerciseUnit>();
            List<int> exerciseIndex = new List<int>();
            int errorNum = 0;
            for (int i = 0; i < exercise.ExerciseUnits.Length; i++)
            {
                if(exercise.ExerciseUnits[i].Result == exerciseResult.ExerciseResultUnit[i].Result
                    && exercise.ExerciseUnits[i].Remainder == exerciseResult.ExerciseResultUnit[i].Remainder)
                {

                }
                else
                {
                    errorNum++;
                    exerciseUnits.Add(exercise.ExerciseUnits[i]);
                    exerciseIndex.Add(i);
                }
            }

            return new JudgeResult(exercise.TotalNum, errorNum, exercise.StartTime, DateTime.Now, exerciseUnits.ToArray(), exerciseIndex.ToArray());
        }
    }
}
