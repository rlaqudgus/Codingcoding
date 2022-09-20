using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Programmers
{
    internal class Sort
    {
        static public string[] solution(string[] strings, int n)
        {
            Array.Sort(strings, (a, b) =>
            {
                if (a[n] < b[n])
                    return -1;

                if (a[n] > b[n])
                    return 1;

                else
                    return string.Compare(a, b);
            });

           

            return strings;
        }
        //public static void Main()
        //{
        //    string[] input = { "abce", "abcd", "cdx" };
        //    string[] answer = solution(input, 1);

        //    foreach (var item in answer)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}
        
    }
}
