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
		public MovieTV(string newTitle, int newYearConsumed, string newNotes, string newStreaming, string newDirector): base(newTitle, newYearConsumed, newNotes) {
			Streaming = newStreaming;
			Director = newDirector;
		}

		//override tostring for printing
		public override string ToString() {
			return $"\n**MOVIE OR TV**\nTitle: {Title}\nStreaming Service: {Streaming}\nDirected By: {Director}\nYear Consumed: {YearConsumed}\nNotes: {Notes}";
		}


  } //end class
} //end namespace