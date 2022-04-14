using System;
using System.IO;
using System.Globalization;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
			//declare variable
			bool userChoice;
			string userChoiceString;
			int fileMax = 10;
			string fileName = "names.txt";
			string[] nameArray = new string[fileMax];
			
			//repeat main loop till user quits
			do {
				//get valid input
				do {
					//initialize variables
					userChoice = false;
					
					//provide the user a menu of options
					Console.WriteLine("");
					Console.WriteLine("Select a Menu Option:");
					Console.WriteLine("   L: Load the data file into an array.");
					Console.WriteLine("   S: Store the array into the data file.");
					Console.WriteLine("   C: Add the array into the data file.");
					Console.WriteLine("   R: Read a name from the array (if it's there).");
					Console.WriteLine("   U: Update a name in the array (if it's there).");
					Console.WriteLine("   D: Delete a name from the array (if it's there).");
					Console.WriteLine("   Q: Quit the program.");


					//get a valid user option (validation)
					//string userChoiceString = (Console.ReadLine()).ToLower();
					userChoiceString = Console.ReadLine();

					userChoice = (userChoiceString == "L" || userChoiceString == "l" ||
												userChoiceString == "S" || userChoiceString == "s" ||
												userChoiceString == "C" || userChoiceString == "c" ||
												userChoiceString == "R" || userChoiceString == "r" ||
												userChoiceString == "U" || userChoiceString == "u" ||
												userChoiceString == "D" || userChoiceString == "d" ||
												userChoiceString == "Q" || userChoiceString == "q"
					);

					if (!userChoice) {
						Console.WriteLine("Oops! Please enter a valid menu option");
					}
				} while (!userChoice) ; //end second do

				//if the option is 'L' or 'l', then load the txt file (names.txt) into the array of strings (nameArray)
				if (userChoiceString == "L" || userChoiceString == "l") {
					//read file, and push contents of each line into array element
					using (StreamReader sr = File.OpenText(fileName)) {
						//initialize variables
						int i = 0;
						string s;
						//while line of file I'm reading has content (aka isn't null)
						//push line contents to element of array
						while ((s = sr.ReadLine()) != null) {
							nameArray[i] = s;
							i++;
						} //end while loop
					} //end using
				}

				//else if the option is 'S' or 's', then store the array into the txt file
				else if (userChoiceString == "S" || userChoiceString == "s") {
					//save contents of array to file
					//each element of array gets new line in file
					File.WriteAllLines(fileName, nameArray);
				}

				//else if the option is 'C' or 'c', then add a name to the array if there's room (eg: array of 20) (also note: user will also have to save manually)
				else if (userChoiceString == "C" || userChoiceString == "c") {
					
					//check to see whether or not array is full
					int validCount = 0;
					for (int i = 0; i < nameArray.Length; i++) {
						if (nameArray[i] != "" && nameArray[i] != null) {
							validCount++;
						} //end if
					} //end for
					
					//if array is full, tell user they can't create new name
					if (validCount >= fileMax) {
						Console.WriteLine($"Names file is already at its max of {validCount}. Delete a name before adding a new one.");
					} 
					//else if array has space, let user create new
					else {
						Console.WriteLine("Enter a new name");
						TextInfo tiVar1 = new CultureInfo("en-US", false).TextInfo;
						string nameToAdd = tiVar1.ToTitleCase(Console.ReadLine());

						//add name to first empty slot
						bool created = false;
						for (int i = 0; i < nameArray.Length; i++) {
							if ((nameArray[i] == null || nameArray[i] == "") && created == false) {
								nameArray[i] = nameToAdd;
								created = true;
							}//end if
						} //end for loop
					} //end if else
				}

				//else if the option is 'R' or 'r', then print the array (if it's there)
				else if (userChoiceString == "R" || userChoiceString == "r") {
					for (int i = 0; i < nameArray.Length; i++) {
						Console.WriteLine(nameArray[i]);
					} //end for loop
				}

				//else if the option is 'U' or 'u', then update a name in the array (if it's there)
				else if (userChoiceString == "U" || userChoiceString == "u") {
					//request updates from user (and clean up strings to Title Case)
					Console.WriteLine("Which name do you want to update?");
					TextInfo tiVar1 = new CultureInfo("en-US", false).TextInfo;
					TextInfo tiVar2 = new CultureInfo("en-US", false).TextInfo;
					string nameToEdit = tiVar1.ToTitleCase(Console.ReadLine());
					Console.WriteLine("Enter your update.");
					string updatedName = tiVar2.ToTitleCase(Console.ReadLine());

					//if name is in array, then update each one
					for (int i = 0; i < nameArray.Length; i++) {
						if (nameArray[i] == nameToEdit) {
							nameArray[i] = updatedName;
						} //end if
					} //end for
				}

				//else if the option is 'D' or 'd', then delete a name from the array (if it's there)
				else if (userChoiceString == "D" || userChoiceString == "d") {
					//ask user which name to delete
					Console.WriteLine("Which name to delete?");
					TextInfo tiVar1 = new CultureInfo("en-US", false).TextInfo;
					string nameToDelete = tiVar1.ToTitleCase(Console.ReadLine());

					//if name is in array, then delete each one
					nameArray = nameArray.Where(element => element != nameToDelete).ToArray();
				}

				//else if the option is 'Q' or 'q', then quit the program
				else {
					Console.WriteLine("~~~Adios Sayōnara Goodbye Chao Mae Alsalama~~~");
				} //end if/else
			} while (!(userChoiceString == "Q") && !(userChoiceString == "q")) ; //end first do
    } //end main
  } //end program
} //end namespace