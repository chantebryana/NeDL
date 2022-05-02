using System;

namespace CustomerMemberships
{
	class Corporate: Membership
  {
		//properties
		//there are no new ones

		//default constructor
		public Corporate(): base() {}

		//override constructor
		public Corporate(int newId, string newEmail, string newType, double newCost, double newTotal): base(newId, newEmail, newType, newCost, newTotal) {}
		
		//cashback
		//corporate membership has a flat percent (10%) for cash-back rewards
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