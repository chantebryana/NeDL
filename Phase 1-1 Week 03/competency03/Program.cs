using System;
using System.IO;
using System.Globalization;

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
		
		//instantiate individual elements of array to Hourly object
		static Hourly[] setToObject (Hourly[] array) {
			for (int i = 0; i < array.Length; i++) {
				array[i] = new Hourly();
			}
			return array;
		}

		//instantiate individual elements of array to Salary object
		static Salary[] setToObject (Salary[] array) {
			for (int i = 0; i < array.Length; i++) {
				array[i] = new Salary();
			}
			return array;
		}

		//insert hourly-type contents of single string[] array into Hourly[] array
		//for OPEN
		static Hourly[] singleArrayToHourlyArray (Hourly[] hrArr, string[] singleArr) {

			//initialize variable
					int k = 0; //object array needs different tracker from tempArray
					
					//loop through temp array and assign elements to Hourly object array
					for (int j = 0; j < singleArr.Length; j+=4) {
						if (singleArr[(j+2)] == "H") {
							hrArr[k].LastName = singleArr[j];
							hrArr[k].FirstName = singleArr[j+1];
							char tempType = char.Parse(singleArr[j+2]); //convert string to char
							hrArr[k].EmployeeType = tempType; 
							hrArr[k].HourlyRate = Convert.ToInt32(singleArr[j+3]); //convert string to int
							k++; //iterate k by 1
						}
					}
					return hrArr;
		}

		//insert salary-type contents of single string[] array into Salary[] array
		//for OPEN
		static Salary[] singleArrayToSalaryArray (Salary[] sArr, string[] singleArr) {

			//initialize variable
					int k = 0; //object array needs different tracker from tempArray
					
					//loop through temp array and assign elements to Salary object array
					for (int j = 0; j < singleArr.Length; j+=4) {
						if (singleArr[(j+2)] == "S") {
							sArr[k].LastName = singleArr[j];
							sArr[k].FirstName = singleArr[j+1];
							char tempType = char.Parse(singleArr[j+2]); //convert string to char
							sArr[k].EmployeeType = tempType; 
							sArr[k].AnnualSalary = Convert.ToInt32(singleArr[j+3]); //convert string to int
							k++; //iterate k by 1
						}
					}
					return sArr;
		}

		//print contents of each array
		//for READ
		static void printArrays (Hourly[] arr1, Salary[] arr2) {
			//initialize variable for bonus calculations
			double bonus = 0.00;
			string bonusString = "";
			
			//loop through Hourly array; only print elements with info
			for (int i = 0; i < arr1.Length; i++) {
					//stop loop if element is empty
					if (arr1[i].LastName == null) {
						break;
					} else if ( arr1[i].LastName == "") {
						break;
					} //end if/else
					
					//if element has contents, then print them to the console
					Console.WriteLine(arr1[i]);
					bonus = arr1[i].CalculateBonus(arr1[i].HourlyRate);
					bonusString = bonus.ToString("C", CultureInfo.CurrentCulture);
					Console.WriteLine($"    Bonus: {bonusString}");
			} //end for

			//loop through Salary array; only print elements with info
			for (int i = 0; i < arr2.Length; i++) {
					//stop loop if element is empty
					if (arr2[i].LastName == null) {
						break;
					} else if ( arr2[i].LastName == "") {
						break;
					} //end if/else
					
					//if element has contents, then print them to the console
					Console.WriteLine(arr2[i]);
					bonus = arr2[i].CalculateBonus(arr2[i].AnnualSalary);
					bonusString = bonus.ToString("C", CultureInfo.CurrentCulture);
					Console.WriteLine($"    Bonus: {bonusString}");
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

		//validate user input (H or S)
    static int ValidateInput(string userInput) {
				//if correct   
        if (userInput == "H" || userInput == "S") {
						return 1;
        } 
        //if incorrect
        else {
            return 0;
        }
    }

		//ask user which employee type (H or S) they want to create new data for
		//for CREATE
		static string askUserEmployeeType (string question) {
			//initialize variables
			bool firstPass = true;
			string employeeType = "";
			int validate = 0;

			do {
				//print 'oops' statement if not first runthru
				if (firstPass == false) {
					Console.WriteLine("Woops, wrong input.");
				}
				firstPass = false;

				//get user input and validate
				Console.WriteLine(question);
				employeeType = (Console.ReadLine()).ToUpper(); //set to uppercase to standardize user input
				validate = ValidateInput(employeeType);
			} while (validate != 1); //end do/while

			return employeeType;
		}

		//verify whether Hourly array is full
		//for CREATE
		static int IsArrayFull(Hourly[] array) {
			//count how many active records in array
			int validCount = 0;
			for (int i = 0; i < array.Length; i++) {
				if (array[i].LastName != "" && array[i].LastName != null) {
					validCount++;
				} //end if
			} //end for

			return validCount;
		}

		//verify whether Salary array is full
		//for CREATE
		static int IsArrayFull(Salary[] array) {
			//count how many active records in array
			int validCount = 0;
			for (int i = 0; i < array.Length; i++) {
				if (array[i].LastName != "" && array[i].LastName != null) {
					validCount++;
				} //end if
			} //end for

			return validCount;
		}

		//add entry to first empty slot in Hourly array
		//for CREATE
		static Hourly[] CreateNewEntryInArray(Hourly[] array, string lName, string fName, string eType, int hrPay) {
			//initialize variable
			bool created = false; 
			for (int i = 0; i < array.Length; i++) {
				if ((array[i].LastName == null || array[i].LastName == "") && created == false) {
					array[i].LastName = lName;
					array[i].FirstName = fName;
					array[i].EmployeeType = Char.Parse(eType);
					array[i].HourlyRate = hrPay;
					created = true;
				} //end if
			} //end for
			
			return array;
		}

		//add entry to first empty slot in Salary array
		//for CREATE
		static Salary[] CreateNewEntryInArray(Salary[] array, string lName, string fName, string eType, int annualPay) {
			//initialize variable
			bool created = false; 
			for (int i = 0; i < array.Length; i++) {
				if ((array[i].LastName == null || array[i].LastName == "") && created == false) {
					array[i].LastName = lName;
					array[i].FirstName = fName;
					array[i].EmployeeType = Char.Parse(eType);
					array[i].AnnualSalary = annualPay;
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
		static string[] CombineTwoIntoOneArray(Hourly[] arr1, Salary[] arr2) {
			//initialize variables
			string[] tempArray = new string[((arr1.Length)*8)];
			int ii = 0;
			int j = 0;
			int k = 0;
			bool reachEndofArr = false;

			//combine two arrays together
			for (int i = 0; i < tempArray.Length; i+=4) {
				//first, populate elements of temp array with elements of Hourly array
				//end when hourly array has no active records
				do {
					Console.WriteLine("element: " + arr1[i].LastName + "; i =  " + i);
					if (arr1[i].LastName != null || arr1[i].LastName != "") {
						reachEndofArr = true;
					} else {
						ii = i;
						tempArray[ii] = arr1[j].LastName;
						tempArray[ii++] = arr1[j].FirstName;
						tempArray[ii++] = (arr1[j].EmployeeType).ToString();
						tempArray[ii++] = (arr1[j].HourlyRate).ToString();
						j++;
					}
					
				} while (reachEndofArr != true) ;

				//populate remaining elements of temp array with elements of Salary array
				ii = i;
				tempArray[ii] = arr2[k].LastName;
				tempArray[ii++] = arr2[k].FirstName;
				tempArray[ii++] = (arr2[k].EmployeeType).ToString();
				tempArray[ii++] = (arr2[k].AnnualSalary).ToString();
				k++;
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
			//declare and initialize variables
			bool userChoice;
			string userChoiceString;
			int arrLength = 10;
			string fileName = "Employees.txt";
			//Employee[] bonusTable = new Employee[arrLength]; //CE COMMENT OUT
			Hourly[] hourlyBonusTable = new Hourly[arrLength];
			Salary[] salaryBonusTable = new Salary[arrLength];

			//fill elements of arrays with objects of respective types (Hourly or Salary)
			hourlyBonusTable = setToObject(hourlyBonusTable);
			salaryBonusTable = setToObject(salaryBonusTable);

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
				//O - OPEN - COMPLETE
				if (userChoiceString == "O") {
					Console.WriteLine("OPEN FILE");

					//initialize variables
					string[] tempArray = new string[(arrLength * 8)];
					int i = 0;
					string s;

					//read file; push contents into temporary array
					using (StreamReader sr = File.OpenText(fileName)) {
						//if file line isn't empty
						//then push line contents to element of array
						while ((s = sr.ReadLine()) != null) {
							tempArray[i] = s;
							i++;
						} //end while
					} //end using

					//insert hourly-type contents of tempArray into hourlyBonusTable
					hourlyBonusTable = singleArrayToHourlyArray(hourlyBonusTable, tempArray);

					//insert salary-type contents of tempArray into salaryBonusTable
					salaryBonusTable = singleArrayToSalaryArray(salaryBonusTable, tempArray);

					Console.WriteLine("File successfully opened.");
				}

				//S - SAVE
				else if (userChoiceString == "S") {
					Console.WriteLine("SAVE FILE");

					//combine two arrays into a single array 
					string[] tempArray = CombineTwoIntoOneArray(hourlyBonusTable, salaryBonusTable);

					//save contents of array to file
					//each element of array gets new line in file
					File.WriteAllLines(fileName, tempArray);

				}

				//C - CREATE - COMPLETE
				else if (userChoiceString == "C") {
					Console.WriteLine("CREATE NEW ENTRY");

					//ask user which employee type they want to create new data for
					string question = "Hourly ('H') or Salary ('S')?";
					string employeeType = askUserEmployeeType(question);

					//use validCount to check whether array of correct type is full
					int validCount = 0;
					//if hourly
					if (employeeType == "H") {
						validCount = IsArrayFull(hourlyBonusTable);
					} 
					//if salary
					else {
						validCount = IsArrayFull(salaryBonusTable);
					}

					//if array is full, tell user they can't create new entry
					if (validCount >= arrLength) {
						Console.WriteLine($"File contains {validCount} Employee records and is full. Delete an entry before adding a new one.");
					}
					// else if array has space, prompt user for new entry info, then save to arrays
					else {
						Console.WriteLine("Enter Employee's Last Name");
						string lastName = Console.ReadLine();

						Console.WriteLine("Enter Employee's First Name");
						string firstName = Console.ReadLine();

						//different wage questions depending on employee type
						//while i'm in my final loop, also push new user input into correct array
						//if Hourly employee
						if (employeeType == "H") {
							Console.WriteLine("Enter hour pay rate (as a whole number)");
							int hrRate = Convert.ToInt32(Console.ReadLine());

							//PUSH TO ARRAY
							hourlyBonusTable = CreateNewEntryInArray(hourlyBonusTable, lastName, firstName, employeeType, hrRate);
						}
						//else if Salary employee
						else {
							Console.WriteLine("Enter annual salary (as a whole number)");
							int salary = Convert.ToInt32(Console.ReadLine());

							//PUSH TO ARRAY
							salaryBonusTable = CreateNewEntryInArray(salaryBonusTable, lastName, firstName, employeeType, salary);
						}
					} //end if/else
					
				}

				//R - READ/PRINT - COMPLETE
				else if (userChoiceString == "R") {
					Console.WriteLine("READ FILE");

					//print contents of arrays onto console
					printArrays(hourlyBonusTable, salaryBonusTable);

				}

				//U - UPDATE - OPTIONAL
				else if (userChoiceString == "U") {
					Console.WriteLine("UPDATE RATING");

				}

				//D - DELETE - OPTIONAL
				else if (userChoiceString == "D") {
					Console.WriteLine("DELETE RESTAURANT");

				}

				//Q - QUIT - COMPLETE
				else {
					Console.WriteLine("QUIT PROGRAM");
					Console.WriteLine("~~~Adios Sayōnara Goodbye Chao Mae Alsalama~~~");
				} //end if/else

			} while (!(userChoiceString == "Q")) ; //end outer do
    } //end main
  } //end class
} //end namespace