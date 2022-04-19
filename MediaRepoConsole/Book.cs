using System;

namespace MyApplication
{
  class Book: Media
  {
    //buncha properties
    public string Author 
    { get; set; }

		//default constructor
		public Book(): base() {
			Author = "";
		}

		//override constructor
		public Book(string newTitle, int newYearConsumed, int newYearCreated, string newNotes, string newAuthor) {
			Title = newTitle;
			YearConsumed = newYearConsumed;
			YearCreated = newYearCreated;
			Notes = newNotes;
			Author = newAuthor;
		}

		//override tostring for printing
		public override string ToString() {
			return $"Title: {Title}\nAuthor: {Author}\nYear Created: {YearCreated}\nYear Consumed: {YearConsumed}\nNotes: {Notes}";
		}


  } //end class
} //end namespace