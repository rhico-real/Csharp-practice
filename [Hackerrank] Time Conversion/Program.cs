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

namespace _Hackerrank__Time_Conversion
{
    class Result
    {

        /*
         * Complete the 'timeConversion' function below.
         *
         * The function is expected to return a STRING.
         * The function accepts STRING s as parameter.
         */

        public static string timeConversion(string s)
        {
            int position = s.IndexOf(":");
            String hour = s.Substring(0, position);

            int hourNum = int.Parse(hour);

            String dayOrNight = s.Substring(s.Length - 2);

            int calculatedHourNum;

            if (dayOrNight.Equals("PM"))
            {
                if (hourNum == 12)
                {
                    calculatedHourNum = hourNum;
                }
                else
                {
                    calculatedHourNum = hourNum + 12;
                }
            }
            else
            {
                if(hourNum == 12)
                {
                    calculatedHourNum = 0;
                }
                else
                {
                    calculatedHourNum = hourNum; 
                }
            }

            if (calculatedHourNum >= 24)
            {
                calculatedHourNum -= 24;
            }
            String militaryTime = calculatedHourNum.ToString("00") + s.Substring(position, s.Length - (position + 2));

            return militaryTime;
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            //for hackerrank only
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            string result = Result.timeConversion(s);

            Console.WriteLine(result);
            //for hackerrank only
            //textWriter.WriteLine(result);

            //for hackerrank only
            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
