using System;

namespace MyApplication
{
  class Mammal : Animal
  {

		//buncha properties
		public string ColorFur
		{ get; set; }

		public int RunSpeed
		{ get; set; }

		//default constructor
		public Mammal() {
			ColorFur = "";
			RunSpeed = -1;
		}

		//override constructor
		public Mammal (string newSpecies, int newWeight, string newColorFur, int newRunSpeed) {
			Species = newSpecies;
			Weight = newWeight;
			ColorFur = newColorFur;
			RunSpeed = newRunSpeed;
		}

		//override tostring for printing
		public override string ToString() {
			return $"_MAMMAL_ Species: {Species} | Weight: {Weight} | ColorFur: {ColorFur} | RunSpeed: {RunSpeed}";
		}

  } //end class
} //end namespace