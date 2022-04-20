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

		public string Notes 
    { get; set; }

		//default constructor
		public Media() {
			Title = "";
			YearConsumed = -1;
			Notes = "";
		}

		//override constructor
		public Media(string newTitle, int newYearConsumed, string newNotes) {
			Title = newTitle;
			YearConsumed = newYearConsumed;
			Notes = newNotes;
		}


  } //end class
} //end namespace