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
            myTimer.Elapsed += Mytimer_Elapsed1;

            myTimer.Start();
            Console.WriteLine("Please Enter TO Remove Red Text:");
            
            Console.ReadLine();
            myTimer.Elapsed -= Mytimer_Elapsed1;

            Console.ReadLine();
        }
        private static void Mytimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Elapsed {0:HH:mm:ss.fff}",e.SignalTime);
        }
        private static void Mytimer_Elapsed1(object sender , ElapsedEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed {0:HH:mm:ss:fff}",e.SignalTime);
        }
    }
}
