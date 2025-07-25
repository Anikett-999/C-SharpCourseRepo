namespace HandlingException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"E:\C#\MyClient\new.tx");
                Console.WriteLine(content);
            }
            catch(FileNotFoundException Ex)
            {
                Console.WriteLine("Problem While Reading File !");
                Console.WriteLine(Ex.Message);
            }
            catch(DirectoryNotFoundException)
            {
                Console.WriteLine(@"Directory Not Found:Make Sure is " +
                    "E:\\C#\\MyClient these directories exists");
            }
            catch(Exception ex)
            {
                Console.WriteLine("CRecheck File Path " + ex.Message);
            }
            finally
            {
                //code to finallize
                //settiing objects to null 
                //Closing database connections
                Console.WriteLine("Closing the Application !");
            }
            Console.ReadLine();
            
        }
    }
}
