using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10App
{

    class Test
    { }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 74, 81, 90, 34 }; // new int[5];  안쓰려면 변수의 타입을 지정/ for int


            for (int i = 0; i < array.Length; i++) //Length 속성, for 문
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }


            Console.WriteLine("크기변경");
            Array.Resize(ref array, 6);
            for (int i = 0; i < array.Length; i++) //Length 속성, for 문
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }


            int idx = Array.IndexOf(array, 81);
            for (int i = array.Length -1; i >= idx; i--)
            {
                array[i] = array[i - 1];
                /*Console.WriteLine($"{i} 번째 값 : { array[i]}");*/
            }   


            /*array[0] = 80;
            array[1] = 74;
            array[2] = 81;
            array[3] = 90;
            array[4] = 34;*/

            /*Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Base Type of array : {array.GetType().BaseType}");



            for (int i = 0; i < array.Length; i++) //Length 속성, for 문
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");

            }*/

            /*var idx = 0; //foreach
            foreach ( var item in array)
            {
                Console.WriteLine($"{idx++} 번째 값 : {item}");
            }*/

            Console.WriteLine("오름차순 정렬");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++) //Length 속성, for 문
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");

            }


            Console.WriteLine("내림차순 정렬");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++) //Length 속성, for 문
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");

            }


            int idx = Array.IndexOf(array, 34);//마지막 정렬에서 34의 인덱스 값, int idx아이디 값은 초기에 선언헤서 나중에 다시 할 필요없다.
            Console.WriteLine($"34의 인덱스 : {idx}");

            idx = Array.IndexOf(array, 100);
            Console.WriteLine($"100의 인덱스 : {idx}");// 값 -1 0부터 시작해서 없는 값은 -1이다



            Console.WriteLine("배열 삭제 ");
            Array.Clear(array, 3, 2); //3번째 인덱스 부터 2자리를 지움
            for (int i = 0; i < array.Length; i++) 
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");

            }




        }
    }
}
