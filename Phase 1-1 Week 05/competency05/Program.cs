using System;
using System.Collections.Generic; //needed for lists

namespace CustomerMemberships
{
	class Program
  {
    //print option menu and return user input
		//FOR TOP OF MAIN
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
		//for CREATE and UPDATE
		static int askForUniqueMemberId(string question, List<Membership> membList, bool trueOrFalse) {
			bool firstPass = true; 
			int memberId;
			bool validate = false;

			do {
				//print 'oops' statement if not first runthru
				if (firstPass == false) {
					Console.WriteLine("Oops! Incorrect User input. Try again.");
				}
				firstPass = false;

				//get user input and validate
				Console.WriteLine(question);
				memberId = Convert.ToInt32(Console.ReadLine());
				validate = ValidateInput(memberId, membList);
			} while (validate != trueOrFalse); //end do/while

			return memberId;
		}

		//validate unique member id
		//FOR askForUniqueMemberId
    static bool ValidateInput(int memberId, List<Membership> membList) {
			//initalize variable (0 = false; 1 = true)
			bool isMembIdUnique = true;

			foreach(Membership aMembership in membList) {
				if (memberId == aMembership.MembershipId) {
					isMembIdUnique = false;
				}
			} //end foreach

			return isMembIdUnique;
    }

		//validate user input (lo and hi)
    static bool ValidateInput(double userInput, int low, int high = int.MaxValue) {
				//if incorrect   
        if (userInput <= low || userInput > high) {
						return false;
        } 
        //if correct
        else {
            return true;
        }
    }

