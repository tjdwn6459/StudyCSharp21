
using System;

namespace NewInheritTestApp
{
    class Animal //멤버 변수 지정 방법
    {
        public string Name { get; set; }//프로퍼티
        public int Age { get; set; }

        public void Breathe()
        {
            Console.WriteLine($"{this.Name} 이 숨을 쉽니다.");
        }
    }
}
