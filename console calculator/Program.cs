
using System;
using System.ComponentModel;
using System.Net;
using static System.Console;

namespace console_calculator
{
   
    internal class Program 
    {
       static int Add(int x,int y)
        {
          // update consoleee 
            return x + y;

        }
        static int Subtrtact (int x,int y)
        {
          // subtract
            return x - y;

        }
        static int Multiply (int x,int y)
        {
            // update eslam
            int w;
            return x * y;
        }
        static double Divide(int x, int y)
        {
           
            return (double)(x) / y;

        }    





        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!\n");

            Console.WriteLine("Enter first number:");
            int num1;
            bool ch1 = int.TryParse(Console.ReadLine(), out num1);

            bool ch = true;
            
            while (ch)
            {
                if (ch1 == true)
                {
                    ch = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for the first number:");
                    ch1= int.TryParse(Console.ReadLine(), out num1);    
                }
            }
            Console.WriteLine("\nEnter second number:");
            int num2;
            bool ch2 = int.TryParse(Console.ReadLine(), out num2);

            ch = true;

            while (ch)
            {
                if (ch2 == true && num2 !=0 )
                {
                    ch = false;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer for the second number and not enter zero for second number :");
                    ch2 = int.TryParse(Console.ReadLine(), out num2);
                }
            }
            Console.WriteLine("-----------------------------------");
            while (true)
            {

                Console.WriteLine("enter and select your operation add:1, subtract:2, multiply:3, divide:4, exit:5");
                int option;
                option = Convert.ToInt32(Console.ReadLine());   
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Addition result: " + Add(num1, num2));
                        Console.WriteLine("--------------------------------");
                        break;
                    case 2:
                        Console.WriteLine("Subtraction result: " + Subtrtact(num1, num2));
                        Console.WriteLine("--------------------------------");
                        break;
                    case 3:
                        Console.WriteLine("Multiplication result: " + Multiply(num1, num2));
                        Console.WriteLine("--------------------------------");
                        break;
                    case 4:
                        
                            Console.WriteLine("Division result: " + Divide(num1, num2));
                            Console.WriteLine("--------------------------------");  
                        break;
                    case 5:
                        Console.WriteLine("Exiting the calculator. Goodbye!");
                        Console.WriteLine("--------------------------------");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid operation.");
                        break;
                }


            }













        }
    }

}
