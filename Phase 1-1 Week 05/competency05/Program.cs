using System;
using System.Collections.Generic; //needed for lists

namespace CustomerMemberships
{
	class Program
  {
    static void Main(string[] args)
    {
			//create list of memberships
			List<Membership> memberships = new List<Membership>();

			//add a series of hard-coded membership types
			memberships.Add(new Regular(1, "email@domain.com", "Regular", 100.00, 500.00));
			memberships.Add(new Regular(2, "email2@domain.com", "Executive", 200.00, 1000.00));
			memberships.Add(new Regular(3, "email3@domain.com", "Nonprofit", 50.00, 250.00));
			memberships.Add(new Regular(4, "email4@domain.com", "Corporate", 274.99, 25000.00));

			foreach(Membership aMembership in memberships) {
				Console.WriteLine(aMembership);
			}

			//play with cash back
			bool idFound = false;
			int id = 2;
			foreach(Membership aMembership in memberships) {
				//if id is found in list
				if (aMembership.MembershipId == id) {
					idFound = true;
					aMembership.MonthlyPurchaseTotal = aMembership.ApplyCashbackReward();
					Console.WriteLine(aMembership);
				}
			} //end foreach

			//if id is not found in list
			if (idFound == false) {
				Console.WriteLine("Oops! The ID you entered wasn't found in the list.");
			}

    } //end main
  } //end class
} //end namespace