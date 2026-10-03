using System;
using System.Collections.Generic;
using System.Text;

namespace Test_lab2
{
    public class RoomUtils
    {
        public double GetAreaPerPerson(double length, double width, int peopleCount)
        {
            if (length <= 0 || width <= 0 || peopleCount <= 0) return 0;
            return (length * width) / peopleCount;
        }
    }
}
