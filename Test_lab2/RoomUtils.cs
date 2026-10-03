using System;
using System.Collections.Generic;
using System.Text;

namespace Test_lab2
{
    public class RealNumber
    {
        public double Value { get; set; }

        public double Round(int digits) => Math.Round(Value, digits);
        public double GetIntegerPart() => Math.Truncate(Value);
        public double GetFractionalPart() => Value - Math.Truncate(Value);
    }
}
