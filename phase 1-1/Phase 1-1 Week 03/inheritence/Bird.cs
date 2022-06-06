using System;

namespace MyApplication
{
  class Bird : Animal
  {
		//buncha properties
		public int Wingspan
		{ get; set; }

		public int FlightSpeed
		{ get; set; }

		//default constructor
		public Bird(): base() {
			//Species = "";
      //Weight = -1;
			Wingspan = -1;
			FlightSpeed = -1;
		}

		//override constructor
		public Bird (string newSpecies, int newWeight, int newWingspan, int newFlightspeed): base(newSpecies, newWeight) {
			//Species = newSpecies;
      //Weight = newWeight;
			Wingspan = newWingspan;
			FlightSpeed = newFlightspeed;
		}

		//override tostring
		public override string ToString () {
			return $"_BIRD_ Species: {Species} | Weight: {Weight} | Wingspan: {Wingspan} | FlightSpeed: {FlightSpeed}";
		}

  } //end class
} //end namespace