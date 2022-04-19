using System;

namespace MyApplication
{
  class Animal
  {
    //buncha properties
    public string Species 
    { get; set; }

    public int Weight
    { get; set; }

    //default constructor
    public Animal() {
      Species = "";
      Weight = -1;
    }

    //override constructor
    public Animal(string newSpecies, int newWeight) {
      Species = newSpecies;
      Weight = newWeight;
    }
    

  } //end class
} //end namespace