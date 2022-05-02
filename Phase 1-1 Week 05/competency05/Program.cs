using System;
using System.Collections.Generic; //needed for lists

namespace CustomerMemeberships
{
	class Program
  {
    static void Main(string[] args)
    {
			//create list of memberships
			List<Membership> memberships = new List<Membership>();

			//add a series of hard-coded membership types
			memberships.Add(new Membership(1, "email@domain.com", "Regular", 100.00, 500.00));
			memberships.Add(new Membership(2, "email2@domain.com", "Executive", 200.00, 1000.00));
			memberships.Add(new Membership(3, "email3@domain.com", "Nonprofit", 50.00, 250.00));
			memberships.Add(new Membership(4, "email4@domain.com", "Corporate", 274.99, 25000.00));

			foreach(Membership aMembership in memberships) {
						Console.WriteLine(aMembership);
					}

    } //end main
  } //end class
} //end namespace