namespace C_Beginners
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int min = int.MinValue;
            int max = int.MaxValue;
            Console.WriteLine($"Minvalue of type int:{min} and MaxVlaue is {max} ");


            long min1 = long.MinValue;
            long max1 = long.MaxValue;
            Console.WriteLine($"Minvalue of type long:{min1} and MaxVlaue is {max1} ");

            double min2 = double.MinValue;
            double max2 = double.MaxValue;
            Console.WriteLine($"Minvalue of type double:{min2} and MaxVlaue is {max2} ");

            decimal min3 = decimal.MinValue;
            decimal max3 = decimal.MaxValue;
            Console.WriteLine($"Minvalue of type decimal:{min3} and MaxVlaue is {max3} ");
            */


            double rad = 2.50;
            double area = Math.PI * rad * rad;
            Console.WriteLine($"Radius of the Circle:{rad} and Area Of the Circle: {area}");
        }
    }
}
