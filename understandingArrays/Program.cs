namespace understandingArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array declaration
            //int[] nums = new int[5];
            int[] nums = {10,20,30,40,50};
            
            //printing length of array 
            Console.WriteLine("Length Of Numeric Array:"+nums.Length);

            //printing elements of the array 
            for(int i = 0;i<nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }


            Console.WriteLine("Printing Using For each:");
            foreach(int i in nums)
            {
                Console.WriteLine(i);

            }
            //string array
            string[] names = { "aniket", "amar", "rupesh" };
            Console.WriteLine("Printing Using For ");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.WriteLine("Printing Using foreach\n");
            foreach(string i in names)
            {
                Console.WriteLine(i);
            }
            Console.Write("Enter a Line to reverse it : ");
            string s = Console.ReadLine();
            reverseTheString(s);

            Console.Write("Enter First Name:");
            string fname = Console.ReadLine();
            Console.Write("Enter Mid Name:");
            string mname = Console.ReadLine();
            Console.Write("Enter Last Name:");
            string lname = Console.ReadLine();

            //reversing each name 
            string r_fname = reversenames(fname);
            string r_mname = reversenames(mname);
            string r_lname =  reversenames(lname);

            //printing each reversed name 
            Console.WriteLine("{0} {1} {2}", 
                r_fname, r_mname, r_lname);

            Console.ReadLine();

        }

        static void reverseTheString(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            foreach(char c in chars)
            {
                Console.Write(c);
            }
            Console.WriteLine();
        }
        static string reversenames(string st)
        {
            char[] c = st.ToCharArray();
            Array.Reverse(c);
            return string.Concat(c);
            /*foreach(char cr in c)
            {
                Console.Write(cr);
            }
            Console.Write(" ");
            */
        }
    }
}
