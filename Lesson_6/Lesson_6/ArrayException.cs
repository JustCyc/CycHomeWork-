using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Lesson_6
{
    class ArrayException
    {

        [Serializable]
        public class MyArraySizeException : Exception
        {

        }
        public class MyArrayDataException : Exception
        {
            public MyArrayDataException(int x, int y)
            {
                Console.WriteLine($" Обнаружена ошибка в ячейке с координатами {x}, {y}");
            }
        }

        static public int ConvertAndSum(string[,] strArray)
        {
            int sum = 0;
            if (strArray.GetLength(0) != 4 && strArray.GetLength(1) != 4)
            {
                throw new MyArraySizeException();
            }
            int[] sumArray = new int[16];
            for (int i = 0; i < strArray.GetLength(0); i++)
            {
                for (int j = 0; j < strArray.GetLength(1); j++)
                {
                    if (strArray[i, j] == "1" || strArray[i, j] == "2" || strArray[i, j] =="3" || strArray[i, j] == "4")
                    {
                        sumArray[i] = int.Parse(strArray[i, j]);
                    }
                    else
                    {
                        throw new MyArrayDataException(i, j);
                    }
                }
                sum = sum + sumArray[i];
            }

            return sum;
        }

    }
}
