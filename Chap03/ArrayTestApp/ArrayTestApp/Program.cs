using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.WriteLine("배열테스트");

                //배열 요소 형식과(int형 배열) 요소 수를 지정하는 new 연산자 사용(따로 초기화 하지 않음)
                //int ary2[] = {1, 3, 4, 5}일 경우는 ary2의 배열을 선언사 초기화 한다 
                int[] arr = new int[10];
                // i < arr.Length 배열의 길이를 설정 (시작점, 배열의 길이, 값 증가)
                for (var i = 0; i < arr.Length; i++)
                {
                    arr[i] = i + 1;
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine($"arr[{i}] 값은 {arr[i]}");
                }
            }
        }
    }
}
    

