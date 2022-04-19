using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			//instantiate Book object
			Book bookCollection = new Book();

			//set variables
			bookCollection.Title = "Old Jules";
			bookCollection.Author = "Mari Sandoz";
			bookCollection.YearRead = 2022;
			bookCollection.Notes = "This book is a biography of Mari's father and of western Nebraska from the 1880s through the 1930s. As many reviewers state, this is an unromanticized depiction of both her father and the land. A highly-recommended read for anyone from Nebraska, interested in pioneer history, or appreciative of good writing.";

			Console.WriteLine($"Title: {bookCollection.Title}");
			Console.WriteLine($"Author: {bookCollection.Author}");
			Console.WriteLine($"Year Read: {bookCollection.YearRead}");
			Console.WriteLine($"Notes: {bookCollection.Notes}");

    } //end Main
  } //end class Program
} //end namespace MyApp