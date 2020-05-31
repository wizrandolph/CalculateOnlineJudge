using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateOnlineJudge.Entity;

namespace CalculateOnlineJudge.ExerciseGeneratorAccess_DAL
{
    public sealed class IntervalParser
    {
        public static void GetInterval(IntervalType intervalType,out int start, out int end)
        {
            switch (intervalType)
            {
                case IntervalType.LE10:
                    start = 1;
                    end = 10;
                    break;
                case IntervalType.LE20:
                    start = 1;
                    end = 20;
                    break;
                case IntervalType.LE50:
                    start = 1;
                    end = 50;
                    break;
                case IntervalType.LE100:
                    start = 1;
                    end = 100;
                    break;
                default:
                    start = 1;
                    end = 10;
                    break;
            }
        }
    }
}
