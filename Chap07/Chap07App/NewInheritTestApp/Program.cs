using System;

namespace NewInheritTestApp
{

    //Main 에서 상속받은 클래쓰를 사용
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("동물 클래스 상속!!");

            Animal animal = new Animal(); //Animal 의 속성을 지닌 클래쓰를 생성 
            animal.Name = "동물";
            animal.Age = 100;
            animal.Breathe();

            Dog dog = new Dog(); //Dog의 속성을 지닌 클래쓰 생성 
            dog.Name = "마루";
            dog.Age = 2;
            dog.Breathe();
            dog.HowOld();
            dog.Bark();

            Bird bird = new Bird();
            bird.Name = "참새";
            bird.Age = 4;
            bird.HowOld();
            bird.Fly();
        }
    }
}
