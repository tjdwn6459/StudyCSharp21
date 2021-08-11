using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideTestApp
{
    class ArmorSuite
    {
        //자식클래스에서 재정의할꺼야.(자식클래쓰에서 같은 함수이름을 사용이 가능하다)
        public virtual void Initialize()
        {
            Console.WriteLine("ArmorSuite 초기화");
        }
    }


    class IronMan : ArmorSuite
    {
        //자식클래쓰에서 재정의 함수 사용위해서는 override사용
        public override void Initialize()
        {
            base.Initialize();
            Console.WriteLine("리펄서 레이저 초기화");

        }


    }

    class WarMachine : ArmorSuite
    {
        public override void Initialize()
        {
            Console.WriteLine("AmorSuite 개량 Warmachine 초기화");
            Console.WriteLine("Double-Barrel 케논 장착");
            Console.WriteLine("Micro-Rocket 런처 장착");

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArmorSuite 생산");
            ArmorSuite suite = new ArmorSuite();
            suite.Initialize();

            Console.WriteLine("WarMachine 생산");
            WarMachine machine = new WarMachine();
            machine.Initialize();

            Console.WriteLine("IronMan 생산");
            IronMan ironMan = new IronMan();
            ironMan.Initialize();
        }
    }
}
