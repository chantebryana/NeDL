using System;

namespace CustomerMemberships
{
	class Executive: Membership, ISpecialOffer
  {
		//properties
		//there are no new ones

		//default constructor
		public Executive(): base() {}

		//override constructor
		public Executive(int newId, string newEmail, string newType, double newCost, double newTotal): base(newId, newEmail, newType, newCost, newTotal) {}
		
		//cashback
		//executive membership has percentages for two tiers (one below $1000 [3.5%] and one above [7%]) of cash-back rewards
		//once applied, zero out monthly purchase total
		public override double ApplyCashbackReward(double percent) {
			if (MonthlyPurchaseTotal < 1000.00) {
				double cashBack = MonthlyPurchaseTotal * (percent / 100);
				string cashBackTwoDecimal = cashBack.ToString("#.##");
				Console.WriteLine($"\nSuccess! {percent}% of ${MonthlyPurchaseTotal} gives you a Cash-Back Reward of ${cashBackTwoDecimal} applied to Membership {MembershipId}.");
			} else {
				percent = percent * 2;
				double cashBack = MonthlyPurchaseTotal * (percent / 100);
				string cashBackTwoDecimal = cashBack.ToString("#.##");
				Console.WriteLine($"\nSuccess! {percent}% of ${MonthlyPurchaseTotal} gives you a Cash-Back Reward of ${cashBackTwoDecimal} applied to Membership {MembershipId}.");
			}

			return MonthlyPurchaseTotal = 0D;
		}

		//special offer from interface
		//50% for executive
		public double SpecialOffer() {
			return AnnualCost * 0.5;
		}

		//tostring
		public override string ToString() {
			return base.ToString() + $"\nSpecial Offer! Your {MembershipType} Membership costs only ${SpecialOffer()}";
		}

  } //end class
} //end namespace