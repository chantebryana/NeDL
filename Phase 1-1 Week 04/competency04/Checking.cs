using System;

namespace bankAcctActions
{
	class Checking : BankAcct
  {
		//property
		public double AnnualFee
		{ get; set; }

		//default constructor
		public Checking(): base() {
			AnnualFee = 0D;
		}

		//override constructor
		public Checking(int newId, string newType, double newBalance, double newFee): base(newId, newType, newBalance) {
			AnnualFee = newFee;
		}

		//methods n such
		//withdrawal
		//if withdrawal amount is less than 50% of checking account balance AND if withdrawal amount > 0
		//then subtract withdrawal amount and return updated account balance
		public override double Withdrawal(double withdrawalAmount) {
			if ((AcctBalance * 0.50) > withdrawalAmount && withdrawalAmount > 0) {
				AcctBalance = AcctBalance - withdrawalAmount;
			}
			return AcctBalance;
		}


		//override tostring to write to console
		public override string ToString() {
			return base.ToString() + $"\nAnnual Fee: ${AnnualFee}";
		}

  } //end class
} //end namespace