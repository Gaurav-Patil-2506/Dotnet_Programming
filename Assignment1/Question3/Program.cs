using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    internal class Program
    {
        static int plusMethod(int n1, int n2)
        {
            return n1 + n2;
        }

        static int substractMethod(int n1, int n2)
        {
            return n1 - n2;
        }
        static int multiplyMethod(int n1, int n2)
        {
            return n1 * n2;
        }

        static int divisionMethod(int n1, int n2)
        {
            return n1 / n2;
        }
        static void Main(string[] args)
        {
            
            int choice;
            
            do
            {           
                
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Substraction");
                Console.WriteLine("3.Multiply");
                Console.WriteLine("4.Divison");
                Console.WriteLine("Enter choice");
                string choiceValue = Console.ReadLine();
                choice = Convert.ToInt32(choiceValue);

                Console.WriteLine("Enter value of n1");
                String n1value = Console.ReadLine();
                int n1 = Convert.ToInt32(n1value);

                Console.WriteLine("Enter Value for n2");
                string n2Value = Console.ReadLine();
                int n2 = Convert.ToInt32(n2Value);

                switch (choice)
                {
                    case 0: Console.WriteLine("exit");
                        
                        break;
                    case 1: Console.WriteLine("Addition- ");
                        Console.WriteLine(plusMethod(n1, n2)); 
                        
                        break;
                    case 2: Console.WriteLine("Substraction- ");
                        Console.WriteLine(substractMethod(n1, n2));
                        break;
                    case 3: Console.WriteLine("Multiplication- ");
                        Console.WriteLine(multiplyMethod(n1, n2));
                        break;
                    case 4: Console.WriteLine("Division- ");
                        Console.WriteLine(divisionMethod(n1, n2));
                        break;

                }
                

            } while (choice!=0);
        }
    }
}
