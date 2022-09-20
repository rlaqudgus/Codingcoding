using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codingcoding.Baekjoon
{
    internal class Bj_1181
    {
        public static void Mai()
        {
            //Input 단어의 개수 N N번 돌면서 배열에 집어넣음
            int N = int.Parse(Console.ReadLine());

            string[] array = new string[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = Console.ReadLine();
            }

            //Process
            //먼저 사전순 정렬
            //Array.Sort(array);

            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}

            //Length 값을 받아서 오름차순으로 정렬

            //for (int i = 0; i < N; i++)
            //{
            //    for (int j = i+1; j < N; j++)
            //    {
            //        if (array[i].Length > array[j].Length)
            //        {
            //            string temp = array[i];
            //            array[i] = array[j];
            //            array[j] = temp;
            //        }

            //        if (array[i] == array[j])
            //        {
            //            array[j] = "disposable"; 
            //        }
            //    }
            //}

            //중복되는 문자 삭제처리

            //for (int i = 0; i < N; i++)
            //{
            //    if (array[i]=="disposable")
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(array[i]);
            //}

            //lamda식 정렬 활용
            Array.Sort(array, (a, b) =>
            {
                if (a.Length < b.Length)
                {
                    return -1;
                }
                if (a.Length > b.Length)
                    return 1;
                else
                    return string.Compare(a, b);
            });

            for (int i = 0; i < N; i++)
            {
                if (i>0 && array[i] == array[i-1])
                {
                    continue;
                }
                Console.WriteLine(array[i]);
            }
            //foreach (var item in array)
            //{
            //    Console.WriteLine(item);
            //}
            




        }
    }
}
