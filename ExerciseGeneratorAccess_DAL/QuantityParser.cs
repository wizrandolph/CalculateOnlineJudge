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
                case QuantityType.E20:
                    quantites[0] = 20;
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
            if ((operationType & OperationType.Sub) == OperationType.Plus) operationCount++;
            if ((operationType & OperationType.Mul) == OperationType.Plus) operationCount++;
            if ((operationType & OperationType.Div) == OperationType.Plus) operationCount++;
            if ((operationType & OperationType.DivWithRemainder) == OperationType.Plus) operationCount++;
            int countPerOperation = quantites[0] / operationCount;
            int remainder = quantites[0] % operationCount;
            if ((operationType & OperationType.Plus) == OperationType.Plus) quantites[1] = operationCount;
            if ((operationType & OperationType.Sub) == OperationType.Plus) quantites[2] = operationCount;
            if ((operationType & OperationType.Mul) == OperationType.Plus) quantites[3] = operationCount;
            if ((operationType & OperationType.Div) == OperationType.Plus) quantites[4] = operationCount;
            if ((operationType & OperationType.DivWithRemainder) == OperationType.Plus) quantites[5] = operationCount;
            for (int i = 1; i < quantites.Length; i++)
            {
                quantites[i] += quantites[i] > 0 ? remainder : 0;
            }
            return quantites;
        }
    }
}
