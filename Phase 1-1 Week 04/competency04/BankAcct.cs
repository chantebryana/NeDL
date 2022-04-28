using System;

namespace bankAcctActions
{
	abstract class BankAcct
  {
		//properties
		public int AcctId
		{ get; set; }

		public string AcctType
		{ get; set; }

		public double AcctBalance
		{ get; set; }

		//default constructor
		public BankAcct() {
			AcctId = -1;
			AcctType = "";
			AcctBalance = 0D;
		}

		//override constructor
		public BankAcct(int newId, string newType, double newBalance) {
			AcctId = newId;
			AcctType = newType;
			AcctBalance = newBalance;
		}

		//deposit method: same logic for all types of accounts
		//if depositAmount > 0, add to currentBalance; return currentBalance
		public virtual double Deposit(double depositAmount) {
			if (depositAmount > 0) {
				AcctBalance = AcctBalance + depositAmount;
			} 
			return AcctBalance;
		}

		//abstract withdrawal method
		//override in derived class
		//different logic depending on which acct type
		public abstract double Withdrawal(double withdrawalAmount);

		//override ToString to write to console
		public override string ToString() {
			return $"\nAccount Id: {AcctId}\nAccount Type: {AcctType}\nCurrent Balance: ${AcctBalance}";
		}

  } //end class
} //end namespace