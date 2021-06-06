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

namespace _Hackerrank__Compare_the_Triplets
{
    class Result
    {

        /*
         * Complete the 'compareTriplets' function below.
         *
         * The function is expected to return an INTEGER_ARRAY.
         * The function accepts following parameters:
         *  1. INTEGER_ARRAY a
         *  2. INTEGER_ARRAY b
         */

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int scoreAlice = 0;
            int scoreBob = 0;

            for (int i = 0; i < 3; i++)
            {
                if(a[i] != b[i])
                {
                    switch (a[i] > b[i])
                    {
                        case true:
                            scoreAlice++;
                            break;

                        case false:
                            scoreBob++;
                            break;
                    }
                }
            }

            int[] scoresNow = {scoreAlice, scoreBob};

            List<int> scores = new List<int>(scoresNow);

            return scores;
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            //For Hackerrank only
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = Result.compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));

            //For Hackerrank only
            //textWriter.WriteLine(String.Join(" ", result));

            //For Hackerrank only
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
