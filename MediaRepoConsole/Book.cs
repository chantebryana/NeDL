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
		public Book(string newTitle, int newYearConsumed, string newNotes, string newAuthor): base(newTitle, newYearConsumed, newNotes) {
			Author = newAuthor;
		}

		//override tostring for printing
		public override string ToString() {
			return $"\n**BOOKS**\nTitle: {Title}\nAuthor: {Author}\nYear Consumed: {YearConsumed}\nNotes: {Notes}";
		}


  } //end class
} //end namespace