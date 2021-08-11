using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtypeCastApp
{
    class Mammal //Mammal 부모 클래쓰 생성
    {

        public string Name { get; set; }


        public void Nurse()
        {
            Console.WriteLine($"{this.Name}을(를) 키우다");
        }  
    }

    class Dog : Mammal //Mammal 의 클래쓰를 상속 받은 Dog 자식 클래쓰 선언 
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name}, 멍멍!!");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine($"{this.Name}, 야옹!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Name = "포유류";
            mammal.Nurse();

            Dog ppoppi = new Dog();// new dog();
            ppoppi.Name = "뽀삐";
            ppoppi.Nurse();
            ppoppi.Bark();


            Cat chichi = new Cat();
            chichi.Name = "치치";
            chichi.Nurse();
            chichi.Meow();

            if (ppoppi is Mammal) // 뽀삐는 포유류 인가?
            {
                //값형식은 long = int 값;
                Mammal mammal1 = ppoppi as Mammal; //참조형식은 as 를 써서 형변환
                mammal1.Nurse();
                //mammal1.Bark();//부모가 바껴서 어떤 소리를 내는지 알 수 없다 
            }

            if (mammal is Dog) //포유류가 강아지 인가?
            {
                ppoppi = mammal as Dog;//ppoppi 에다가 mammal을 넣는다
                ppoppi.Nurse();
                ppoppi.Bark();
            }
        }
    }
}
