using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자 /t띄어쓰기 /n개행 
            char ch1 = 't', ch2 = '\t', ch3 = '\n', ch4 = '0';
            Console.WriteLine($"{ch1}, {ch2}, {ch3}, {ch4}");
            char ch5 = '\\';
            Console.WriteLine($"{ch5}");

            // 문자 열
            string str1 = "\a\tHello, \nWorld!"; // \a는 알람소리, \t는 tap, \n은 줄바꿈
            Console.WriteLine(str1); // = Console.WriteLine($"{str1}");

            //값을 사용하며 논리 연산을 수행한다(구조체 형식)
            bool isCorrect = false;
            if (isCorrect)
            {
                Console.WriteLine("참입니다");

            }
            else
            {
                //iscorrect의 값이 false이니 거짓이 출력
                Console.WriteLine("거짓입니다");
            }

            Console.WriteLine(isCorrect);
        }
    }
}
        
