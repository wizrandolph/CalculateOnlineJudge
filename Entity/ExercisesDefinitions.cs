using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.Entity
{
    public class ExerciseOption
    {
        private IntervalType resultIntervalType;
        private OperationType operationType;
        private QuantityType quantityType;

        public ExerciseOption(IntervalType resultIntervalType, OperationType operationType, QuantityType quantityType)
        {
            this.resultIntervalType = resultIntervalType;
            this.operationType = operationType;
            this.quantityType = quantityType;
        }

        public IntervalType ResultIntervalType { get => resultIntervalType; set => resultIntervalType = value; }
        public OperationType OperationType { get => operationType; set => operationType = value; }
        public QuantityType QuantityType { get => quantityType; set => quantityType = value; }
    }
    public struct ExerciseUnit
    {
        private readonly string topic;
        private readonly int result;
        private readonly int remainder;
        private readonly OperationType operationType;

        public ExerciseUnit(string topic, int result, int remainder, OperationType operationType)
        {
            this.topic = topic;
            this.result = result;
            this.remainder = remainder;
            this.operationType = operationType;
        }

        public string Topic { get => topic;}
        public int Result { get => result;}
        public int Remainder { get => remainder;}
        public OperationType OperationType { get => operationType;}
    }
    public class Exercise
    {
        private DateTime startTime;
        private OperationType containedOperationType;
        private IntervalType resultIntervalType;
        private QuantityType quantityType;
        private ExerciseUnit[] exerciseUnits;

        public Exercise(DateTime startTime, OperationType containedOperationType, IntervalType resultIntervalType, QuantityType quantityType, ExerciseUnit[] exerciseUnits)
        {
            this.startTime = startTime;
            this.containedOperationType = containedOperationType;
            this.resultIntervalType = resultIntervalType;
            this.quantityType = quantityType;
            this.exerciseUnits = exerciseUnits;
        }

        public DateTime StartTime { get => startTime;}
        public OperationType ContainedOperationType { get => containedOperationType;}
        public IntervalType ResultIntervalType { get => resultIntervalType;}
        public QuantityType QuantityType { get => quantityType;}
        public ExerciseUnit[] ExerciseUnits { get => exerciseUnits;}
        public int TotalNum { get => exerciseUnits.Length; }
    }
    public class JudgeResult
    {
        private int totalNum;
        private int errorNum;
        private DateTime startTime;
        private DateTime endTime;
        private ExerciseUnit[] errorExerciseUnit;
        private int[] errorExerciseIndex;

        public JudgeResult(int totalNum, int errorNum, DateTime startTime, DateTime endTime, ExerciseUnit[] errorExerciseUnit, int[] errorExerciseIndex)
        {
            this.totalNum = totalNum;
            this.errorNum = errorNum;
            this.startTime = startTime;
            this.endTime = endTime;
            this.errorExerciseUnit = errorExerciseUnit;
            this.errorExerciseIndex = errorExerciseIndex;
        }

        public int TotalNum { get => totalNum;}
        public int ErrorNum { get => errorNum;}
        public DateTime StartTime { get => startTime;}
        public DateTime EndTime { get => endTime;}
        public ExerciseUnit[] ErrorExerciseUnit { get => errorExerciseUnit;}
        public float CorrectRate { get => 1f - errorNum / totalNum; }
        public float ErrorRate { get => errorNum / totalNum; }
        public int[] ErrorExerciseIndex { get => errorExerciseIndex; }
    }
    public class ExerciseResult
    {
        private ExerciseResultUnit[] exerciseResultUnit;

        public ExerciseResultUnit[] ExerciseResultUnit { get => exerciseResultUnit; set => exerciseResultUnit = value; }
    }
    public struct ExerciseResultUnit
    {
        private int result;
        private int remainder;

        public int Result { get => result; set => result = value; }
        public int Remainder { get => remainder; set => remainder = value; }
    }
}
