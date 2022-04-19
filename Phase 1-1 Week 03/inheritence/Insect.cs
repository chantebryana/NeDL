using System;

namespace MyApplication
{
  class Insect : Animal
  {
    //buncha properties
    public bool CanFly
    { get; set; }

    public int NumEyes
    { get; set; }

    //default constructor
    public Insect () {
      CanFly = false;
      NumEyes = -1;
    }

    //override constructor
    public Insect (string newSpecies, int newWeight, bool newCanFly, int newNumEyes) {
      Species = newSpecies;
      Weight = newWeight;
      CanFly = newCanFly;
      NumEyes = newNumEyes;
    }

    //override tostring for printing
    public override string ToString() {
      return $"_INSECT_ Species: {Species} | Weight: {Weight} | CanFly: {CanFly} | NumEyes: {NumEyes}";
    }

  } //end class
} //end namespace