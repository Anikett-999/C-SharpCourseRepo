namespace DateAndTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime value = DateTime.Now;
            Console.WriteLine(value.ToString());
            //Date
            Console.WriteLine(value.ToShortDateString());
            Console.WriteLine(value.ToLongDateString());

            //Time
            Console.WriteLine(value.ToShortTimeString());
            Console.WriteLine(value.ToLongTimeString());

            //adding and substracting days 
            Console.WriteLine(value.AddDays(3).ToShortDateString());
            Console.WriteLine(value.AddDays(-3).ToShortDateString());

            //declaring custom date 
            DateTime mybirthday = new DateTime(2005 , 12 ,18);
            Console.WriteLine(mybirthday.ToShortDateString());


            //other way to declare and initialize a date 
            DateTime mybd = DateTime.Parse("18 / 12 / 2005");
            //want to calculate the my age 
            TimeSpan myage = DateTime.Now.Subtract(mybd);
            Console.WriteLine(myage.TotalDays);


        }
    }
}
