using System;

namespace MyApplication
{
  class Program
  {
    //print option menu and return user input
		static string askUserMenuOptions () {
			//print menu options
			Console.WriteLine("");
			Console.WriteLine("Select a Menu Option:");
			Console.WriteLine("   O: Open the user's list of restaurants.");
			Console.WriteLine("   S: Save the user's list of restaurants.");
			Console.WriteLine("   C: Add a restaurant and rating.");
			Console.WriteLine("   R: Read and print a list of all the restaurants and their ratings.");
			Console.WriteLine("   U: Update the rating for a restaurant.");
			Console.WriteLine("   D: Delete a restaurant.");
			Console.WriteLine("   Q: Quit the program.");

			//return user input, converted to upper-case
			return Console.ReadLine().ToUpper();
		}
		
		static void Main(string[] args)
    {
			//declare variables
			bool userChoice;
			string userChoiceString;
			int rowMax = 25;
			int columnMax = 2;
			string fileName = "restRate.txt";
			string[,] restRateArr = new string[rowMax, columnMax];

			//repeat till user quits
			do {
				//get valid user input
				do {
					//initialize variable
					userChoice = false;

					//provide the user a list of menu options
					//get valid user input
					userChoiceString = askUserMenuOptions();

					//valid user choices
					userChoice = (userChoiceString == "O" || 
												userChoiceString == "S" || 
												userChoiceString == "C" || 
												userChoiceString == "R" || 
												userChoiceString == "U" || 
												userChoiceString == "D" || 
												userChoiceString == "Q"
					);
					//if user enters invalid choice, repeat till correct
					if (!userChoice) {
						Console.WriteLine("Oops! Please enter a valid menu option");
					}
				} while (!userChoice) ; //end inner do

				//logic for individual user choices
				//O - OPEN
				if (userChoiceString == "O") {
					Console.WriteLine("OPEN FILE");

				}

				//S - SAVE
				else if (userChoiceString == "S") {
					Console.WriteLine("SAVE FILE");

				}

				//C - CREATE
				else if (userChoiceString == "C") {
					Console.WriteLine("CREATE NEW RESTAURANT");

				}

				//R - READ/PRINT
				else if (userChoiceString == "R") {
					Console.WriteLine("READ FILE");

				}

				//U - UPDATE
				else if (userChoiceString == "U") {
					Console.WriteLine("UPDATE RATING");

				}

				//D - DELETE
				else if (userChoiceString == "D") {
					Console.WriteLine("DELETE RESTAURANT");

				}

				//Q - QUIT
				else {
					Console.WriteLine("~~~Adios Sayōnara Goodbye Chao Mae Alsalama~~~");
				} //end if/else

			} while (!(userChoiceString == "Q")) ; //end outer do
    } //end main
  } //end class
} //end namespace