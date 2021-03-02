using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrtCatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, };
            int x = 108,y = 0;
            int result = 0;

            try
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"{i}번째 값 : {arr[i]}");
                }


            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"결과는 {result}");


            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }
           
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
            }

            Console.WriteLine("나머지 일처리 계속...");

            string strVal = "HelloWorld";
           

            try
            {
                string splitVal = "HelloWorld";
                string SplitVal = strVal.Substring(6, 5);
                Console.WriteLine($"자른 문자 : {SplitVal}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"원본문자열이 비어있습니다. 값을 입력하세요. {ex.Message}");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"원본문자열을 초기화하세요. {ex.Message}");
            }
            catch(Exception ex)
            {
                Console.WriteLine($"기타 예외발생. {ex.Message}");

            }
            Console.WriteLine($"일처리 또 있음..");
        }
    }
}
