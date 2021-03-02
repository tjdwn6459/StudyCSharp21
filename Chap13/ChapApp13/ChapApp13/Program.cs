using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapApp13
{
    delegate int MyDelegate(int a, int b);// 대리자 대신 호출한다. 호출할 메서드와 일치해야한다.
    class Calculator
    {
        public int Plus ( int a , int b)
        {
            return a + b;
        }

        public int Minus(int a , int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(calc.Plus);
            Console.WriteLine($"result = {Callback(3, 4)}");//7 호출

            Callback = new MyDelegate(calc.Minus);
            Console.WriteLine($"result = {Callback(5, 2)}");//3 호출
        }
    }
}
