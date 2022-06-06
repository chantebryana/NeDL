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
			bool successful = false;
			if ((AcctBalance * 0.50) > withdrawalAmount && withdrawalAmount > 0) {
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


		//override tostring to write to console
		public override string ToString() {
			return base.ToString() + $"\nAnnual Fee: ${AnnualFee}";
		}

  } //end class
} //end namespace