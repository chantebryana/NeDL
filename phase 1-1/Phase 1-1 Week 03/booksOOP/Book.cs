using System;

namespace MyApplication
{
  class Book
  {
    //Title property
		public string Title 
    { get; set; }  

		//Author property
		public string Author
		{ get; set; }

		//Year Read property
		public int YearRead
		{ get; set; }

		//Notes property
		public string Notes
		{ get; set; }

		//default constructor
		public Book () {
			Title = "";
			Author = "";
			YearRead = -1;
			Notes = "";
		}

		//overridden constructor with arguments
		public Book (string newTitle, string newAuthor, int newYearRead, string newNotes) {
			Title = newTitle;
			Author = newAuthor;
			YearRead = newYearRead;
			Notes = newNotes;
		}

		//adapt tostring for console wl
		public override string ToString() {
			return $"    Read {Title} by {Author} in {YearRead}\n    Thoughts: {Notes}\n";
		}
  } //end class book
} //end namespace myapp