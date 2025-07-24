using System.Text;

namespace workingWithString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*


            string mystring = " my \"so-called\" life";
            Console.WriteLine(mystring);
            string str1 = "what is i need to \nadd new line !";
            Console.WriteLine(str1);
            //@ tell compiler that it using  \ as a strign not escape character 
            string str2 = @"my file location is c:\c#";
            Console.WriteLine(str2);

            //Format method 
            string final = string.Format("{0} = {1}  Format method ", "First", "Second");
            Console.WriteLine(final);

            //format currency wise
            string amount = string.Format("{0:C}", 123.4);
            Console.WriteLine(amount);
            amount = string.Format("{0:N}", 123555.56);
            Console.WriteLine(amount);

            //percentage
            amount = string.Format("{0:P}", 90);
            Console.WriteLine(amount);

            //Custom formatting 
            string str = string.Format("{0:(###) ###-###} ", 12345678901);
            Console.WriteLine(str);

            //strign heping mehtods 
            string song = " I am Top of the World !  ";

            //substring 
            Console.WriteLine(song.Substring(6));
            Console.WriteLine(song.Substring(6, 14));

            //Uppercase 
            Console.WriteLine(song.ToUpper());
            //Lower case
            Console.WriteLine(song.ToLower());

            Console.Clear();

            //replace method
            song = song.Replace(' ', '-');
            Console.WriteLine(song);

            
            */
            //Trim method 
            // printin lenght of the string  
            
            string r = " hey ";
            Console.WriteLine(r.Trim().Length);
            string len = string.Format("Length of song Before trim :{0} \nLength After trim :{1}", r.Length, r.Trim().Length);
            Console.WriteLine(len);


            string samp = "Aniket  Bedre";
            string removed = samp.Remove(3, 5);
            Console.WriteLine(removed);
            /* tostring
            string row = " ";
            for(int i = 0;i< 100; i++)
            {
                row += "--"+i.ToString();  
            }
            Console.WriteLine(row);*/

            StringBuilder mystr = new StringBuilder();
            
            for(int i=0; i<= 100; i++)
            {
                mystr.Append("--");
                mystr.Append(i);
            }
            Console.WriteLine(mystr);
        }


    }
}
