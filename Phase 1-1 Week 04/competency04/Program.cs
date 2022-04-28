using System;
using System.Collections.Generic; //needed for lists

namespace bankAcctActions
{
	class Program
  {
    static void Main(string[] args)
    {
			//create list of bank accounts
			List<BankAcct> bankAccounts = new List<BankAcct>();

			bankAccounts.Add(new Savings(1000, "Savings", 1000.00, 5.5));
			bankAccounts.Add(new Checking(2001, "Checking", 500.00, 0.67));
			bankAccounts.Add(new Checking(2002, "Checking", 75.00, 1.59));
			bankAccounts.Add(new CD(3001, "CD", 5000.00, 2.0, 25.00));
			bankAccounts.Add(new CD(3002, "CD", 7500.50, 2.0, 49.00));
			
			foreach(BankAcct anAcct in bankAccounts) {
				Console.WriteLine(anAcct);
			}

			//
			//DEPOSIT
			//
			int acctNumber = 1000;
			foreach(BankAcct anAcct in bankAccounts) {
				if (anAcct.AcctId == acctNumber) {
					anAcct.AcctBalance = anAcct.Deposit(500.00);
				}
			}

			Console.WriteLine("\nDEPOSIT");
			foreach(BankAcct anAcct in bankAccounts) {
				Console.WriteLine(anAcct);
			}

			//
			//WITHDRAWAL
			//
			acctNumber = 3002;
			foreach(BankAcct anAcct in bankAccounts) {
				if (anAcct.AcctId == acctNumber) {
					anAcct.AcctBalance = anAcct.Withdrawal(7452.00);
				}
			}

			Console.WriteLine("\nWITHDRAWAL");
			foreach(BankAcct anAcct in bankAccounts) {
				Console.WriteLine(anAcct);
			}

    } //end main
  } //end class
} //end namespace