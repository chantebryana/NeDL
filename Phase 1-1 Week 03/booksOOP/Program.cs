using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			//set local variables
			string title = "Old Jules";
			string author = "Mari Sandoz";
			int yearRead = 2022;
			string notes = "This book is a biography of Mari's father and of western Nebraska from the 1880s through the 1930s. As many reviewers state, this is an unromanticized depiction of both her father and the land. A highly-recommended read for anyone from Nebraska, interested in pioneer history, or appreciative of good writing.";

			
			//declare values; create two-dimensional book array
			int arrSize = 10;
			Book[] bookCollection = new Book[arrSize];

			//instantiate Book object for each array element
			for (int i = 0; i < bookCollection.Length; i++) {
					bookCollection[i] = new Book();
			}

			//set first book!
			bookCollection[0].Title = title;
			bookCollection[0].Author = author;
			bookCollection[0].YearRead = yearRead;
			bookCollection[0].Notes = notes;

			//set second book
			bookCollection[1].Title = "Foundation";
			bookCollection[1].Author = "Isaac Asimov";
			bookCollection[1].YearRead = 2021;
			bookCollection[1].Notes = "Asimov's simple prose and story lines employ some of my favorite scifi tropes: using technological advances as a lens to explore the human condition.";

			Console.WriteLine(bookCollection[0]);
			Console.WriteLine(bookCollection[1]);

    } //end Main
  } //end class Program
} //end namespace MyApp