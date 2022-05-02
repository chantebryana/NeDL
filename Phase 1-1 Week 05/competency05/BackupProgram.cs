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
*/