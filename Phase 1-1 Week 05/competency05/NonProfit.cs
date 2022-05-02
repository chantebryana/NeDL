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
			double cashBack = MonthlyPurchaseTotal * (percent / 100);
			string cashBackTwoDecimal = cashBack.ToString("#.##");
			Console.WriteLine($"\nSuccess! {percent}% of ${MonthlyPurchaseTotal} gives you a Cash-Back Reward of ${cashBackTwoDecimal} applied to Membership {MembershipId}.");

			return MonthlyPurchaseTotal = 0D;
		}

		//tostring
		public override string ToString() {
			return base.ToString();
		}

  } //end class
} //end namespace