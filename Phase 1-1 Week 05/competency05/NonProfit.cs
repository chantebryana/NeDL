using System;

namespace CustomerMemberships
{
	class NonProfit: Membership
  {
		//properties
		public double CashBackPercent
		{ get; set; }

		//default constructor
		public NonProfit(): base() {}

		//override constructor
		public NonProfit(int newId, string newEmail, string newType, double newCost, double newTotal, double newPercent): base(newId, newEmail, newType, newCost, newTotal) {
			CashBackPercent = newPercent;
		}
		
		//cashback
		//non-profit membership has a cash-back percentage (6%) and also a field to indicate if it is a military or educational organization and if so doubles the cash-back percentage
		//once applied, zero out monthly purchase total
		public override double ApplyCashbackReward() {
			//if monthlypuchasetotal == 0 (ex: if cashback already applied)
			if (MonthlyPurchaseTotal == 0) {
				Console.WriteLine($"Member {MembershipId}'s Monthly Purchase Total is $0.00. Cannot apply Cash Back Bonus. Buy more stuff!");
			}
			else if (MonthlyPurchaseTotal > 0) {
				//initialize variable for later
				double cashBack = 0D;
				
				//military or education? if so, extra cashback
				Console.WriteLine("Is your nonprofit Military or Education? Y / N");
				string milOrEd = (Console.ReadLine()).ToUpper();

				if (milOrEd == "Y") {
					cashBack = MonthlyPurchaseTotal * (CashBackPercent / 100);
				} else {
					cashBack = MonthlyPurchaseTotal * (CashBackPercent * 2 / 100);
				}
				
				//report to user
				string cashBackTwoDecimal = cashBack.ToString("#.##");
				Console.WriteLine($"\nSuccess! {CashBackPercent}% of ${MonthlyPurchaseTotal} gives you a Cash-Back Reward of ${cashBackTwoDecimal} applied to Membership {MembershipId}.");

				//set monthly purchase total to $0.00
				MonthlyPurchaseTotal = 0D;
			}
			

			return MonthlyPurchaseTotal;
		}

		//tostring
		public override string ToString() {
			return base.ToString();
		}

  } //end class
} //end namespace