using System;

namespace MyApplication
{
  class MovieTV: Media
  {
    //buncha properties
    public string Streaming 
    { get; set; }

		public string Director 
    { get; set; }

		//default constructor
		public MovieTV(): base() {
			Streaming = "";
			Director = "";
		}

		//override constructor
		public MovieTV(string newTitle, int newYearConsumed, string newGenre, string newNotes, string newStreaming, string newDirector): base(newTitle, newYearConsumed, newGenre, newNotes) {
			Streaming = newStreaming;
			Director = newDirector;
		}

		//override tostring for printing
		public override string ToString() {
			return $"\n**MOVIE OR TV**\nTitle: {Title}\nStreaming Service: {Streaming}\nDirected By: {Director}\nGenre: {Genre}\nYear Consumed: {YearConsumed}\nNotes: {Notes}";
		}

		//practicing polymorphism
		public override void whichClass() {
			Console.WriteLine("Reporting from the Movie/TV Child class.");
		}

		//garbage collection w destructor
		~MovieTV(){
			Console.WriteLine("MovieTV destructor called");
		}

  } //end class
} //end namespace