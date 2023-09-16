using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name: "); //Ask user to Enter their name

            String name = Console.ReadLine(); //The name that user had type

            Console.WriteLine($"Welcome, {name} !"); //Display Welcome and with their name


            int Sum = 0; // Start from Empty

            for (int i = 1; i <= 100; i++) // for is start the loop.. set i to 1 limit to 100, i++ is to loop to 100 by adding 1 
            {
                if (i % 3 == 0 || i % 5 == 0) // if i can be divided by 3 and(||) 5  
                {
                    Sum = Sum + i; // looping to 100
                }
            }
            Console.WriteLine($"The sum of multiples of 3 and 5 from 1 to 100 is: {Sum}"); //Display the sum 

            Console.ReadKey(); //keep the windows and answer display
        }
    }
}
