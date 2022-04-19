using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			//instantiate array of type Restaurant [object]
			Restaurant[] restArr = new Restaurant[25];

			//loop through array and set each index to a new instance of Restaurant
			/*
			foreach (var element in restArr) {
				element = new Restaurant();
			}
			*/

			for (int i = 0; i < restArr.Length; i++) {
				restArr[i] = new Restaurant();
			}


      restArr[0].RName = "Pepe's Veggie Bistro";
			restArr[0].RRating = 5;
      //Console.WriteLine(myObj.RName + ": " + myObj.RRating);
			Console.WriteLine(restArr[0]);
      
    } //end Main
  } //end class
} //end namespace