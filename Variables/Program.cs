namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fName;
            string lName;
            // taking last name
            Console.WriteLine("Enter Your Name Below:");
            Console.Write("Enter FisrstName :");
            fName = Console.ReadLine();

            // taking last name
            Console.Write("Enter Last Name:");
            lName = Console.ReadLine();

            //greeting by concatinating
            Console.WriteLine("Hello,"+fName +" "+lName);
        }
    }
}
