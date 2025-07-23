using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);
            Console.Write("Enter Length For Array: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[len];
            for(int i =0 ; i < len ;  i++)
            {
                Console.Write("Enter {0} Number: ",i);
                nums[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Minimum Value: " + nums.Min());
            Console.WriteLine("Maximum Value: " + nums.Max());
            Console.ReadLine();
        }
    }
}