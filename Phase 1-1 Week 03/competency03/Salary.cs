using System;
using System.Globalization;

namespace MyApplication
{
  class Salary : Employee
  {
		//property
		public int AnnualSalary
		{ get; set; }

		//default constructor
		public Salary(): base() {
			AnnualSalary = -1;
		}

		//override constructor
		public Salary(string newLast, string newFirst, char newType, int newSalary): base(newLast, newFirst, newType) {
			AnnualSalary = newSalary;
		}

		//override bonus method
		//method to calculate the bonus, based on whether employee is hourly or salary
		//salary bonus is 10% of annual salary
		public override double CalculateBonus (int baseRate) {
			Console.WriteLine("Calculate Bonus inside Salary Class. Returns 10% of base salary.");
			return (baseRate * 0.10);
		}

		//override tostring for printing
		public override string ToString() {
			//format salary to follow USD currency format
			string salaryUSD = AnnualSalary.ToString("C", CultureInfo.CurrentCulture);

			return $"Employee {FirstName} {LastName} is {EmployeeType} and makes {salaryUSD} per year.";
		}

  } //end class
} //end namespace