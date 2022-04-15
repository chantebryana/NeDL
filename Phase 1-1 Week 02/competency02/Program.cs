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
		
		//parse even/odd indexes of single array into another single array
		static string[] parseArray (string[] singleArray, int zeroOrOne) {
			//initialize variables
			string[] tempArr = new string[((singleArray.Length)/2)];
			int j = 0;

			//loop through single array
			for (int i = 0; i < singleArray.Length; i++) {
				//parse even/odd elements into temp array
				if (i % 2 == zeroOrOne) {
					tempArr[j] = singleArray[i];
					j++;
				} //end if
			} //end for

			//return parsed array
			return tempArr;
		}

		//print contents of each array
		static void printArrays (string[] arr1, string[] arr2) {
			//loop through each array; only print elements with info
				for (int i = 0; i < arr1.Length; i++) {
						//stop loop if element is empty
						if (arr1[i] == null) {
							break;
						} else if ( arr1[i] == "") {
							break;
						} //end if/else
						
						//if element has contents, then print them to the console
						Console.WriteLine($"{arr1[i]} Rating: {arr2[i]}");
				} //end for
		}

		static void Main(string[] args)
    {
			//declare variables
			bool userChoice;
			string userChoiceString;
			int arrLength = 25;
			string fileName = "restRate.txt";
			string[] restaurantArr = new string[arrLength];
			string[] ratingArr = new string[arrLength];

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
					restaurantArr = parseArray(tempArray, 0);
					ratingArr = parseArray(tempArray, 1);

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

					//print contents of each array to user
					printArrays(restaurantArr, ratingArr);

				}

				//U - UPDATE - OPTIONAL
				else if (userChoiceString == "U") {
					Console.WriteLine("UPDATE RATING");

				}

				//D - DELETE - OPTIONAL
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