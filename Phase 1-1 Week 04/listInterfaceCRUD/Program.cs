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

			//=============================================================
			//experiment with reading (finding) and employee(s) in the list
			//=============================================================

			//talk to human and save response
			Console.WriteLine("Enter an employee Last Name to find: ");
			string findName = Console.ReadLine();

			//search list for name
			//print it if found
			//else print error message

			//initialize variable
			bool found = false;

			foreach(Employee anEmployee in employeeList) {
				if (anEmployee.LastName == findName) {
					Console.WriteLine(anEmployee);
					found = true;
				}
			} //end foreach

			if (!(found)) {
				Console.WriteLine("Oops! Name not found.");
			}

			//=============================================================
			//experiment with creating (adding) an employee to the list
			//=============================================================

			//talk to human and save response
			Console.WriteLine("Enter an employee last name to add:");
			string lName = Console.ReadLine();
			Console.WriteLine("Enter an employee first name to add:");
			string fName = Console.ReadLine();
			Console.WriteLine("Enter an employee type to add (S or H):");
			string eType = (Console.ReadLine()).ToUpper(); //convert user input to uppercase

			//conditional actions depending on employee type
			switch (eType) {
				case "S": 
					//continue talking to human and save response
					Console.WriteLine("Enter annual salary:");
					double aSalary = Convert.ToDouble(Console.ReadLine());

					//add new user input to list & let user know
					employeeList.Add(new SalaryEmployee(lName, fName, eType, aSalary));
					Console.WriteLine("Salary employee added. Printing out new list.");
					break;
				case "H": 
					//continue talking to human and save response
					Console.WriteLine("Enter hourly rate:");
					double hRate = Convert.ToDouble(Console.ReadLine());

					//add new user input to list & let user know
					employeeList.Add(new HourlyEmployee(lName, fName, eType, hRate));
					Console.WriteLine("Hourly employee added. Printing out new list.");

					break;
				default: 
					Console.WriteLine("Oops! Wrong option and you only get one chance here. Nothing was added to list.");
					break;
			} //end switch

			//print list again
			foreach (Employee anEmployee in employeeList) {
				Console.WriteLine(anEmployee);
			}


    } //end main
  } //end class
} //end namespace