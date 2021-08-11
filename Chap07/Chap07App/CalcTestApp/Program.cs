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
            int result = a + b;
            return result;
        }
        public void PrintEvent(int val)
        {

            Console.WriteLine($"값: {val}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {


            Mathz mathz = new Mathz();


            int x;
            int y;

            x = 5;
            if (x % 2 == 0)
            {
                Console.WriteLine($"x의 값: {x}");
            }
            else
                mathz.PrintEvent(x); //다른클래쓰의 함수를 사용 (public로 되어있어서 접근 가능)

            y = 5;
            int sum = mathz.Plus(x, y);
            Console.WriteLine($"x + y의 값:{mathz.Plus(x, y)} ");



            //..
        }
    }
}
