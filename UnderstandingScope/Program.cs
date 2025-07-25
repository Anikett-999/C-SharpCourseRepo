namespace UnderstandingScope
{
    internal class Program
    {
        //Global Scope
        private static string k = " k ";
        static void Main(string[] args)
        {
            //local scope 
            string j = "";
            for(int i=0; i<10; i++)
            {
                j += " "+i.ToString();
                Console.WriteLine(i);
            }
            Console.WriteLine("Outside Of the for loop:" + j);
            AccessK();
        }

        private static void AccessK()
        {
            //Local scope 
            Console.WriteLine(k);
        }
    }
}
