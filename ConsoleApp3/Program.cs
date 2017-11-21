using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace rara
{
class Program
    {
        static void Main(string[] args)
        {   int nul= 0;
            int[] numbers = new int[]{ 1, 2, 3, 4, 5 };
            int cosinus = 60; 
            bool isNumber = false;
            int randomchislo = 3;
            Console.Write(Math.Cos(cosinus));
            Console.BackgroundColor = ConsoleColor.Blue;//sssssssssss comment
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("I like games!!!\n");
            Console.WriteLine("I like anime!!!");
            Console.WriteLine(randomchislo);
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.Write("Enter the number\n");
            int nume = int.Parse(Console.ReadLine());
            Console.Write("your number"nume);
            Console.ReadLine();
            
            
        }
    }
}       
            
           
 
