using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChain2App
{
    class Program
    {
        delegate void ThereISAFire(string location); //대리자 선언

        static void Call119(string location)//대리자 할 일 부여
        {

            Console.WriteLine($"소방서죠? 불났어요! 주소는 {location} 예요!");
         }   
        static void ShoutOut(string location)
        {
            Console.WriteLine($"불이야! {location}에 불났어요!");
        }

        static void Escape(string location)
        {
            Console.WriteLine($"{location}에서 나갑니다.");
        }
        static void Main(string[] args) //위에 부여한 일 부르는 순서대로 실행가능
        {
            ThereISAFire fire = new ThereISAFire(ShoutOut);
            fire += new ThereISAFire(Call119);
            fire += Escape;

                fire("문현동 전광빌라");
        }
    }
}
