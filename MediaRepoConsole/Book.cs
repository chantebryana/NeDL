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
		public Book(string newTitle, int newYearConsumed, string newGenre, string newNotes, string newAuthor): base(newTitle, newYearConsumed, newGenre, newNotes) {
			Author = newAuthor;
		}

		//override tostring for printing
		public override string ToString() {
			return $"\n**BOOKS**\nTitle: {Title}\nAuthor: {Author}\nGenre: {Genre}\nYear Consumed: {YearConsumed}\nNotes: {Notes}";
		}

		//practicing polymorphism
		public override void whichClass() {
			Console.WriteLine("Reporting from the Book Child class.");
		}

		//garbage collection w destructor
		~Book(){
			Console.WriteLine("Book destructor called");
		}


  } //end class
} //end namespace