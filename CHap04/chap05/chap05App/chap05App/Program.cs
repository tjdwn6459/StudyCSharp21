﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chap05App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("수를 입력하세요 : ");
                string line = Console.ReadLine(); //콘솔에서 입력값을 변수할당 line 에서 문자로 입력을 받는다 

                if (line == "quit") break;//quit라고 입력하면 프로그램 종료(break 하면서  WHILE(반복문)을 빠져나옴)


                int number = 0; //number 값 초기화 
                int.TryParse(line, out number); //문자열로 받은 숫자를 int 형으로 변환하며 number의 값으로 빠져나온다 
                //tryparse-변환이 안대는 값을 넣을때 0 값이 나옴//int.Parse(line);
                //Console.WriteLine(number);
                 if (number > 0)
                {
                    if (number % 2 == 0)
                        Console.WriteLine("0보다 큰 짝수");
                    else
                        Console.WriteLine("0보다 큰 홀수");
                }
                else
                {
                    Console.WriteLine("0보다 작은수");
                }

                 //todo 마직막
            }
            Console.WriteLine("계산종료!");
        }
    }
}
