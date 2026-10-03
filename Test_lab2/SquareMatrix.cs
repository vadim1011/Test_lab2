using System;
using System.Collections.Generic;
using System.Text;

namespace Test_lab2
{
    public class SquareMatrix
    {
        public int Size { get; set; }
        public int[,] Data { get; set; }

        public void TransposeMain()
        {
            for (int i = 0; i < Size; i++)
                for (int j = i + 1; j < Size; j++)
                {
                    int temp = Data[i, j];
                    Data[i, j] = Data[j, i];
                    Data[j, i] = temp;
                }
        }

        public void TransposeSecondary()
        {
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size - 1 - i; j++)
                {
                    int tI = Size - 1 - j, tJ = Size - 1 - i;
                    int temp = Data[i, j];
                    Data[i, j] = Data[tI, tJ];
                    Data[tI, tJ] = temp;
                }
        }
    }
}
