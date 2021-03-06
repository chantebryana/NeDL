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
		
		//parse even/odd indexes of single array into another single array
		//for OPEN
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
		//for READ
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

		//validate user input (lo and hi)
    static int ValidateInput(string userInput, int low, int high) {
        //convert string to int
				int inputInt = Convert.ToInt16(userInput);

				//if incorrect   
        if (inputInt < low || inputInt > high) {
						return 0;
        } 
        //if correct
        else {
            return 1;
        }
    }

		//verify whether array is full
		//for CREATE
		static int IsArrayFull(string[] array) {
			//count how many active records in array
			int validCount = 0;
			for (int i = 0; i < array.Length; i++) {
				if (array[i] != "" && array[i] != null) {
					validCount+=2;;
				} //end if
			} //end for

			return validCount;
		}

		//add entry to first empty slot in arrays
		//for CREATE
		static string[] CreateNewEntryInArray(string[] array, string newEntry) {
			//initialize variable
			bool created = false; 
			for (int i = 0; i < array.Length; i++) {
				if ((array[i] == null || array[i] == "") && created == false) {
					array[i] = newEntry;
					created = true;
				} //end if
			} //end for
			
			return array;
		}

		//ask user for rating and validate
		//for CREATE and UPDATE
		static string askValidateRating(string question) {

			//initialize variables
			string newRating;
			int validate = 0;
			bool firstPass = true;

			//ask user for rating, and validate that input is within range
			do {
				//print 'oops' statement if not first runthru
				if (firstPass == false) {
					Console.WriteLine("Woops, wrong input.");
				}
				firstPass = false;

				//get user input and validate
				Console.WriteLine(question);
				newRating = Console.ReadLine();
				validate = ValidateInput(newRating, 0, 5);
			} while (validate != 1) ; //end do/while

			return newRating;
		}

		//combine two arrays into a single array
		//for SAVE
		static string[] CombineTwoIntoOneArray(string[] arr1, string[] arr2) {
			//initialize variables
			string[] tempArray = new string[((arr1.Length)*2)];
			int j = 0;
			int k = 0;

			//combine two arrays together
			for (int i = 0; i < tempArray.Length; i++) {
				//if even index, populate element with restaurant
				if (i % 2 == 0) {
					tempArray[i] = arr1[j];
					j++;
				}

				//if odd index, populate element with rating
				else if (i % 2 == 1) {
					tempArray[i] = arr2[k];
					k++;
				} //end if/else
			} //end for

			return tempArray;
		}

		//validate restaurant
		//for UPDATE
		static bool validateEntryForUpdate(string[] arr, string userInput) {
			//initialize variables
			bool matches = false;

			//loop through array, trying to find a match
			for (int i = 0; i < arr.Length; i++) {
				if (arr[i] == userInput) {
					matches = true;
					return matches;
				} //end if
			} //end for
			
			return matches;
		}


		
		//update rating
		//for UPDATE
		static string[] updateRating(string[] arr1, string[] arr2, string userIndex, string updatedInput) {
			//initialize variable
			int tempIndex = 0;
			
			//loop through arr1 and tag the index specified by user
			for (int i = 0; i < arr1.Length; i++) {
				if (arr1[i] == userIndex) {
					tempIndex = i;
					break;
				} //end if
			} //end for

			//update arr2
			arr2[tempIndex] = updatedInput;

			return arr2;
		}

		static void Main(string[] args)
    {
			//declare variables
			bool userChoice;
			string userChoiceString;
			int arrLength = 25;
			string fileName = "books.txt";
			
			//create arrays; fill contents with correct object types
			Book[] books = new Book[arrLength];
			MovieTV[] movies = new MovieTV[arrLength];

			for (int i = 0; i < books.Length; i++) {
				books[i] = new Book();
			};

			for (int i = 0; i < movies.Length; i++) {
				movies[i] = new MovieTV();
			};

			Console.WriteLine($"{books[3]} {movies[6]}");

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
					Console.WriteLine("CREATE NEW RESTAURANT AND RATING");

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

				//Q - QUIT - COMPLETE
				else {
					Console.WriteLine("QUIT PROGRAM");
					Console.WriteLine("~~~Adios Say??nara Goodbye Chao Mae Alsalama~~~");
				} //end if/else

			} while (!(userChoiceString == "Q")) ; //end outer do
    } //end main
  } //end class
} //end namespace
*/