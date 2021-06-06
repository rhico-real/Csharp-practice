﻿using System.CodeDom.Compiler;
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

namespace _Hackerrank__A_Very_Big_Sum
{
    class Result
    {

        /*
         * Complete the 'aVeryBigSum' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER_ARRAY ar as parameter.
         */

        public static long aVeryBigSum(List<long> ar)
        {
            long num = 0;

            foreach (var i in ar)
            {
                num += i;
            }

            return num;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            //For Hackerrank only
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = Result.aVeryBigSum(ar);

            Console.WriteLine(result);
            //For Hackerrank only
            //textWriter.WriteLine(result);

            //For Hackerrank only
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}

