using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DisplayFibonacciSeries
{
    public class Program
    {
        public static void Main(string[] args)
        {
            do 
            {
                // User input for number of terms. //
                int n = 10;
                do
                {
                    Console.WriteLine(); // Adds spaces between lines to make it look good. //
                    Console.Write("Eter the number of terms in the Fibonacci series (non-negative): ");
                    
                } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
                
                // Calls function to display the FBS. //
                Console.WriteLine(); // Adds spaces between lines to make it look good. //
                Console.WriteLine("\u001B[32mThe Fibonacci series number of {0} is\u001B[0m:", n);
                DisplayFibonacciSeries(n);
                Console.WriteLine(); // Adds spaces between lines to make it look good. //
                Console.WriteLine(); // Adds spaces between lines to make it look good. //
                
                // Asks user to continue or not. //
                // Added ANSI colour just for fun. // 
                Console.Write("\u001B[33mDo you want to Continue (\u001b[0m" +
                    "\u001B[32m'y'\u001B[0m " +
                    "\u001b[33m/\u001b[0m " +
                    "\u001B[31m'n'\u001B[0m" +
                    "\u001b[33m)\u001b[0m" +
                    ": ");
                

            } while (Console.ReadLine().ToLower() == "y");
            

            // If not this text appear. //
            Console.WriteLine("Exiting program...");

        }
        // Function to display the funcion // 
        public static void DisplayFibonacciSeries(int n)
        {
            // "If" statement handles nagative inputs and display text. // 
            if (n < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative number.");
                return;
            }
            // Prints the first number outside the loop. //
            int prev1 = 0, prev2 = 1;
            Console.WriteLine(); // Adds space between lines to make it look good. //
            // Start loop fom 1 and avoids printing 0 twice. //
            for (int i = 0; i < n; i++) 
            {
                // Prints the current number (prev1). //
                Console.Write(prev1 + " ");

                // Calculate the next FBS number. // 
                int next = prev1 + prev2; 

                // Updates next variable. // 
                prev1 = prev2;
                prev2 = next;
               
            }
            
        } 
    }
}
