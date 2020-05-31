using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateOnlineJudge.Entity;

namespace CalculateOnlineJudge.ExerciseGeneratorAccess_DAL
{
    public sealed class GeneratorParser
    {
        public static GeneratorUnit GetGenerator(OperationType operationType, IntervalType intervalType)
        {
            switch (operationType)
            {
                case OperationType.Plus:
                    return new PlusGenerator(intervalType);
                case OperationType.Sub:
                    return new SubGenerator(intervalType);
                case OperationType.Mul:
                    return new MulGenerator(intervalType);
                case OperationType.Div:
                    return new DivGenerator(intervalType);
                case OperationType.DivWithRemainder:
                    return new DivWithRemainderGenerator(intervalType);
                default:
                    return new PlusGenerator(intervalType);
            }
        }
    }
}
