/*

*/

/*
using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      try
      {
        //initialize array
				int[] myNumbers = {1, 2, 3};

				//ask user which index to print out
				Console.WriteLine("Which index of the array to print? (integer between 1 and 10)");
				string userInput = Console.ReadLine();
				int userInt = Convert.ToInt16(userInput);

        //print the selected element
				Console.WriteLine(myNumbers[userInt]);
      }
      catch (FormatException fe) {
				Console.WriteLine("Woops 'fe' error: " + fe.Message);
			}
			
			catch (Exception e)
      {
        Console.WriteLine("Woops 'e' error: " + e.Message);
      }    
    }
  }
}
*/