		static double askForValidMoneyAmount(string question, int low) {
			bool firstPass = true; 
			double moneyAmount;
			bool validate = false;

			do {
				//print 'oops' statement if not first runthru
				if (firstPass == false) {
					Console.WriteLine("Oops! Incorrect User input. Try again.");
				}
				firstPass = false;

				//get user input and validate
				Console.WriteLine(question);
				moneyAmount = Convert.ToDouble(Console.ReadLine());
				validate = ValidateInput(moneyAmount, low);
			} while (validate != true); //end do/while

			return moneyAmount;
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
			//to be used when applying cashback
			double regularPercent = 5;
			double executivePercent = 3.5;
			double nonProfitPercent = 6;
			double corporatePercent = 10;
			
			//create list of memberships
			List<Membership> memberships = new List<Membership>();

			//add a series of hard-coded membership types
			memberships.Add(new Regular(1, "email@domain.com", "Regular", 99.99, 500.00));
			memberships.Add(new Executive(2, "email2@domain.com", "Executive", 200.00, 999.00));
			memberships.Add(new NonProfit(3, "email3@domain.com", "NonProfit", 50.00, 250.00));
			memberships.Add(new Corporate(4, "email4@domain.com", "Corporate", 274.95, 25000.00));
			memberships.Add(new Regular(5, "email5@domain.com", "Regular", 99.99, 675.00));
			memberships.Add(new Executive(6, "email6@domain.com", "Executive", 200.00, 1059.55));
			memberships.Add(new NonProfit(7, "email7@domain.com", "NonProfit", 50.00, 2097.00));
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
				//C - CREATE - MVP DONE
				if (userChoiceString == "C") {
					Console.WriteLine("CREATE NEW MEMBERSHIP");

					//ask for unique member id; keep asking till user enters unique int
					string idQuestion = "Enter unique Member ID:";
					int memberId = askForUniqueMemberId(idQuestion, memberships, true);

					Console.WriteLine("Enter email address:");
					string email = Console.ReadLine();

					Console.WriteLine("Enter membership type (R, E, NP, C):");
					string memberType = (Console.ReadLine()).ToUpper();

					Console.WriteLine("Enter annual cost:");
					double cost = Convert.ToDouble(Console.ReadLine());

					Console.WriteLine("Enter this month's running purchase total:");
					double monthlyPurcase = Convert.ToDouble(Console.ReadLine());

					switch (memberType) {
						case "R": 
							//add user info to list
							memberships.Add(new Regular(memberId, email, "Regular", cost, monthlyPurcase));
							break;
						case "E": 
							//do a thing
							//add user info to list
							memberships.Add(new Executive(memberId, email, "Executive", cost, monthlyPurcase));
							break;
						case "NP": 
							//add user info to list
							memberships.Add(new NonProfit(memberId, email, "NonProfit", cost, monthlyPurcase));
							break;
						case "C": 
							//add user info to list
							memberships.Add(new Corporate (memberId, email, "Corporate", cost, monthlyPurcase));
							break;
						default: 
							//error message (CE bad place for validation; consider bumping higher)
							Console.WriteLine("Oops! Incorrect member type. No new entry added.");
							break;
					} //end switch

					Console.WriteLine($"Member {memberId} successfully created.");

				}

				//R - READ/PRINT - DONE
				else if (userChoiceString == "R") {
					Console.WriteLine("READ LIST");

					foreach(Membership aMembership in memberships) {
						Console.WriteLine(aMembership);
					}
				}

				//U - UPDATE - MVP DONE
				else if (userChoiceString == "U") {
					Console.WriteLine("UPDATE MEMBERSHIP");

					//find existing member id
					string updateQuestion = "Enter existing Membership ID to update:";
					int memberId = askForUniqueMemberId(updateQuestion, memberships, false);

					Console.WriteLine("Update email address");
					string newEmail = Console.ReadLine();

					foreach(Membership aMember in memberships) {
						if (aMember.MembershipId == memberId) {
							aMember.Email = newEmail;
						}
					}

					Console.WriteLine($"Member {memberId} successfully updated.");

				}

				//D - DELETE - MVP DONE
				else if (userChoiceString == "D") {
					Console.WriteLine("DELETE MEMBERSHIP");

					//find existing member id; keep asking till user enters existing id
					string updateQuestion = "Enter existing Membership ID to delete:";
					int memberId = askForUniqueMemberId(updateQuestion, memberships, false);

					//are you sure?
					Console.WriteLine($"Confirm (Y / N)");
					string confirmation = (Console.ReadLine()).ToUpper();

					bool removed = false;

					if (confirmation == "Y") {
						//remove from list
						for (int i = 0; i < memberships.Count; i++) {
							if (memberships[i].MembershipId == memberId) {
								memberships.RemoveAt(i);
								removed = true;
							}
						}
					}

					//report results to user
					if (removed == true) {
						Console.WriteLine($"Member {memberId} successfully deleted.");
					} else {
						Console.WriteLine("Deletion aborted.");
					}

				}

				//L - LIST - DONE
				else if (userChoiceString == "L") {
					Console.WriteLine("LIST ALL MEMBERSHIPS");

					foreach(Membership aMembership in memberships) {
						Console.WriteLine(aMembership);
					}
				}

				//P - PURCHASE - MVP DONE
				else if (userChoiceString == "P") {
					Console.WriteLine("BUY BUY BUY CONSUME!");

					//find existing member id
					string purchaseQuestion = "Enter existing Membership ID to apply a purchase to:";
					int memberId = askForUniqueMemberId(purchaseQuestion, memberships, false);

					//enter purchase amount; must be greater than $0.00
					int low = 0;
					string moneyQuestion = $"Enter purchase amount: (> ${low}.00)";
					double purchaseAmount = askForValidMoneyAmount(moneyQuestion, low);

					foreach(Membership aMember in memberships) {
						if (aMember.MembershipId == memberId) {
							aMember.MonthlyPurchaseTotal += purchaseAmount;
						}
					}

					Console.WriteLine($"Purchase amount of ${purchaseAmount} successfully applied to Member {memberId}.");

				}

				//T - RETURN - MVP DONE
				else if (userChoiceString == "T") {
					Console.WriteLine("MAKE A RETURN");

					//find existing member id
					string returnQuestion = "Enter existing Membership ID to apply a refund to:";
					int memberId = askForUniqueMemberId(returnQuestion, memberships, false);

					//enter refund amount; must be greater than $0.00
					int low = 0;
					string moneyQuestion = $"Enter refund amount: (> ${low}.00)";
					double refundAmount = askForValidMoneyAmount(moneyQuestion, low);

					foreach(Membership aMember in memberships) {
						if (aMember.MembershipId == memberId) {
							aMember.MonthlyPurchaseTotal = aMember.MonthlyPurchaseTotal - refundAmount;
						}
					}

					Console.WriteLine($"Refund amount of ${refundAmount} successfully applied to Member {memberId}.");

				}

				//A - APPLY CASHBACK REWARDS
				else if (userChoiceString == "A") {
					Console.WriteLine("APPLY CASHBACK REWARDS");

					//find existing member id
					string cashBackQuestion = "Enter existing Membership ID to apply cashback rewards to:";
					int memberId = askForUniqueMemberId(cashBackQuestion, memberships, false);

					//look up member based on id, then apply cashback logic based on which member type
					foreach(Membership aMembership in memberships) {
						if (aMembership.MembershipId == memberId) {
							switch (aMembership.MembershipType) {
								case "Regular": 
									//use Regular logic to apply cash back and set monthly purchase total to $0.00
									aMembership.MonthlyPurchaseTotal = aMembership.ApplyCashbackReward(regularPercent);
									break;
								case "Executive": 
									//use Executive logic to apply cash back and set monthly purchase total to $0.00
									aMembership.MonthlyPurchaseTotal = aMembership.ApplyCashbackReward(executivePercent);
									break;
								case "NonProfit": 
									//CE ASK MORE QUESTIONS
									Console.WriteLine("Is your NonProfit Military or Education? (Y / N)");
									string milOrEd = (Console.ReadLine()).ToUpper();

									//if nonprofit is military or education, extra percent logic
									if (milOrEd == "Y") {
										double doublePercent = nonProfitPercent * 2;

										//use Nonprofit double logic to apply cash back and set monthly purchase total to $0.00
										aMembership.MonthlyPurchaseTotal = aMembership.ApplyCashbackReward(doublePercent);
										break;
									} else {
										//use Nonprofit logic to apply cash back and set monthly purchase total to $0.00
										aMembership.MonthlyPurchaseTotal = aMembership.ApplyCashbackReward(nonProfitPercent);
										break;
									}
								case "Corporate": 
									//use Corporate logic to apply cash back and set monthly purchase total to $0.00
									aMembership.MonthlyPurchaseTotal = aMembership.ApplyCashbackReward(corporatePercent);
									break;
								default: 
									//error message (CE it would be a crazy fluke if this default state were ever hit)
									Console.WriteLine("Oops! Something bad happened. No cash back applied.");
									break;
							} //end switch

						} //end if
					} //end foreach

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