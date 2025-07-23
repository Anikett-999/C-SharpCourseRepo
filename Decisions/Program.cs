// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using Microsoft.VisualBasic;
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        string msg;
        // Get User Input 
        Console.WriteLine("It's a Give Away From Anyas side :");
        Console.Write("Enter Your Number Between 1 to 3:");
        String num = Console.ReadLine();
        if (num == "1")
             msg = "Yeah You won a Car !";

        else if (num == "2")
          msg = "Yeah You won A boat";
        
        else if (num == "3")
          msg = "Yeah You Won A Bike";
        
        else
            msg = "Sorry you Got nothing !";
        

        Console.WriteLine(msg);

    }
}