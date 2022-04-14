using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      //prompt user for numbers; grab input and convert from string to int
      Console.WriteLine("How much money's in my piggy bank?");
      Console.WriteLine("User: Enter number of pennies, then press ENTER.");
      int penny = Convert.ToInt16(Console.ReadLine());
      
      Console.WriteLine("User: Enter number of nickles, then press ENTER.");
      int nickle = Convert.ToInt16(Console.ReadLine());
      
      Console.WriteLine("User: Enter number of dimes, then press ENTER.");
      int dime = Convert.ToInt16(Console.ReadLine());
      
      Console.WriteLine("User: Enter number of quarters, then press ENTER");
      int quarter = Convert.ToInt16(Console.ReadLine());

      //logic that calculates how much change
      //(don't need to calculate pennies)
      int nickleCost = nickle * 5;
      int dimeCost = dime * 10;
      int quarterCost = quarter * 25;

      //add all the change together and convert to dollars (not pennies)
      double money = (penny + nickleCost + dimeCost + quarterCost) / 100.00;

      //output results to user
      Console.WriteLine("You've got $" + money + " in your piggybank!");
    }
  }
}