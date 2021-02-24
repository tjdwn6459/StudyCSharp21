using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTestApp
{
    class Mathz
    {

        public int Plus(int a, int b)
        {
            //..
            return 1;
        }
        public void PrintEvent(int val)
        {
            if (val % 2 == 0)
            {
                Console.WriteLine($"값: {val}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //..

            Mathz mathz = new Mathz();

            int x;

            //..
            x = 5;
            /*if (x % 2 ==0)
            {
                Console.WriteLine($"x의 값: {x}");
            }*/
            mathz.PrintEvent(x);

            //..

            x = 10;
            /*if (x % 2 == 0)
            {
                Console.WriteLine($"x의 값: {x}");
            }*/
            mathz.PrintEvent(x);

            //..
        }
    }
}
