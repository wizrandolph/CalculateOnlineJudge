using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateOnlineJudge.Entity;

namespace CalculateOnlineJudge.ExerciseGeneratorAccess_DAL
{
    public sealed class QuantityParser
    {
        public static int[] GetQuantity(QuantityType quantityType, OperationType operationType)
        {
            int[] quantites = new int[6];
            int operationCount = 0;
            switch (quantityType)
            {
                case QuantityType.E10:
                    quantites[0] = 10;
                    break;
                case QuantityType.E30:
                    quantites[0] = 30;
                    break;
                case QuantityType.E50:
                    quantites[0] = 50;
                    break;
                case QuantityType.E100:
                    quantites[0] = 100;
                    break;
                default:
                    quantites[0] = 20;
                    break;
            }
            if ((operationType & OperationType.Plus) == OperationType.Plus) operationCount++;
            if ((operationType & OperationType.Sub) == OperationType.Sub) operationCount++;
            if ((operationType & OperationType.Mul) == OperationType.Mul) operationCount++;
            if ((operationType & OperationType.Div) == OperationType.Div) operationCount++;
            if ((operationType & OperationType.DivWithRemainder) == OperationType.Plus) operationCount++;
            int countPerOperation = quantites[0] / operationCount;
            int remainder = quantites[0] % operationCount;
            if ((operationType & OperationType.Plus) == OperationType.Plus) quantites[1] = countPerOperation;
            if ((operationType & OperationType.Sub) == OperationType.Sub) quantites[2] = countPerOperation;
            if ((operationType & OperationType.Mul) == OperationType.Mul) quantites[3] = countPerOperation;
            if ((operationType & OperationType.Div) == OperationType.Div) quantites[4] = countPerOperation;
            if ((operationType & OperationType.DivWithRemainder) == OperationType.DivWithRemainder) quantites[5] = countPerOperation;
            for (int i = 1; i < quantites.Length; i++)
            {
                if(quantites[i] > 0)
                {
                    quantites[i] += remainder;
                    break;
                }
            }
            return quantites;
        }
    }
}
