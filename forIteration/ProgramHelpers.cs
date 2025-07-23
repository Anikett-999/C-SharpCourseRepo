/*    Write a C# program that:
      Takes two integers from the user: start and end
      Loops from start to end using a for loop
      Skips even numbers using 
      Finds and prints the first prime number in that range
      Once a prime is found, break the loop
    */
namespace forIteration
{
    internal static class ProgramHelpers
    {
        static void Main(string[] args)
        {
            int start = 0, end = 0;

            // take 2 numbers as input
            Console.Write("Enter Start: ");
            start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter End: ");
            end = Convert.ToInt32(Console.ReadLine()); // ✅ Fixed here
            int i = start;
            for (i = start; i <= end; i++)
            {
                if (i == 2)
                {
                    break;
                }
                if (i % 2 == 0)
                    continue;

                else if (isPrime(i))
                {
                    break;
                }
            }
            Console.WriteLine("Found First Prime: " + i);
        }
        //method to check is no prime 
        private static bool isPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}