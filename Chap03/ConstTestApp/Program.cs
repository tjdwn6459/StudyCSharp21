using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstTestApp
{
    class Program
    {

        //enum 열거형을 정의하고 멤버의 이름을 지정
        enum Season
        {
            봄,
            여름,
            가을,
            겨울
        }

        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");

            //const 상수필드와 지역상수를 선언할때 사용
            const double Pi = 3.141592;
            Console.WriteLine($"원주율의 값은 {Pi}");


            //(season)의 열거된것 중에 1번째 방에 있는 것을 출력
            Season mySeason = (Season)1; // = Season.여름; 
            Console.WriteLine($"지금 계절은 {mySeason}입니다.");

            int a = 0;
            Console.WriteLine($"a는 {a}");
            //null값 (아무것도 아닌 값)
            int? b = null;
            Console.WriteLine($"b는 {b}");
        }
    }
}
    

