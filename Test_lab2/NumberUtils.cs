using System;
using System.Collections.Generic;
using System.Text;

namespace Test_lab2
{
    public class NumberUtils
    {
        public int ReverseNumber(int number)
        {
            int reversed = 0;
            int temp = number;
            while (temp != 0)
            {
                int remainder = temp % 10;
                reversed = reversed * 10 + remainder;
                temp /= 10;
            }
            return reversed;
        }
    }
}
