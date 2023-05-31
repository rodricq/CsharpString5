using System;

namespace CsharpString5
{
    class Test
    {
       public static void Main(string[] args)
        {
            //create string 

            string name = "Programiz";

            //string interpolation
            string message = $"Welcome to {name}";
            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
