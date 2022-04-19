using System;

namespace MyApplication
{
  class Restaurant
  {
    //private data objects
		//restaurant name and restaurant rating
		private string _rname; 
		//private int _rrating;
    
		//Get Set property for Restaurant Name
		public string RName 
    {
      get { return _rname; }
      set { _rname = value; }
    }  

		//Get Set property for Restaurant Rating
		public int RRating { 
			get; set; 
		}

		//default constructor (empty)
		public Restaurant () { 
			RName = "";
			RRating = -1;
		}

//constructor w arguments passed (set name and rating)
		public Restaurant (string newRestaurant, int newRating) { 
			RName = newRestaurant;
			RRating = newRating;
		}

		//override tostring for printing
		public override string ToString() {
			return $"{RName}: {RRating}";
		}

  } //end class
} //end namespace