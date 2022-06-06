/*

using System;

namespace MyApplication
{
  class Program
  {
		//print to console and get user response (integer)
    static int WriteReadInt(string output) {
        Console.WriteLine(output);
        int input = Convert.ToInt16(Console.ReadLine());
        return input;
    }

		//print to console and get user response (string)
    static string WriteReadStr(string output) {
        Console.WriteLine(output);
        string input = Console.ReadLine();
        return input;
    }

		//validate user input (int)
    static int ValidateInput (int userInput, int expected) {
        //if incorrect   
        if (userInput < expected) {
            return 0;
        } 
        //if correct
        else {
            return 1;
        }
    }

		//validate user input (string)
    static int ValidateInput (string userInput) {
        //if incorrect   
        if (userInput == null || userInput == "") {
            return 0;
        } 
        //if correct
        else {
            return 1;
        }
    }
    static void Main(string[] args)
    {
			//prompt user for number of students; save results as int
			string question = "How many students? (1 or more)";
			int loop = WriteReadInt(question);
			//validate int is 1 or greater
			int validate = ValidateInput(loop, 1);

			//if answer's out of range, ask again
			while (validate != 1) {
				Console.WriteLine("Woops, wrong input.");
				loop = WriteReadInt(question);
				validate = ValidateInput(loop, 1);
			}

			for (int i = 0; i < loop; i++) {
				//ask and save student name
				question = $"Name of Student {i+1}";
				string studentName = WriteReadStr(question);

				//validate that string isn't blank
				while (validate != 1) {
					Console.WriteLine("Woops, wrong input.");
					studentName = WriteReadStr(question);
					validate = ValidateInput(studentName);
				}
			}
    }
  }
}

*/