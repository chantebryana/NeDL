using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			//play w parent class
			Media medias = new Media();
			medias.whichClass();
			
			//create array of type Book
			int arrayLength = 10;
			Book[] books = new Book[arrayLength];

			//instantiate elements of array as new Book object
			for (int i = 0; i < books.Length; i++) {
				books[i] = new Book();
			};

			//populate some array elements
			books[0].Title = "Old Jules";
			books[0].Author = "Mari Sandoz";
			books[0].YearConsumed = 2022;
			books[0].Genre = "Biography, Fiction";
			books[0].Notes = "Unromaticized depiction of early-settlement times in western Nebraska";

			books[1].Title = "Children of Time";
			books[1].Author = "Adrian Tchaikovski";
			books[1].YearConsumed = 2022;
			books[1].Genre = "SciFi";
			books[1].Notes = "omg sentient spiders space opera";

			books[0].whichClass();

			//if array element isn't empty, print to console
			for (int i = 0; i < books.Length; i++) {
				if (books[i].YearConsumed != -1) {
					Console.WriteLine(books[i]);
				}
			}


			//create array of type MovieTV
			MovieTV[] movies = new MovieTV[arrayLength];

			//instantiate elements of array as new MovieTV object
			for (int i = 0; i < movies.Length; i++) {
				movies[i] = new MovieTV();
			};

			//populate some array elements
			movies[0].Title = "Howard's End";
			movies[0].Director = "James Ivory";
			movies[0].Streaming = "Netflix";
			movies[0].YearConsumed = 2021;
			movies[0].Genre = "Based on Book";
			movies[0].Notes = "Anthony Hopkins: Don't look at me!";

			movies[1].Title = "Excalibur";
			movies[1].Director = "John Boorman";
			movies[1].Streaming = "interwebs";
			movies[1].YearConsumed = 2022;
			movies[1].Genre = "EPIC";
			movies[1].Notes = "King Arthur so epic";

			movies[0].whichClass();

			//if array element isn't empty, print to console
			for (int i = 0; i < movies.Length; i++) {
				if (movies[i].YearConsumed != -1) {
					Console.WriteLine(movies[i]);
				}
			}

    } //end main
  } //end class
} //end namespace