using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateOnlineJudge.Entity;

namespace CalculateOnlineJudge.ExerciseGeneratorAccess_DAL
{
    public abstract class GeneratorUnit
    {
        private Random random;
        private int start, end;

        public IntervalType IntervalType { get; private set; }
        public abstract OperationType OperationType { get; }

        protected abstract void OnGenerate(ref ExerciseUnit exerciseUnit);
        protected virtual void OnStartGenerate()
        {

        }
        protected virtual void OnEndGenerate()
        {

        }
        protected virtual void OnGetRandom(out Random random)
        {
            random = new Random(new Guid().GetHashCode());
        }
        protected virtual void OnSetNumInterval(out int start, out int end)
        {
            IntervalParser.GetInterval(IntervalType, out start, out end);
        }

        public void Generate(ref ExerciseUnit exerciseUnit)
        {
            OnGetRandom(out random);
            OnSetNumInterval(out start, out end);
            OnStartGenerate();
            OnGenerate(ref exerciseUnit);
            OnEndGenerate();
        }
        public GeneratorUnit(IntervalType intervalType)
        {
            IntervalType = intervalType;
        }
        protected int GetNum()
        {
            return random.Next(start, end);
        }
    }
    public sealed class PlusGenerator : GeneratorUnit
    {
        public PlusGenerator(IntervalType intervalType) : base(intervalType)
        {
        }

        public override OperationType OperationType { get { return OperationType.Plus; } }

        protected override void OnGenerate(ref ExerciseUnit exerciseUnit)
        {
            int a = GetNum();
            int b = GetNum();
            int c = a + b;
            string s = $"{a}+{b}=";
            exerciseUnit = new ExerciseUnit(s, c, 0, OperationType);
        }
    }
    public sealed class SubGenerator : GeneratorUnit
    {
        public SubGenerator(IntervalType intervalType) : base(intervalType)
        {
        }

        public override OperationType OperationType { get { return OperationType.Sub; } }

        protected override void OnGenerate(ref ExerciseUnit exerciseUnit)
        {
            int a = GetNum();
            int b = GetNum();
            int c = a + b;
            string s = $"{c}-{a}=";
            exerciseUnit = new ExerciseUnit(s, b, 0, OperationType);
        }
    }
    public sealed class MulGenerator : GeneratorUnit
    {
        public MulGenerator(IntervalType intervalType) : base(intervalType)
        {
        }

        public override OperationType OperationType { get { return OperationType.Mul; } }

        protected override void OnGenerate(ref ExerciseUnit exerciseUnit)
        {
            int a = GetNum();
            int b = GetNum();
            int c = a * b;
            string s = $"{a}*{b}=";
            exerciseUnit = new ExerciseUnit(s, c, 0, OperationType);
        }
    }
    public sealed class DivGenerator : GeneratorUnit
    {
        public DivGenerator(IntervalType intervalType) : base(intervalType)
        {
        }

        public override OperationType OperationType { get { return OperationType.Div; } }

        protected override void OnGenerate(ref ExerciseUnit exerciseUnit)
        {
            int a = GetNum();
            int b = GetNum();
            int c = a * b;
            string s = $"{c}÷{a}=";
            exerciseUnit = new ExerciseUnit(s, b, 0, OperationType);
        }
    }
    public sealed class DivWithRemainderGenerator : GeneratorUnit
    {
        public DivWithRemainderGenerator(IntervalType intervalType) : base(intervalType)
        {
        }

        public override OperationType OperationType { get { return OperationType.DivWithRemainder; } }

        protected override void OnGenerate(ref ExerciseUnit exerciseUnit)
        {
            int max = GetNum();
            int mid = GetNum();
            int min = GetNum();
            if (max < mid) { int t = max; max = mid; mid = t; }
            if (max < min) { int t = max; max = min; min = t; }
            if (mid < min) { int t = mid; mid = min; min = t; }
            int d = mid + max + min;
            string s = $"{d}÷{mid}=";
            exerciseUnit = new ExerciseUnit(s, max, min, OperationType);
        }
    }
}
