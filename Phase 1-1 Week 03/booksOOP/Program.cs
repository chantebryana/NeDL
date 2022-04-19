using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			//declare values; create array object of type Book
			int arrSize = 10;
			Book[] books = new Book[arrSize];

			//instantiate Book object for each array element
			for (int i = 0; i < books.Length; i++) {
					books[i] = new Book();
			}

			//manually set first book!
			books[0].Title = "Old Jules";
			books[0].Author = "Mari Sandoz";
			books[0].YearRead = 2022;
			books[0].Notes = "This book is a biography of Mari's father and of western Nebraska from the 1880s through the 1930s. As many reviewers state, this is an unromanticized depiction of both her father and the land. A highly-recommended read for anyone from Nebraska, interested in pioneer history, or appreciative of good writing.";

			//set second book
			books[1].Title = "Foundation";
			books[1].Author = "Isaac Asimov";
			books[1].YearRead = 2021;
			books[1].Notes = "Asimov's simple prose and story lines employ some of my favorite scifi tropes: using technological advances as a lens to explore the human condition.";

			//set third book
			books[3].Title = "Piranesi";
			books[3].Author = "Susanna Clarke";
			books[3].YearRead = 2021;
			books[3].Notes = "Donna's bookclub read; read in 3 days during Schneider reunion; creative premise and satisfying build-up / resolution.";

			//set fourth book
			books[6].Title = "The Gigantic Beard That Was Evil";
			books[6].Author = "Stephen Collins";
			books[6].YearRead = 2020;
			books[6].Notes = "Xmas gift to Jim; Graphic Novel; So fun and good and creative and thoughtful.";

			//print to page if element contains book object with info
			for (int i = 0; i < books.Length; i++) {
				if (books[i].YearRead != -1) {
					Console.WriteLine(books[i]);
				}
			}
    } //end Main
  } //end class Program
} //end namespace MyApp