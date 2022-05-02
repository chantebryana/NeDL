using System;
using System.Collections.Generic; //needed for lists

namespace CustomerMemberships
{
	class Program
  {
    //print option menu and return user input
		static string askUserMenuOptions () {
			//print menu options
			Console.WriteLine("");
			Console.WriteLine("Select a Menu Option:");
			Console.WriteLine("   C: Add a new membership.");
			Console.WriteLine("   R: Read and print a list of all memberships.");
			Console.WriteLine("   U: Update a memberhip.");
			Console.WriteLine("   D: Delete a membership.");
			Console.WriteLine("   L: List all the memberships");
			Console.WriteLine("   P: Make a purchase.");
			Console.WriteLine("   T: reTurn an item.");
			Console.WriteLine("   A: Apply cashback rewards.");
			Console.WriteLine("   Q: Quit the program.");

			//return user input, converted to upper-case
			return Console.ReadLine().ToUpper();
		}
		
		//ask member id; make sure it's unique
		//for CREATE
		static int askForUniqueMemberId(string question, List<Membership> membList) {
			bool firstPass = true; 
			int memberId;
			int validate = 0;

			do {
				//print 'oops' statement if not first runthru
				if (firstPass == false) {
					Console.WriteLine("Oops! That Member ID isn't unique. Try again.");
				}
				firstPass = false;

				//get user input and validate
				Console.WriteLine(question);
				memberId = Convert.ToInt32(Console.ReadLine());
				validate = ValidateInput(memberId, membList);
			} while (validate != 1); //end do/while

			return memberId;
		}

		//validate unique member id
    static int ValidateInput(int memberId, List<Membership> membList) {
			//initalize variable (0 = false; 1 = true)
			int isMembIdUnique = 1;

			foreach(Membership aMembership in membList) {
				if (memberId == aMembership.MembershipId) {
					isMembIdUnique = 0;
				}
			} //end foreach

			return isMembIdUnique;
    }

		//**********************************************
		//MAIN!!!
		//**********************************************
		static void Main(string[] args)
    {
			//declare and initialize variables
			bool userChoice;
			string userChoiceString;

			//initialize cash back percentages for each different membership type
			double regularPercent = 5;
			double executivePercent = 3.5;
			double nonProfitPercent = 6;
			double corporatePercent = 10;
			
			//create list of memberships
			List<Membership> memberships = new List<Membership>();

			//add a series of hard-coded membership types
			memberships.Add(new Regular(1, "email@domain.com", "Regular", 99.99, 500.00));
			memberships.Add(new Executive(2, "email2@domain.com", "Executive", 200.00, 999.00));
			memberships.Add(new NonProfit(3, "email3@domain.com", "Nonprofit", 50.00, 250.00));
			memberships.Add(new Corporate(4, "email4@domain.com", "Corporate", 274.95, 25000.00));
			memberships.Add(new Regular(5, "email5@domain.com", "Regular", 99.99, 675.00));
			memberships.Add(new Executive(6, "email6@domain.com", "Executive", 200.00, 1059.55));
			memberships.Add(new NonProfit(7, "email7@domain.com", "Nonprofit", 50.00, 2097.00));
			memberships.Add(new Corporate(8, "email8@domain.com", "Corporate", 274.95, 1066.00));

			
			

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
					userChoice = (userChoiceString == "C" || 
												userChoiceString == "R" || 
												userChoiceString == "U" || 
												userChoiceString == "D" || 
												userChoiceString == "L" || 
												userChoiceString == "P" || 
												userChoiceString == "T" || 
												userChoiceString == "A" || 
												userChoiceString == "Q"
					);
					//if user enters invalid choice, repeat till correct
					if (!userChoice) {
						Console.WriteLine("Oops! Please enter a valid menu option");
					}
				} while (!userChoice) ; //end inner do

				//logic for individual user choices
				//C - CREATE
				if (userChoiceString == "C") {
					Console.WriteLine("CREATE NEW MEMBERSHIP");

					Console.WriteLine("");

					string question = "Enter unique Member ID";
					int memberId = askForUniqueMemberId(question, memberships);

				}

				//R - READ/PRINT
				else if (userChoiceString == "R") {
					Console.WriteLine("READ LIST");

					foreach(Membership aMembership in memberships) {
						Console.WriteLine(aMembership);
					}
				}

				//U - UPDATE
				else if (userChoiceString == "U") {
					Console.WriteLine("UPDATE MEMBERSHIP");

				}

				//D - DELETE
				else if (userChoiceString == "D") {
					Console.WriteLine("DELETE MEMBERSHIP");

				}

				//L - LIST
				else if (userChoiceString == "L") {
					Console.WriteLine("LIST ALL MEMBERSHIPS");

					foreach(Membership aMembership in memberships) {
						Console.WriteLine(aMembership);
					}
				}

				//P - PURCHASE
				else if (userChoiceString == "P") {
					Console.WriteLine("MAKE PURCHASE");

				}

				//T - RETURN
				else if (userChoiceString == "T") {
					Console.WriteLine("MAKE A RETURN");

				}

				//A - APPLY CASHBACK REWARDS
				else if (userChoiceString == "A") {
					Console.WriteLine("APPLY CASHBACK REWARDS");

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