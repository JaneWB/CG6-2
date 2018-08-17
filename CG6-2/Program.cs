using System;

namespace CG6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a program that converts a normal sentence input by the user 
            //into all upper case and prints the value to the console.
            //Upload your program to a new repository called CG 6 - 2.
            //Upload a link to your repository here when you are finished.

            Console.WriteLine("Please enter a sentence, any sentence.");
            string myString = Console.ReadLine();

            myString = myString.ToUpper();
            Console.WriteLine(myString);
            Console.ReadLine();

        }
    }
}
