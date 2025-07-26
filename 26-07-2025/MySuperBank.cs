namespace MySuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<MyBank> BankAccounts = new List<MyBank>();
            string opt = " ";
            do
            {
                
                //taking input 
                Console.Write("Press1: Do you Want to create Account:");
                opt = Console.ReadLine();
                if (opt == "1")
                {
                    BankAccounts.Add(AddAccount());
                }


                //var AC1 = new MyBank("Aniket", "25000");
                Console.WriteLine($"Successfully created Account for {BankAccounts[0].Owner} \n and Initial " +
                $"Balance was :{BankAccounts[0].Balance}");
            } while (opt != "3");
        }

        public static MyBank AddAccount()
        {
            Console.Write("Enter Your Full Name:");
            string name = Console.ReadLine();
            Console.Write("Enter Initial Amount:");
            string amount = Console.ReadLine();

            return new MyBank(name, amount);
        }
    }
}
