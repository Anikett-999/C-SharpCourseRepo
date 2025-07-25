using System.Timers;
using Timer = System.Timers.Timer;

namespace TimerExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);
            //Elapsed Event 
            myTimer.Elapsed += Mytimer_Elapsed;
            myTimer.Start();

            Console.ReadLine();
        }
        private static void Mytimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Elapsed {0:HH:mm:ss.fff}",e.SignalTime);
        }
    }
}
