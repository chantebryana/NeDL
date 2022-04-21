using System;

namespace MyApplication
{
  class Employee
  {
		//lotsa properties
		public string LastName 
		{ get; set; }

		public string FirstName
		{ get; set; }

		//h for hourly, s for salary
		public char EmployeeType
		{ get; set; }

		//default constructor
		public Employee () {
			LastName = "";
			FirstName = "";
			EmployeeType = 'z';
		}

		//override constructor
		public Employee (string newLast, string newFirst, char newType) {
			LastName = newLast;
			FirstName = newFirst;
			EmployeeType = Char.ToUpper(newType); //make sure char is uppercase to simplify logic later
		}

		//method to calculate the bonus, based on whether employee is hourly or salary
		public virtual double CalculateBonus (int baseRate) {
			Console.WriteLine("Calculate Bonus inside Employee Class. Returns 0.");
			return 0.00;
		}

		//override tostring for printing
		public override string ToString() {
			return $"Employee {FirstName} {LastName} is {EmployeeType}";
		}

  } //end class
} //end namespace