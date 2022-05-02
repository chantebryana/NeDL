using System;

namespace CustomerMemberships
{
	abstract class Membership
  {
		//properties
		public int MembershipId
		{ get; set; }

		public string Email
		{ get; set; }

		public string MembershipType
		{ get; set; }

		public double AnnualCost
		{ get; set; }

		public double MonthlyPurchaseTotal
		{ get; set; }

		//default constructor
		public Membership() {
			MembershipId = -1;
			Email = "";
			MembershipType = "";
			AnnualCost = -1D;
			MonthlyPurchaseTotal = -1D;
		}

		//override constructor
		public Membership(int newId, string newEmail, string newType, double newCost, double newTotal) {
			MembershipId = newId;
			Email = newEmail;
			MembershipType = newType;
			AnnualCost = newCost;
			MonthlyPurchaseTotal = newTotal;
		}

		//methods!
		//purchase method: same logic for all types of memberships
		public double Purchase(double purchaseAmount) {
			return MonthlyPurchaseTotal += purchaseAmount;
		}

		//return method: same logic for all types of memberships
		public double Return(double returnAmount) {
			return MonthlyPurchaseTotal -= returnAmount;
		}

		//abstract apply cashback rewards: different logic depending on which membership type
		public abstract double ApplyCashbackReward(double percent);


		//override tostring (for pretty printening)
		public override string ToString() {
			return $"\nMembership Id: {MembershipId}\nEmail Address: {Email}\nMembership Type: {MembershipType}\nAnnual Cost: ${AnnualCost}\nMonthly Purchase Total: ${MonthlyPurchaseTotal}";
		}

  } //end class
} //end namespace