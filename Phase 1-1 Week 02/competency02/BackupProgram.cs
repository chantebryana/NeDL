/*
using System;
using System.IO;

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
		
		//single array into two-dimensional array
		static string[,] singleToDouble (string[] singleArray, int rowIndex, int columnIndex) {
			//initialize variable
			string[,] tempDouble = new string[rowIndex, columnIndex];
			int rowCounter = 0;
			int columnCounter = 0;

			//loop through single array
			for (int i = 0; i < singleArray.Length; i++) {
				//if index is even, populate column 1
				if (i % 2 == 0) {
					tempDouble[rowCounter, columnCounter] = singleArray[i];
					rowCounter++;
				}

				//else if index odd, populate column 2
				else {
					tempDouble[rowCounter, columnCounter] = singleArray[i];
					
					//toggle columnCounter between 1 and 0
					if (columnCounter == 0) {
						columnCounter = 1;
					} else {
						columnCounter = 0;
					}

				} //end if/else
				Console.WriteLine(tempDouble[rowCounter, columnCounter]);
			} //end for

			return tempDouble;
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

					//initialize variables
					string[] tempArray = new string[50];
					int i = 0;
					string s;

					//read file; push contents into array
					using (StreamReader sr = File.OpenText(fileName)) {
						//if file line isn't empty
						//then push line contents to element of array
						while ((s = sr.ReadLine()) != null) {
							tempArray[i] = s;
							i++;
						} //end while
					} //end using

					//split tempArray into two-dimensional array (to use elsewhere in app)
					restRateArr = singleToDouble(tempArray, rowMax, columnMax);

					//give user status update
					Console.WriteLine("File successfully opened.");
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
*/