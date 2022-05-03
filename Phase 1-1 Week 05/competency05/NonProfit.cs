using System;

namespace CustomerMemberships
{
	class NonProfit: Membership
  {
		//properties
		//there are no new ones

		//default constructor
		public NonProfit(): base() {}

		//override constructor
		public NonProfit(int newId, string newEmail, string newType, double newCost, double newTotal): base(newId, newEmail, newType, newCost, newTotal) {}
		
		//cashback
		//non-profit membership has a cash-back percentage (6%) and also a field to indicate if it is a military or educational organization and if so doubles the cash-back percentage
		//once applied, zero out monthly purchase total
		public override double ApplyCashbackReward(double percent) {
			if (MonthlyPurchaseTotal > 0) {
				double cashBack = MonthlyPurchaseTotal * (percent / 100);
				string cashBackTwoDecimal = cashBack.ToString("#.##");
				Console.WriteLine($"\nSuccess! {percent}% of ${MonthlyPurchaseTotal} gives you a Cash-Back Reward of ${cashBackTwoDecimal} applied to Membership {MembershipId}.");

				//set monthly purchase total to $0.00
				MonthlyPurchaseTotal = 0D;
			}
			//if monthlypuchasetotal == 0 (ex: if cashback already applied)
			else {
				Console.WriteLine($"Member {MembershipId}'s Monthly Purchase Total is $0.00. Cannot apply Cash Back Bonus. Buy more stuff!");
			}

			return MonthlyPurchaseTotal;
		}

		//tostring
		public override string ToString() {
			return base.ToString();
		}

  } //end class
} //end namespace