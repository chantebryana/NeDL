using System;

namespace MyApplication
{
  class MovieTV: Media
  {
    //buncha properties
    public string Streaming 
    { get; set; }

		public string LeadActor 
    { get; set; }

		//default constructor
		public MovieTV(): base() {
			Streaming = "";
			LeadActor = "";
		}

		//override constructor
		public MovieTV(string newTitle, int newYearConsumed, string newGenre, string newNotes, string newStreaming, string newLeadActor): base(newTitle, newYearConsumed, newGenre, newNotes) {
			Streaming = newStreaming;
			LeadActor = newLeadActor;
		}

		//override tostring for printing
		public override string ToString() {
			return $"\n**MOVIE OR TV**\nTitle: {Title}\nStreaming Service: {Streaming}\nLead Actor: {LeadActor}\nGenre: {Genre}\nYear Consumed: {YearConsumed}\nNotes: {Notes}";
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