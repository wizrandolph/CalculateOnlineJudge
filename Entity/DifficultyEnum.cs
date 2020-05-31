using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.Entity
{
    public enum IntervalType
    {
        LE10,
        LE20,
        LE50,
        LE100
    }
    public enum OperationType
    {
        Plus = 1,
        Sub = 2,
        Mul = 4,
        Div = 8,
        DivWithRemainder = 16,
    }
    public enum QuantityType
    {
        E10,
        E30,
        E50,
        E100
    }
}
