using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			//create a book entry
			var bookListEntry = new List<KeyValuePair<string, string>>();

			bookListEntry.Add(new KeyValuePair<string, string>("title", "Children of Time"));
			bookListEntry.Add(new KeyValuePair<string, string>("title", "Old Jules"));
			bookListEntry.Add(new KeyValuePair<string, string>("title", "Foundation"));

			foreach (var val in bookListEntry) {
				Console.WriteLine(val);
			}
			
			/*
			{
				"title": "",
				"authorFirst": "", 
				"authorLast": "",
				"published": "", 
				"genre": "",
				"yearConsumed": "",
				"notes": ""
			};
			*/

    } //end main
  } //end class
} //end namespace