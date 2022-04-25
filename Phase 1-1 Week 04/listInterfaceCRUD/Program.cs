using System;

namespace listInterfaceCRUD
{
	class Program
  {
    static void Main(string[] args)
    {
      Employee ceTest = new Employee("Earthwell", "Chante", "S");
			Console.WriteLine(ceTest);

			HourlyEmployee ceHourly = new HourlyEmployee("Schneider", "James", "H", 43.50);
			Console.WriteLine(ceHourly);
    } //end main
  } //end class
} //end namespace