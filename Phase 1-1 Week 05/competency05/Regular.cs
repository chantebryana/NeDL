using System;

namespace CustomerMemberships
{
	class Regular: Membership, ISpecialOffer
  {
		//properties
		public double CashBackPercent
		{ get; set; }

		//default constructor
		public Regular(): base() {}

		//override constructor
		public Regular(int newId, string newEmail, string newType, double newCost, double newTotal, double newPercent): base(newId, newEmail, newType, newCost, newTotal) {
			CashBackPercent = newPercent;
		}
		
		//cashback
		//regular membership has flat percent (5%) for cash-back rewards on all purchases
		//once applied, zero out monthly purchase total
		public override double ApplyCashbackReward() {
			if (MonthlyPurchaseTotal > 0) {
				double cashBack = MonthlyPurchaseTotal * (CashBackPercent / 100);
				string cashBackTwoDecimal = cashBack.ToString("#.##");
				Console.WriteLine($"\nSuccess! {CashBackPercent}% of ${MonthlyPurchaseTotal} gives you a Cash-Back Reward of ${cashBackTwoDecimal} applied to Membership {MembershipId}.");

				MonthlyPurchaseTotal = 0D;
			}
			//if monthlypuchasetotal == 0 (ex: if cashback already applied)
			else {
				Console.WriteLine($"Member {MembershipId}'s Monthly Purchase Total is $0.00. Cannot apply Cash Back Bonus. Buy more stuff!");
			}

			return MonthlyPurchaseTotal;
		}

		//special offer from interface
		//25% for regular
		public double SpecialOffer() {
			return AnnualCost * 0.25;
		}

		//tostring
		public override string ToString() {
			return base.ToString() + $"\nSpecial Offer! Your {MembershipType} Membership costs only ${SpecialOffer()}";
		}
		

  } //end class
} //end namespace