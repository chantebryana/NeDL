using System;

namespace listInterfaceCRUD
{

	class Employee : IRate {
		// properties
		public string LastName 
		{ get; set; }

		public string FirstName
		{ get; set; }

		public string EmployeeType
		{ get; set; }

		//default constructor
		public Employee() {
			LastName = "";
			FirstName = "";
			EmployeeType = "";
		}

		//override constructor
		public Employee(string lName, string fName, string eType) {
			LastName = lName;
			FirstName = fName;
			EmployeeType = eType;
		}

		//interface method
		public virtual void SetRate(double newRate) {
			//do nothing here
		}

		//override ToString to simplify logging to console
		public override string ToString()
		{
			return $"Employee: {LastName}, {FirstName} | Type: {EmployeeType}";
		}


	} //end class
} //end namespace
