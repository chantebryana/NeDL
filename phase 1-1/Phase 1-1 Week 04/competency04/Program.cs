using System;
using System.Collections.Generic; //needed for lists

namespace bankAcctActions
{
	class Program
  {
		//print option menu and return user input
		static string askUserMenuOptions () {
			//print menu options
			Console.WriteLine("");
			Console.WriteLine("Select a Menu Option:");
			Console.WriteLine("   L: List all accounts.");
			Console.WriteLine("   D: Perform Deposit transaction.");
			Console.WriteLine("   W: Perform Withdrawal transaction.");
			Console.WriteLine("   Q: Quit the program.");

			//return user input, converted to upper-case
			return Console.ReadLine().ToUpper();
		}
    static void Main(string[] args)
    {
			//create list of bank accounts
			List<BankAcct> bankAccounts = new List<BankAcct>();

			//add series of hard-coded savings, checking, and cd accounts
			bankAccounts.Add(new Savings(1000, "Savings", 1000.00, 5.5));
			bankAccounts.Add(new Savings(1001, "Savings", 95000.00, 3.95));
			bankAccounts.Add(new Checking(2001, "Checking", 500.00, 0.67));
			bankAccounts.Add(new Checking(2002, "Checking", 75.00, 1.59));
			bankAccounts.Add(new CD(3001, "CD", 5000.00, 2.0, 25.00));
			bankAccounts.Add(new CD(3002, "CD", 7500.50, 2.0, 49.00));

			//declare variables for later
			bool userChoice;
			string userChoiceString;
			
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
					userChoice = (userChoiceString == "L" || 
												userChoiceString == "D" || 
												userChoiceString == "W" || 
												userChoiceString == "Q"
					);
					//if user enters invalid choice, repeat till correct
					if (!userChoice) {
						Console.WriteLine("Oops! Please enter a valid menu option");
					}
				} while (!userChoice) ; //end inner do

				//logic for individual user choices
				//L - LIST ALL ACCTS
				if (userChoiceString == "L") {
					Console.WriteLine("LIST ACCOUNTS");

					foreach(BankAcct anAcct in bankAccounts) {
						Console.WriteLine(anAcct);
					}
				}

				//D - DEPOSIT
				else if (userChoiceString == "D") {
					Console.WriteLine("DEPOSIT");

					//initialize variable for later
					bool foundAcctId = false;

					//get acct id from user
					Console.WriteLine("Enter Account Number you want to deposit into:");
					int acctNumber = Convert.ToInt16(Console.ReadLine());

					//loop through list. if acct is found, then perform deposit
					foreach(BankAcct anAcct in bankAccounts) {
						if (anAcct.AcctId == acctNumber) {
							//if found acct id, as for deposit amount
							Console.WriteLine("Enter Deposit amount:");
							double newDeposit = Convert.ToDouble(Console.ReadLine());

							//then perform deposit
							anAcct.AcctBalance = anAcct.Deposit(newDeposit);
							foundAcctId = true;
						} 
					}

					//if couldn't find acct id, tell user so: 
					if (foundAcctId == false) {
						Console.WriteLine("Oops! Invalid Account Id. No deposit made.");
					}

				}

				//W - WITHDRAWAL
				else if (userChoiceString == "W") {
					Console.WriteLine("WITHDRAWAL");

					//initialize variable for later
					bool foundAcctId = false;

					//get acct id from user
					Console.WriteLine("Enter Account Number you want to withdrawal from:");
					int acctNumber = Convert.ToInt32(Console.ReadLine());

					//loop through list. if acct is found, then perform withdrawal
					foreach(BankAcct anAcct in bankAccounts) {
						if (anAcct.AcctId == acctNumber) {
							//if found acct id, ask for withdrawal amount
							Console.WriteLine("Enter Withdrawal amount:");
							double newWd = Convert.ToDouble(Console.ReadLine());

							//then perform deposit
							anAcct.AcctBalance = anAcct.Withdrawal(newWd);
							foundAcctId = true;
						} 
					}

					//if couldn't find acct id, tell user so: 
					if (foundAcctId == false) {
						Console.WriteLine("Oops! Invalid Account Id. No withdrawal made.");
					}
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