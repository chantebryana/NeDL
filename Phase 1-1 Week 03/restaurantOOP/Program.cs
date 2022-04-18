using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			Restaurant myObj = new Restaurant();
      myObj.RName = "Pepe's Veggie Bistro";
      Console.WriteLine(myObj.RName);
      
    } //end Main
  } //end class
} //end namespace