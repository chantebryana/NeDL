using System;
using System.Collections.Generic; //needed for lists

namespace listInterfaceCRUD
{
	class Program
  {
    static void Main(string[] args)
    {
      //create a list of employees
			List<Employee> employeeList = new List<Employee>();

			//add a couple of employees to the list to test
			employeeList.Add(new Employee("Earthwell", "Chante", "H"));
			employeeList.Add(new Employee("Earthwell", "James", "S"));

			//add a couple of hourly employees to the list to test
			employeeList.Add(new HourlyEmployee("Schneider", "Will", "H", 28.75));
			employeeList.Add(new HourlyEmployee("Schneider", "Laura", "H", 35.43));
			
			//add a couple of salary employees to the list to test
			employeeList.Add(new SalaryEmployee("Bauer", "Bob", "S", 95000.00));
			employeeList.Add(new SalaryEmployee("Bauer", "Linda", "S", 73000.00));

			//print the list
			foreach(Employee anEmployee in employeeList) {
				Console.WriteLine(anEmployee);
			} //end foreach

    } //end main
  } //end class
} //end namespace