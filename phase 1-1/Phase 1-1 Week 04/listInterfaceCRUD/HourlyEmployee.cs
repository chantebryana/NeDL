using System;

namespace listInterfaceCRUD
{

	class HourlyEmployee : Employee, IGetBonus, IRate {
		//property
		public double HourlyRate
		{ get; set; }

		//default constructor
		public HourlyEmployee () : base() {
			HourlyRate = 0.0;
		}

		//override constructor
		public HourlyEmployee(string lName, string fName, string eType, double hRate) : base(lName, fName, eType) {
			HourlyRate = hRate;
		}

		//interface methods
		public double GetBonus() {
			return HourlyRate * 80D;
		}

		public override void SetRate(double newRate)
		{
			HourlyRate = newRate;
		}

		//override toString whatfor printing
		public override string ToString()
		{
			return base.ToString() + $" | Hourly rate: ${HourlyRate} | Bonus: ${GetBonus()}";
		}

	} //end class
} //end namespace