using System;
using System.Threading;

namespace SideTestApp
{
    class Program
    {
        static void PrintState(ThreadState state)
        {
            Console.WriteLine($"{state,-16} : {(int)state}");
        }
        static void Main(string[] args)
        {
            PrintState(ThreadState.StopRequested);
            PrintState(ThreadState.Suspended);
            PrintState(ThreadState.Stopped);
            PrintState(ThreadState.Unstarted);
            PrintState(ThreadState.WaitSleepJoin);
            PrintState(ThreadState.AbortRequested);
            PrintState(ThreadState.Aborted);

        }
    }
}
