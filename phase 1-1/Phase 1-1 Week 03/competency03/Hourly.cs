using System;
using System.Globalization;

namespace MyApplication
{
  class Hourly : Employee
  {
		//property
		public int HourlyRate
		{ get; set; }

		//default constructor
		public Hourly(): base() {
			HourlyRate = -1;
		}

		//override constructor
		public Hourly(string newLast, string newFirst, char newType, int newHrRate): base(newLast, newFirst, newType) {
			HourlyRate = newHrRate;
		}

		//override bonus method
		//method to calculate the bonus, based on whether employee is hourly or salary
		//hourly rate bonus is two weeks' pay
		public override double CalculateBonus (int baseRate) {
			//Console.WriteLine("Calculate Bonus inside Hourly Class. Returns 2 weeks' pay.");
			return (baseRate * 80.0);
		}

		//override tostring for printing
		public override string ToString() {
			//format salary to follow USD currency format
			string hrRateUSD = HourlyRate.ToString("C", CultureInfo.CurrentCulture);

			return $"Employee {FirstName} {LastName} is {EmployeeType} and makes {hrRateUSD} per hour.";
		}

  } //end class
} //end namespace