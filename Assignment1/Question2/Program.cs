using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter value of n1");
            //String n1value= Console.ReadLine();
            int n1 = Convert.ToInt32(args[0]);

            //Console.WriteLine("Enter Value for n2");
            //string n2Value = Console.ReadLine();
            int n2 = Convert.ToInt32(args[1]);

            //Console.WriteLine("Enter Choice");
            string choice = args[2];

            switch (choice)
            {
                case "+":
                    Console.WriteLine("addition= " + (n1 + n2));                    
                    break;
                case "-":
                    Console.WriteLine("Substration= " + (n1 - n2));
                    break;
                case "*":
                    Console.WriteLine("Multiplication= " + (n1* n2));
                    break;
                case "/":
                    Console.WriteLine("Division= " + (n1 / n2));
                    break;                
                default:
                    Console.WriteLine("Wrong choice");
                    break;
            }


            Console.ReadLine();

        }
    }
}
