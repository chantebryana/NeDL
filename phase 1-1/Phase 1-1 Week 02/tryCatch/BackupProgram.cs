/*
//from https://www.completecsharptutorial.com/basic/try-catch-finally.php

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
     
    namespace Exception_Handling
    {
        class Program
        {
            static void Main(string[] args)
            {
                label:
                // Try block: The code which may raise exception at runtime
                try
                {
                    int num1, num2;
                    decimal result;
                    
                    Console.WriteLine("Divide Program. You Enter 2 numbers and we return result");
                    Console.WriteLine("Enter 1st Number: ");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter 2nd Number: ");
                    num2 = Convert.ToInt32(Console.ReadLine());
     
                    result =(decimal)num1 / (decimal)num2;
                    Console.WriteLine("Divide : " + result.ToString());
                    Console.ReadLine();
                }
     
               //Multiple Catch block to handle exception
     
                catch (DivideByZeroException dex)
                {
                    Console.WriteLine("You have Entered the number 0");
                    Console.WriteLine("More Details about Error 'dex': \n\n" + dex.ToString() + "\n\n");
                    goto label;
                }
     
                catch (FormatException fex)
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("More Details about Error 'fex': \n\n" + fex.ToString() + "\n\n");
                    goto label;
                }
     
                //Parent Exception: Catch all type of exception
     
                catch (Exception ex)
                {
                    Console.WriteLine("Other Exception raised 'ex'" + ex.ToString() + "\n\n");
                    goto label;
                }
     
               //Finally block: it always executes
     
                finally
                {
                    Console.WriteLine("Finally Block: To Continue Press Enter; to Exit press CTRL + C");
                    Console.ReadLine();
                }
            }
        }
    }

*/