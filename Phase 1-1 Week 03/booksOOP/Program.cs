using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			//declare values; create two-dimensional book array
			int arrSize = 10;
			Book[] bookCollection = new Book[arrSize];

			//instantiate Book object for each array element
			for (int i = 0; i < bookCollection.Length; i++) {
					bookCollection[i] = new Book();
			}

			//set first book!
			bookCollection[0].Title = "Old Jules";
			bookCollection[0].Author = "Mari Sandoz";
			bookCollection[0].YearRead = 2022;
			bookCollection[0].Notes = "This book is a biography of Mari's father and of western Nebraska from the 1880s through the 1930s. As many reviewers state, this is an unromanticized depiction of both her father and the land. A highly-recommended read for anyone from Nebraska, interested in pioneer history, or appreciative of good writing.";

			//set second book
			bookCollection[1].Title = "Foundation";
			bookCollection[1].Author = "Isaac Asimov";
			bookCollection[1].YearRead = 2021;
			bookCollection[1].Notes = "Asimov's simple prose and story lines employ some of my favorite scifi tropes: using technological advances as a lens to explore the human condition.";

			//set third book
			bookCollection[3].Title = "Piranesi";
			bookCollection[3].Author = "Susanna Clarke";
			bookCollection[3].YearRead = 2021;
			bookCollection[3].Notes = "Donna's bookclub read; read during Schneider reunion; creative rpemise and satisfying build-up / resolution.";

			//set fourth book
			bookCollection[6].Title = "The Gigantic Beard That Was Evil";
			bookCollection[6].Author = "Stephen Collins";
			bookCollection[6].YearRead = 2020;
			bookCollection[6].Notes = "Xmas gift to Jim; Graphic Novel; So fun and good and creative and thoughtful.";

			//print to page if element contains book object with info
			for (int i = 0; i < bookCollection.Length; i++) {
				if (bookCollection[i].YearRead != -1) {
					Console.WriteLine(bookCollection[i]);
				}
			}

    } //end Main
  } //end class Program
} //end namespace MyApp