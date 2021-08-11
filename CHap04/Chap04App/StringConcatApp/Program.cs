using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 더하기");
            var p2 = 456;
            Console.WriteLine(123 + p2); //579
            Console.WriteLine("123" + p2);//123456 "123"문자로 취급
            Console.WriteLine($"123{p2}"); //c# 6.0이후 문자열 만드는 방법
            Console.WriteLine(123 + "456");//123456
            Console.WriteLine("123" + "456"); // 123456

            //관계연산자

            int a = 30, b = 30;
            Console.WriteLine(a < b); //False
            Console.WriteLine(a > b); //False
            Console.WriteLine(a <= b); //True
            Console.WriteLine(a >= b); //True
            Console.WriteLine(a == b); //True
            Console.WriteLine(a != b); //False

            //논리연산자
            Console.WriteLine("논리연산자");
            Console.WriteLine(10>9 && a >=0);//True
            Console.WriteLine(a>b || b>0); //True(||일땐 하나가 참이고 나머지가 거짓이면 참이나옴)
            Console.WriteLine(!(a<b)); //True (!=not)

            //조건연산자 단항 if문을 대체가능
            int c = 30;
            string result = c == 30 ? "삼십" : "삼십아님";
            /*if (c == 30)
                result = "삼십";
            else
                result = "삼십아님";*/
            Console.WriteLine(result);

            Console.WriteLine("NULL 병합연산자");
            int? d = null;
            Console.WriteLine($"{d ?? 0}");
        }
    }
}
