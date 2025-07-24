namespace whileIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(MainMenu())
            {
                MainMenu();
            }
            
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.Write("Choose an Option :\n" +
                "1)option 1\n" + "2)Option 2 \n" +
                "3) Exit \nEnter your Opt:");
            string opt = Console.ReadLine();

            if (opt == "1")
            {
                printNumbers();
                return true;
            }
            else if (opt == "2")
            {
                numberGuessingGame();
                return true;
            }
            else if (opt == "3")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Your Only Expected to  Enter 1 2 or 3 :");
                Console.ReadLine();
                return true;
            }
        }

        //printnumbers 
        private static void printNumbers()
        {
            Console.WriteLine("Print Numbers :");
            Console.Write("Enter a Number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int counter = 1;
            while (counter <= num)
            {
                Console.Write(counter + "-");
                counter++;
            }
            Console.ReadLine();
        }

        private static int userInput()
        {
            int num=0;
            try
            {
                 num = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Sorry Numbers aree allowed !");
            }
            return num;

        }

        private static void numberGuessingGame()
        {
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            bool incorrect = true;

            int attempts = 0;
            Console.WriteLine("Number Guessing Game:");
            Console.Write("Enter Random Number Between 1 to 10:");
            int user_num = userInput();
            do
            {
                attempts++;
                if (user_num == randomNumber)
                {
                    Console.WriteLine("Yeah , You Guessed it Right !" +
                        "\n In " + attempts + " Attempts:");
                    Console.ReadLine();
                    break;
                    incorrect = false;
                }
                else
                {
                    Console.Write("Try Again Here :");
                    user_num = userInput();
                }

            } while (incorrect);
        }
    }
}
