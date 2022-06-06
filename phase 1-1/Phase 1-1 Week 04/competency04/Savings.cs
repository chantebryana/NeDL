using System;

namespace bankAcctActions
{
	class Savings : BankAcct, ICalculateAnnualInterest
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
			bool successful = false;
			if (AcctBalance > withdrawalAmount && withdrawalAmount > 0) {
				double oldAcctBalance = AcctBalance;
				AcctBalance = AcctBalance - withdrawalAmount;
				successful = true;

			//tell user
				Console.WriteLine($"   Account Balance ${oldAcctBalance}\n   - Withdrawal Amount ${withdrawalAmount}\n   = ${AcctBalance}");
			}

			//if user's w/d amount doesn't conform to logic above, tell them so
			if (successful == false) {
				Console.WriteLine("Oops! Incorrect withdrawal amount. Nothing withdrawn from account.");
			}
			return AcctBalance;
		}

		//calculate annual interest
		//inherit from interface
		//report to user via tostring override
		public double CalculateAnnualInterest() {
			return AcctBalance * (AnnualInterestRate / 100);
		}


		//override tostring to write to console
		public override string ToString() {
			//convert double into string, rounded to two decimal places
			string annualInterestTwoDecimal = CalculateAnnualInterest().ToString("#.##");
			
			//pretty print
			return base.ToString() + $"\nAnnual Interst Rate: {AnnualInterestRate}%\nAmount Earned from Interest after One Year: ${annualInterestTwoDecimal}";
		}

  } //end class
} //end namespace