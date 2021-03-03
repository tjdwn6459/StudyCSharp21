using System;

namespace UsingEventApp
{
    delegate void EventHandler(string message);//메세지를 받아서 처리하는 대리자 선언

    class CustomNotifier
    {//이벤트 선언, 사용하는 객체
        public event EventHandler SomethingHAppened;//" SomethingHAppened"는 이벤트의 이름인 EventHandler 대리자 수행(대리자의 인스턴스 이벤트)

        public void DoSomething (int number)
        {
            int temp = number % 10;//43 % 10 = 3 % 3 = 0

            if (temp != 0 && temp % 3 ==0)//3,6, 9  으로 떨어지는 값 (!= 같지않다)
            {
                SomethingHAppened($"{number} : 짝!"); // 3, 6, 9에서의 값에서는 짝! 하겠다(이벤트를 사용 로직은 없음)
            }
            else
            {
                SomethingHAppened($"{number}"); //(이벤트를 사용)
            }
        }
        
    }
    class Program
    {

        //이벤트가 발생했을때 실행되는 메서드 (이벤트 핸들러)
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 사용!");
            CustomNotifier notifier = new CustomNotifier();
            notifier.SomethingHAppened += new EventHandler(MyHandler);//이벤트를 내가 만든 로직이랑 연결

            for (int i = 1; i < 100; i++)
            {
                notifier.DoSomething(i);//100 이하에서 3, 6, 9에 관련된 값들만 나타남 
            }
        }
    }
}
