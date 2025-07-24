namespace SimpleClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.Make = "OldMobiles";
            mycar.Model = "Cutlas Supreme";
            mycar.Year = 1992;
            mycar.Color = "Red";

            Console.WriteLine("{0} \n{1}\n {2}\n {3} ",
                mycar.Make, mycar.Model, mycar.Year, mycar.Color);
            
            decimal price = mycar.DeterminePriceOfCar();
            Console.WriteLine("Market Value of the Car Could Be :" + price);
            Console.ReadLine();
        }

    }

    class Car
    {
        public string Make { get; set; }
        public string Model{get; set;}
        public int Year { get; set; }
        public string Color { get; set; }
        public  decimal DeterminePriceOfCar()
        {
            decimal carprice;
            if (Year <= 1998)
                carprice = 8000;
            else
                carprice = 1000;
            return carprice;

        }
    }
}
