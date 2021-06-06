using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace _Hackerrank__Diagonal_Difference
{
    class Result
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            List<int> firstDiag = new List<int>();
            List<int> secondDiag = new List<int>();

            int sumFirstDiag = 0;
            int sumSecondDiag = 0;

            for (int i = 0; i < arr.Count(); i++)
            {
                firstDiag.Add(arr[i][i]);
                secondDiag.Add(arr[i][arr.Count() - (i + 1)]);
            }
            
            foreach(var element1 in firstDiag)
            {
                sumFirstDiag += element1;
            }

            foreach(var element2 in secondDiag)
            {
                sumSecondDiag += element2;
            }

            int sum = 0;

            switch(sumFirstDiag > sumSecondDiag)
            {
                case true:
                    sum = sumFirstDiag - sumSecondDiag;
                    break;

                case false:
                    sum = sumSecondDiag - sumFirstDiag;
                    break;
            }

            return sum;

        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            //For Hackerrank only
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Result.diagonalDifference(arr);

            Console.WriteLine(result);
            //For Hackerrank only
            //textWriter.WriteLine(result);

            //For Hackerrank only
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
