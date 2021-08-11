using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachTestApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //int형 배열을 선언시 초기화 
            int[] sources = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for 문
            Console.WriteLine("for 문");
            for (int i = 0; i < sources.Length; i++)
            {
                Console.WriteLine($"sources[{i}] = {sources[i]}");
            }

            //foreach 문 배열의 요소를 반복하는 단순하고 깔끔한 방법 제공 
            Console.WriteLine("foreach 문");
            var idx = 0;
            foreach (var item in sources) //(var i in numbers)
            {
                Console.WriteLine($"sources [{idx++}] = {item}");
            }


            foreach (var item in sources) //sources의 배열들중에 if문을 만족 시키는것 출력 
            {
                if (item % 3 == 0)
                {
                    Console.WriteLine($"3의 배수 {item}");
                }
                else
                    continue;
            }


            }
        }
    }

