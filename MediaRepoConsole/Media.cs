using System;

namespace MyApplication
{
  class Media
  {
    //buncha properties
    public string Title 
    { get; set; }

		public int YearConsumed 
    { get; set; }

		public string Genre
		{ get; set; }

		public string Notes 
    { get; set; }

		//default constructor
		public Media() {
			Title = "";
			YearConsumed = -1;
			Genre = "";
			Notes = "";
		}

		//override constructor
		public Media(string newTitle, int newYearConsumed, string newGenre, string newNotes) {
			Title = newTitle;
			YearConsumed = newYearConsumed;
			Genre = newGenre;
			Notes = newNotes;
		}

		//practicing polymorphism
		public virtual void whichClass() {
			Console.WriteLine("Reporting from the Media Parent class.");
		}

		//garbage collection w destructor
		~Media(){
			Console.WriteLine("Media destructor called");
		}

  } //end class
} //end namespace