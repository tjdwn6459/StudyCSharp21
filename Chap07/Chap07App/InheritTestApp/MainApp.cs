using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//1)Main에서 새로운 객체 생성 2) 부모 클래쓰 선언 3) 부모클래쓰에서 상속받은 자식 클래스 선언 ->main에서 생성자 호출 -> 함수 실행
namespace InheritTestApp
{

    class Parent
    {
        protected string Name;

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Parent() 생성자");
        }

        public void ParentMethod()
        {
            //..
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }
    }

    class Child : Parent //parent의 클래스를 상속받은 child 클래쓰 
    {
        public string Color; //색상

        public Child(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.child() 생성자");
        }

        public void ParentMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");
        }

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.Child() 생성자");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");
            p.ParentMethod(); //부모클래쓰 메서드 실행

            Child c = new Child("자식");
            c.Color = "황색";
            c.ParentMethod(); //부모의 메서드 실행
            c.ChildMethod(); //자식의 메서드 실행

                 

        }
    }
}
