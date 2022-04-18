using System;

namespace MyApplication
{
  class Restaurant
  {
    private string _rname;  // field
    public string RName    // property
    {
      get { return _rname; }
      set { _rname = value; }
    }  
  } //end class
} //end namespace