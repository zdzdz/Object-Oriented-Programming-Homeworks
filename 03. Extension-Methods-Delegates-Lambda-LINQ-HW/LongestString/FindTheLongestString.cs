//Problem 17. Longest string

//    Write a program to return the string with maximum length from an array of strings.
//    Use LINQ.


using System;
using System.Linq;

namespace LongestString
{
    class FindTheLongestString
    {
        static void Main()
        {
            string[] arr = {"asd", "dasiuc", "oioskkdoi", "deaokopkii"};

            string longest =
                (from str in arr
                orderby str.Length descending 
                select str).FirstOrDefault();

            string longestStr = arr.Max(x => x.Length).ToString();

            Console.WriteLine(longest);
            Console.WriteLine();
            Console.WriteLine("The longest string has {0} letters.",longestStr);
        }
    }
}
