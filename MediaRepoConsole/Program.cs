using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			//create array
			int arrayLength = 10;
			Book[] books = new Book[arrayLength];

			for (int i = 0; i < books.Length; i++) {
				books[i] = new Book();
			};

			books[0].Title = "Old Jules";
			books[0].Author = "Mari Sandoz";
			books[0].YearConsumed = 2022;
			books[0].YearCreated = 1935;
			books[0].Notes = "unromaticized depiction of early-settlement times in western Nebraska";

			Console.WriteLine(books[0]);

    } //end main
  } //end class
} //end namespace