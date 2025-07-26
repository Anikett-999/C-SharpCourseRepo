using Stripe;
using System.Globalization;
using System.Runtime.InteropServices;

namespace BankAccounts
{
    
    public class Bank
    {
        private bool flag = false;
        static void Main(string[] args)
        {
            //initialized class MyBank to access First AccounterNumber 
            MyBank mybank = new MyBank("Aniket", 25000);
            int ACNO= mybank.AccountNumber;

            string opt = " ";
            Dictionary<string, MyBank> BankAccounts = new Dictionary<string, MyBank>();
            //adding bydefualt account
            BankAccounts.Add("ACC" + ACNO,mybank);
            do
            {
                opt = UserInterFace();
                switch (opt)
                {
                    case "1":
                        ACNO += 1;
                        string ACNo = "ACC"+ACNO;
                        BankAccounts.Add(ACNo, AddAccount());
                        break;
                    case "2":
                        Console.WriteLine(ShowUser(BankAccounts));
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine($"Amount Deducted !{WithDrawAmount(BankAccounts)}");
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                }
            } while (opt != "5");
        }

        private static MyBank AddAccount()
        {
            Console.Write("Enter Your Full Name:");
            string name = Console.ReadLine();
            Console.Write("Enter Initial Amount:");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Write($"BankAccount Created Succeffeuly for Mr/Ms{name}");
            Console.ReadLine();
            return new MyBank(name, amount);
        }
        private static string UserInterFace()
        {
            Console.Clear();
            //taking input 
            Console.Write("Press1: Do you Want to create Account:\n" +
                           "Press2: Do you want to Search User :\n" +
                           "Press3: Do You Want To Withraw Amount:\n" +
                           "Press4: Do You Want Search Transaction:\n" +
                           "Press5: To Exit :" +
                           "Enter Your Option :");
            string Opt = Console.ReadLine();
            return Opt;
        }
        private static string ShowUser( Dictionary<string, MyBank> mydict)
        {

            Console.Write("Enter Your Account Number TO get Your Details :");
            string UACNO = Console.ReadLine();
            try
            {
                string output = $"Account Found !! \nAccount Holder :{mydict[UACNO].Owner}" +
                $"\nAccount Balance:{mydict[UACNO].Balance}";
                return output;
            }
            catch(KeyNotFoundException e)
            {
                return "Invalid Account Number !";
                
            }
            
        }
        private static string WithDrawAmount(Dictionary<string,MyBank> mydict)
        {
            Console.Write("Enter Your Account Number:");
            string UACNO = Console.ReadLine();
            Console.Write("Enter the Amount to Debit:");
            double DeductionAmount = Convert.ToDouble(Console.ReadLine());
            mydict[UACNO].Balance -= DeductionAmount;
            string output = "Remaining BankBalance:"+mydict[UACNO].Balance;
            return output;
        }
        enum Option
        {
            AddAccount,
            SearchUser,
            WithdrawAmount,
            TransactionHystory
        }
    }

}