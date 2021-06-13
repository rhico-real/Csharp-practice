//using System;

//namespace _Hackerrank__Birthday_Cake_Candles
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

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

namespace _Hackerrank__Birthday_Cake_Candles
{
    class Result
    {

        /*
         * Complete the 'birthdayCakeCandles' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY candles as parameter.
         */

        public static int birthdayCakeCandles(List<int> candles)
        {
            candles.Sort();

            int maxNum = candles[candles.Count()-1];

            int howmanyMaxNum = 0;

            foreach(var i in candles)
            {
                if(i == maxNum)
                {
                    howmanyMaxNum++;
                }
            }

            return howmanyMaxNum;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //for hackerrank only
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> candles = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(candlesTemp => Convert.ToInt32(candlesTemp)).ToList();

            int result = Result.birthdayCakeCandles(candles);

            Console.WriteLine(result);

            //for hackerrank only
            //textWriter.WriteLine(result);

            //for hackerrank only
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
