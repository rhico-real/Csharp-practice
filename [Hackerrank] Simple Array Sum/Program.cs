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

namespace _Hackerrank__Simple_Array_Sum
{
    class Result
    {

        /*
         * Complete the 'simpleArraySum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY ar as parameter.
         */

        public static int simpleArraySum(List<int> ar)
        {
            int sum = 0;
            foreach(var i in ar)
            {
                sum += i;
            }

            return sum;
        }
        
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //For Hackerrank only
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("C:\\Users\rhico\\Desktop\\path.txt"), true);

            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

            int result = Result.simpleArraySum(ar);

            Console.WriteLine(result);

            //For Hackerrank only
            //textWriter.WriteLine(result);

            //For Hackerrank only
            //textWriter.Flush();

            //For Hackerrank only
            //textWriter.Close();
        }
    }
}
