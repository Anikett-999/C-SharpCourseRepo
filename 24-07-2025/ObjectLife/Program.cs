namespace ObjectLife
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Audie";
            car.Model = "Q8";
            car.Year = 2012;
            car.Color = "Red";

            //Here we just created  a secon drefference of class car
            Car secondcar;
            secondcar = car;

            Console.WriteLine("Before Color Changing:"+secondcar.Color);

            
            secondcar.Color = "Blue";
            Console.WriteLine("After Color Changing :"+secondcar.Color);
        }
    }
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Make = "Rolls Royce";
            Model = "1";
            Year = 2000;
            Color = "Black";
            Console.WriteLine("{0} {1} {2} {3} ", Make, Model, Year, Color);
        }
    }
 }
