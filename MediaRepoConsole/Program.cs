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

			//create list of type Media
			List<Media> mediaConsumed = new List<Media>();

			//populate some list elements
			mediaConsumed.Add(new Book("Intelligent Life in the Universe", 2021, "Nonfiction", "Chapter 2 the best chapter ever: Saturnian aliens in Nebraska!", "Carl Sagan and I.S. Shklovskii"));
			mediaConsumed.Add(new MovieTV("Legend of the Drunken Master (aka Drunken Master II)", 2019, "Kung Fu", "Great!! Amazing fighting! Death to Evil Western Imperialists!! ;-)", "Interwebs", "Jackie Chan"));

			//if list element isn't empty, print to console
			for (int i = 0; i < mediaConsumed.Count; i++) {
				if (mediaConsumed[i].YearConsumed != -1) {
					Console.WriteLine(mediaConsumed[i]);
				}
			} //end for

    } //end main
  } //end class
} //end namespace