using System;

namespace bankAcctActions
{
	class Savings : BankAcct
  {
		//property
		public double AnnualInterestRate
		{ get; set; }

		//default constructor
		public Savings(): base() {
			AnnualInterestRate = 0D;
		}

		//override constructor
		public Savings(int newId, string newType, double newBalance, double newInterestRate): base(newId, newType, newBalance) {
			AnnualInterestRate = newInterestRate;
		}

		//methods n such
		//withdrawal
		//if savings acct balance > withdrawal amount AND if withdrawal amount > 0
		//then subtract withdrawal amount and return updated account balance
		public override double Withdrawal(double withdrawalAmount) {
			if (AcctBalance > withdrawalAmount && withdrawalAmount > 0) {
				AcctBalance = AcctBalance - withdrawalAmount;
			}
			return AcctBalance;
		}


		//override tostring to write to console
		public override string ToString() {
			return base.ToString() + $"\nAnnual Interst Rate: {AnnualInterestRate}%";
		}

  } //end class
} //end namespace