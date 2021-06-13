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

namespace _Hackerrank__Plus_Minus
{
    class Result
    {

        public static void plusMinus(List<int> arr)
        {
            decimal arrLength = arr.Count;

            decimal countPositive = 0;
            decimal countNegative = 0;
            decimal countZero = 0;

            foreach(var i in arr)
            {
                switch(i > 0)
                {
                    case true:
                        countPositive++;
                        break;

                    case false:
                        if(i == 0)
                        {
                            countZero++;
                            break;
                        }
                        else
                        {
                            countNegative++;
                            break;
                        }
                }
            }

            decimal pos = countPositive / arrLength;
            decimal neg = countNegative / arrLength;
            decimal zero = countZero / arrLength;

            List<String> res = new List<String>(){ pos.ToString("0.000000"), neg.ToString("0.000000"), zero.ToString("0.000000") };

            foreach(var j in res)
            {
                Console.WriteLine(j);
            }

        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            Result.plusMinus(arr);
        }
    }
}
