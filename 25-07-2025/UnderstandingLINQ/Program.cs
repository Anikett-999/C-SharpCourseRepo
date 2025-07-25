namespace UnderstandingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cars> mycars = new List<Cars>()
            {
                new Cars(){Make = "BMW",Model = "Q7",VIN = "A1",Year =2012},
                new Cars(){Make = "Audi",Model = "Q8",VIN = "A2",Year =2022},
                new Cars(){Make = "Toyota",Model = "A3",VIN = "A3",Year =2009},
                new Cars(){Make = "Mahindra",Model = "I2",VIN = "A4",Year =2004},
                new Cars(){Make = "BMW",Model = "Q1",VIN = "B1",Year =2000}
            };
            //LINQ Query
            /*
            var bmws = from car in mycars
                       where car.Make == "BMW"
                       select car;
            */
            /*
            //Ordered car 
            var orderedCars = from car in mycars
                              orderby car.VIN descending
                              select car;

            foreach (var i in orderedCars)
            {
                Console.WriteLine(string.Format("{0:#####  }  {1:##} {2:##}", i.Make, i.Model, i.VIN));
            }
            */
            //LINQ method
            /*
             var bmws = mycars.Where(p => p.Make == "BMW");
            
            foreach(var i in bmws)
            {
                Console.WriteLine("{0} , {1} , {2}",i.Make,i.Model,i.VIN);
            }       */

            
            //OrderByDescending methid
            var orderedcars2 = mycars.OrderByDescending(p => p.Make);
            /*
            foreach(var i in orderedcars2)
            {
                Console.WriteLine(i.Make + " " +i.Model);
            }

            var first = orderedcars2.First(v => v.Make =="BMW");
            Console.WriteLine("First car:" + first.Make);

            //treuforall method
            var b = mycars.TrueForAll(p => p.Year > 1900);
            Console.WriteLine(b);
            */

            //ForEach Method
            //mycars.ForEach(p => Console.WriteLine("{0} {1} ", p.Make, p.Model));

            //get type 
            Console.WriteLine(mycars.GetType());
            Console.WriteLine(orderedcars2.GetType());

            //
            var bmws = from car in mycars
                       where car.Make == "BMW"
                       select (car.Make,car.Model);
            Console.WriteLine(bmws.GetType());
        }
    }
    class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }
        public int Year{ get; set;}


    }
}
