using System.Collections;
namespace WorkingWithCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cars car0 = new Cars();
            car0.Make = "BMW";
            car0.Model = "Q7";
            car0.VIN = "A1";


            Cars car1 = new Cars();
            car1.Make = "Jaguar";
            car1.Model = "R2";
            car1.VIN = "A2";

            Cars car2 = new Cars();
            car2.Make = "Laborgini";
            car2.Model = "A2";
            car2.VIN = "3";


            Books book0 = new Books();
            book0.Name = "SwarGyan";
            book0.Author = "bhagvan";
            /*
            //ArrrayLists are Dynamically typed
            //cool features like sorting ,  remove items 

            ArrayList myarraylist = new ArrayList();
            myarraylist.Add(car0);
            myarraylist.Add(car1);
            myarraylist.Add(car2);
            myarraylist.Add(book0);

            foreach(Cars car in myarraylist)
            {
                Console.WriteLine(car.Make);
            }
            */
            /*
            //List<l>
            List<Cars> myList = new List<Cars>();
            myList.Add(car0);
            myList.Add(car1);
            myList.Add(car2);
            foreach (Cars car in myList)
            {
                Console.WriteLine(car.Make);
            }
            //Dictionary
            Dictionary<string ,Cars> MyDictionary = new Dictionary<string,Cars>();

            MyDictionary.Add(car0.VIN,car0);
            Console.WriteLine(MyDictionary["A1"].Make);

            */
            //Object Initializer
            //Cars car = new Cars() { Make = "TATA", Model = "Jaguar" };

            /*//Collection Initailizer
            List<Cars> Mycars = new List<Cars>()
            {
                new Cars { Make="Mahindra" , Model="Curve"},
                new Cars { Make="Toyota" , Model="duster"}
            };
            */
        }
    }
    class Cars
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string VIN { get; set; }


    }
    class Books
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }
}
