using System;

namespace listInterfaceCRUD
{

	class SalaryEmployee : Employee, IGetBonus, IRate {

		//property
		public double AnnualRate
		{ get; set; }

		//default constructor
		public SalaryEmployee() : base() {
			AnnualRate = 0.00;
		}

		//override constructor
		public SalaryEmployee(string lName, string fName, string eType, double sRate) : base(lName, fName, eType) {
			AnnualRate = sRate;
		}

		//interface methods
		public double GetBonus() {
			return AnnualRate * 0.10;
		}

		public override void SetRate(double newRate) {
			AnnualRate = newRate;
		}

		//override toString whatfor printing
		public override string ToString()
		{
			return base.ToString() + $" | Annual salary: ${AnnualRate} | Bonus: ${GetBonus()}";
		}

	} //end class
} //end namespace