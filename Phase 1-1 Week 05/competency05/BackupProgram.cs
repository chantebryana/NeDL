/*
//play with cash back
bool idFound = false;
int id = 4;
bool milOrEd = true;
foreach(Membership aMembership in memberships) {
	//if id is found in list
	if (aMembership.MembershipId == id) {
		idFound = true;
		aMembership.MonthlyPurchaseTotal = aMembership.ApplyCashbackReward(corporatePercent);
		Console.WriteLine(aMembership);
	}
} //end foreach

//if id is not found in list
if (idFound == false) {
	Console.WriteLine("Oops! The ID you entered wasn't found in the list.");
}



//cashback
		//regular membership has flat percent (5%) for cash-back rewards on all purchases
		//once applied, zero out monthly purchase total
		public override double ApplyCashbackReward(double percent) {
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
*/