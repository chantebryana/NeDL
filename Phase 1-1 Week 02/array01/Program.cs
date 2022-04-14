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
		
		//validate user input (lo only)
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

		//validate user input (lo and hi)
    static int ValidateInput (int userInput, int low, int high) {
        //if incorrect   
        if (userInput < low || userInput > high) {
						return 0;
        } 
        //if correct
        else {
            return 1;
        }
    }

		//method to find the minimum quiz score
    static int MyMin(int x, int y) {
        if (x < y) {
                y = x;
            }
        return y;
    }

		//method to find the maximum quiz score
    static int MyMax(int x, int y) {
        if (x > y) {
                y = x;
            }
        return y;
    }

		static void Main(string[] args)
    {
      //ask user for number of scores; save result; validate
			string question = "User, how many scores? (> 0)";
			int arrLength = WriteReadInt(question);
			int validate = ValidateInput(arrLength, 1);

			//if incorrect input, ask again
			while (validate != 1) {
				Console.WriteLine("Woops, wrong input");
				arrLength = WriteReadInt(question);
				validate = ValidateInput(arrLength, 1);
			}

			//instanciate new array of `loop` length
			int[] scores = new int[arrLength];

			//loop through scores array to get individual scores from user
			for (int i = 0; i < scores.Length; i++) {
				//ask user for each score
				Console.WriteLine($"Enter score {i+1} (between 0 and 100)");
				scores[i] = Convert.ToInt16(Console.ReadLine());
				
				//validate
				int validateScore = ValidateInput(scores[i], 0, 100);

				//if incorrect input
				while (validateScore != 1) {
					Console.WriteLine("Woops, wrong input");
					Console.WriteLine($"Enter score {i+1} (between 0 and 100)");
					scores[i] = Convert.ToInt16(Console.ReadLine());
					validateScore = ValidateInput(scores[i], 0, 100);
				}
			}

			//define variables for later
			int min = 101;
			int max = -1;
			int runningTotal = 0;

			//loop through completed array to calculate min, max, avg
			foreach (int j in scores) {	
				//minimum score
				min = MyMin(j, min);

				//maximum score
				max = MyMax(j, max);
				
				//running total for average score
				runningTotal += j;
			}
			
			//compute average score
			double average = (runningTotal / arrLength) * 1.00;

			//final report
			Console.WriteLine($"Minimum Score: {min}");
			Console.WriteLine($"Maximum Score: {max}");
			Console.WriteLine($"Average Score: {average}");
    }
  }
}