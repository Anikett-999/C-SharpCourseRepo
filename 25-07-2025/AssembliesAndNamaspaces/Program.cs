using System.IO;
using System.Net; 
 namespace AssembliesAndNamaspaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a string  
            //string text = "Class is the most powerfull Datatype in the c#";

            

            //downloading source code as string 
            WebClient client  = new WebClient();
            string reply = client.DownloadString("https://learn.microsoft.com/");

            //writing source code to local file 
            File.WriteAllText(@"E:\C#\AssembliesAndNamaspaces\newfile.txt", reply);
            //Console.WriteLine(reply);
        }
    }
}
