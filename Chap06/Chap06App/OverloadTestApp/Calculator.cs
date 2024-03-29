﻿using System;

namespace OverloadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기!");

            int x = Calculator.Plus(3, 4);
            Console.WriteLine($"3 + 4= {x}");

            float y = Calculator.Plus(3.14f, 5.6f);
            Console.WriteLine($"3.14 + 5.6 = {y}");

            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, 5.6)}");

            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, "5")}");

            int z = Calculator.Plus(7, 8, 9);


            int total = 0;
            total = Sum(1, 2, 4, 5);
            Console.WriteLine($"합계는 {total}");


            Console.WriteLine($"합계는 {Sum(1, 2)}");
            Console.WriteLine($"합계는 {Sum(1, 2, 3)}");
            Console.WriteLine($"합계는 {Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");

            //배열 숫자의 합
            int[] arrs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"10까지의 합은 {Sum(arrs)}");
        }

        
        //sum의 연산을 가능하게 함
        private static int Sum(params int[] args)
        {
            int result = 0;
            //반복문
            foreach (var arg in args)
            {
                result += arg; //배열에 있는 숫자의 총합을 구한다 
            }
            return result;
        }

        //int z = Calculator.Plus(7, 8, 9);
        private static int Plus(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }

       // Calculator.Plus(3.14, "5") (실수 + 문자)
        private static double Plus(double v1, string v2)
        {
            
            double. TryParse(v2, out double p2);
            double result = v1 + p2;
            return result;
        }

        private static double Plus(double v1, double v2)
        {
            double result = v1 + v2;
            return result;
        }


        //float y = Calculator.Plus(3.14f, 5.6f);
        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }


        //int x = Calculator.Plus(3, 4);
        private static int Plus(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }
    }
}
