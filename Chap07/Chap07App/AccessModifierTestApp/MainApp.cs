using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTestApp
{
    class Boiler
    {
        public int temp = 5; //물온도

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
            {
                Console.WriteLine("물의 온도가 일정온도를 벗어났습니다. 다시 셋팅헤주세요");
                this.temp = 59;
            } else
            {
                this.temp = temp;
            }
        }

        public int GetTemp()
        {
            return this.temp;
        }
        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 켭니다.");
        }
        public void TurnOffboiler()
        {
            Console.WriteLine("보일러를 끕니다.");
        }
        class MainApp
        {
            static void Main(string[] args)
            {
                Boiler Kitturami = new Boiler();
                var currTemp = Kitturami.GetTemp(); 
                Console.WriteLine($"현재 온도는 {currTemp}℃ 입니다");
                Kitturami.SetTemp(40);
                Kitturami.TurnOnBoiler();
                Kitturami.SetTemp(59);
                

                if (Kitturami.GetTemp()  >= 59)
                {
                    Kitturami.TurnOffboiler();
                }

                //Kitturami.SetTemp = 70;
                //Kitturami.TurnOffboiler();//
            }
        }
    }
}
