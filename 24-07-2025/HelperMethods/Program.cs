namespace understandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("Enter First Name:");
            string fname = Console.ReadLine();
            Console.Write("Enter Mid Name:");
            string mname = Console.ReadLine();
            Console.Write("Enter Last Name:");
            string lname = Console.ReadLine();

            //reversing each name 
            // calling printing method
            printReversedString(reversenames(fname), reversenames(mname), reversenames(lname));
          

        }

  

        static string reversenames(string st)
        {
            char[] c = st.ToCharArray();
            Array.Reverse(c);
            return string.Concat(c);
        }
        static void printReversedString(string f , string m , string l)
        {
            //printing each reversed name 
            Console.WriteLine("{0} {1} {2}",
                f, m, l);

            Console.ReadLine();
        }
    }
}
        