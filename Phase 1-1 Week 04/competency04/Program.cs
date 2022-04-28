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

			bankAccounts.Add(new BankAcct(1000, "Savings", 1000.00));
			
			foreach(BankAcct anAcct in bankAccounts) {
				Console.WriteLine(anAcct);
			}

			foreach(BankAcct anAcct in bankAccounts) {
				anAcct.AcctBalance = anAcct.Deposit(500.00);
			}

			foreach(BankAcct anAcct in bankAccounts) {
				Console.WriteLine(anAcct);
			}

    } //end main
  } //end class
} //end namespace