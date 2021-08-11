using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubilcTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintProfile("안성주", "010-2740-5111");

            if(PrintProfile(null, "010-1111-8888") == -1);
            {
                Console.WriteLine("프로필 출력시 오류가 발생했습니다.");
            }
            PrintProfile(phone : "010-4456-5525"); // 폰 번호만 대입


        }

        public static int PrintProfile(string name = "홍길동", string phone = "010-7979-7979")
        {
            if (string.IsNullOrEmpty(name)) //값이 비어있거나 null일 경우 
            {
                Console.WriteLine("이름을 정확히 입력하세요.");
                return -1; //프로그램이 정상적으로 끝내지 못함 
                
            }
            //프로필 출력
            Console.WriteLine($"이름: {name}, 폰번호 : {phone}");
            return 0; //프로그램 정상 종료
            


    }
    }
}
