using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadStateApp
{
    class SideTask
    {
        int Count { get; set; }

        public SideTask(int count)
        {
            this.Count = count;
        }

        public void CountDown()
        {

            try
            {
                while (Count > 0)
                {
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId}{Count} 남음"); //지금현재 THREAD의 동작한 번호 
                    Count--;
                    Thread.Sleep(10);

                }
                Console.WriteLine($"Count : {Count}"); // 0
            }
            catch(ThreadAbortException ex)
            {
                Console.WriteLine($"스레드 임의종료 예외발생 : {ex.Message}");
                //Thread.ResetAbort();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"스레드 예외발생 : {ex.Message}");
            }
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100); //100부터 내려가면서 숫자 셈
            Thread th = new Thread(task.CountDown);
            th.IsBackground = false;// 이 스레드가 종료되기 전까지는 모든 프로세스가 끝나지 않음
            //true인 경우, 백그라운드 스레드가 돌고 있는 상황에도 메인스레드가 끝나면 백그라운드 스레드 같이 종료
            SideTask task2 = new SideTask(200);
            Thread th2 = new Thread(task2.CountDown); //기본값 Isbackground false


            Console.WriteLine("스레드 시작");
            th.Start();
            th2.Start();

            Console.WriteLine("스레드 시작!");
            th.Start();

            Thread.Sleep(100); //1초

            Console.WriteLine("인터럽트");
            th2.Interrupt();
            //Console.WriteLine("임의 종료");
            //th.Abort();

            Console.WriteLine("종료대기"); //카운트 다운 중간에 표시된다.
            th.Join();

            Console.WriteLine("스레드/프로세스 종료");
        }


    }
}
