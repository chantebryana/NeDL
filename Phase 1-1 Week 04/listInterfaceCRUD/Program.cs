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

			SalaryEmployee ceSalary = new SalaryEmployee("Bauer", "Brittany", "S", 73000.00);
			Console.WriteLine(ceSalary);
    } //end main
  } //end class
} //end namespace