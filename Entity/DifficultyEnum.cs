using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateOnlineJudge.Entity
{
    public enum ResultIntervalType
    {
        LE10,
        LE100,
        LE1000
    }
    public enum OperationType
    {
        Plus = 1,
        Sub = 2,
        Mul = 4,
        Div = 8,
        DivWithRemainder = 16,
        Mix = 32
    }
    public enum QuantityType
    {
        E20,
        E30,
        E50,
        E100
    }
}
