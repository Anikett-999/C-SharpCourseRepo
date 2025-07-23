namespace ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;

            Console.WriteLine("Lets Do Some Arithmentic Fun :");
            //Enter nUmber 1
            Console.Write("Enter Num1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            // Enter Number 2
            Console.Write("Enter Num2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            //Addition 
            int sum = num1 + num2;
            Console.WriteLine("Addition = " + sum);

            //substraction 
            int sub = (num2 > num1) ? num2 - num1 : num1-num2;
            Console.WriteLine("Substraction:" + sub);

            //Multiplaication
            int mul = num1 * num2;
            Console.WriteLine("Multipliacation :" + mul);

            //Division 
            int div = (num2 > num1) ? num2 / num1 : num1 / num2;
            Console.WriteLine("Division:" + div);

            //modulous 
            int mod = (num2 > num1) ? num2 % num1 : num1 % num2;
            Console.WriteLine("Remainder: " + mod);

        }

    }
}
