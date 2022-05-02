using System;

namespace CustomerMemberships
{
	class Regular: Membership, ISpecialOffer
  {
		//properties
		//there are no new ones

		//default constructor
		public Regular(): base() {}

		//override constructor
		public Regular(int newId, string newEmail, string newType, double newCost, double newTotal): base(newId, newEmail, newType, newCost, newTotal) {}
		
		//cashback
		//regular membership has flat percent (5%) for cash-back rewards on all purchases
		//once applied, zero out monthly purchase total
		public override double ApplyCashbackReward() {
			double cashBack = MonthlyPurchaseTotal * 0.05;
			Console.WriteLine($"\nSuccess! Cash-back reward of ${cashBack} applied to membership {MembershipId}.");

			return MonthlyPurchaseTotal = 0D;
		}

		//special offer from interface
		public double SpecialOffer() {
			return AnnualCost * 0.25;
		}

		//tostring
		public override string ToString() {
			return base.ToString() + $"\nSpecial Offer! Your {MembershipType} Membership costs only ${SpecialOffer()}";
		}
		

  } //end class
} //end namespace