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

namespace _Hackerrank__Mini_Max_Sum
{
    class Result
    {

        /*
         * Complete the 'miniMaxSum' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void miniMaxSum(List<int> arr)
        {
            arr.Sort();

            long minSum = 0;
            long maxSum = 0;

            for(int i = 0; i < 4; i++)
            {
                long tempNum = arr[i];
                minSum += tempNum;
            }

            for(int j = arr.Count-1; j > arr.Count - 5; j--)
            {
                long tempNum = arr[j];
                maxSum += tempNum;
            }

            List<long> res = new List<long>()
            {
                minSum,
                maxSum
            };

            foreach(var i in res)
            {
                Console.Write(i + " ");
            }
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.miniMaxSum(arr);
        }
    }
}
