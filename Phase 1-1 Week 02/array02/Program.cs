using System;

namespace MyApplication
{
  class Program
  {
		//ask for user input and validate (min only) till it's correct
		static int WriteReadValidate(string output, int min) {
			//ask user for input, save results, validate
			int input = WriteReadInt(output);
			int validate = ValidateInput(input, min);

			//if incorrect input, ask again
			while (validate != 1) {
				Console.WriteLine("Woops, wrong input");
				input = WriteReadInt(output);
				validate = ValidateInput(input, min);
			}

			return input;
		}

		//ask for user input and validate (min and max) till it's correct
		static int WriteReadValidate(string output, int min, int max) {
			//ask user for input, save results, validate
			int input = WriteReadInt(output);
			int validate = ValidateInput(input, min, max);

			//if incorrect input, ask again
			while (validate != 1) {
				Console.WriteLine("Woops, wrong input");
				input = WriteReadInt(output);
				validate = ValidateInput(input, min, max);
			}

			return input;
		}
		
		//print to console and get user response (integer)
    static int WriteReadInt(string output) {
        Console.WriteLine(output);
        int input = Convert.ToInt16(Console.ReadLine());
        return input;
    }
		
		//validate user input (lo only)
    static int ValidateInput(int userInput, int expected) {
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
    static int ValidateInput(int userInput, int low, int high) {
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
			/////
			// SECTION TO ASK USER TO DEFINE NUMBER OF STUDENTS AND SCORES
			// THEN GET STUDENT SCORES TO POPULATE GRADES TABLE
			/////
			
			//ask user for number of students; save result; validate till correct
			int low = 1;
			string question = $"User, how many students? ({low} or greater)";
			int numStudents = WriteReadValidate(question, low);

			//ask user for number of scores; save result; validate
			question = $"User, how many scores? ({low} or greater)";
			int numScores = WriteReadValidate(question, low);

			//initialize two-dimensional array (matching size set by user)
			int [,] gradeTable = new int [numScores,numStudents];

			//set low and high range of student scores (for validation and computation)
			int lo = 0;
			int hi = 100;

			//populate elements of two-dimentsional array with validated user input
			for (int column = 0; column < numStudents; column++) {
				for (int row = 0; row < numScores; row++) {
					//ask user for student score; save result; validate till correct
					question = $"Enter Score {row+1} for Student {column+1} (between {lo} and {hi})";
					gradeTable[row, column] = WriteReadValidate(question, lo, hi);
				}
			}

			//diving line between sections
			Console.WriteLine("================================");

			/////
			// SECTION TO COMPUTE MIN / MAX / AVERAGE SCORES 
			// (FOR EACH STUDENT AND FOR ENTIRE CLASS)
			// THEN REPORT RESULTS
			/////

			//define computational variables
			int[] studentTotal = new int[numStudents];
			int classMin = hi + 1;
			int classMax = lo - 1;
			int classTotal = 0;
			
			//loop through two-dimensional array (columns/students)
			for (int column = 0; column < numStudents; column++) {
				//define computational variables
				int studentMin = hi + 1;
				int studentMax = lo - 1;
				
				//loop through two-dimensional arry (rows/scores)
				//compute min, max, avg, etc
				for (int row = 0; row < numScores; row++) {
					//compute minimum, maximum, runningTotal scores for each student
					studentMin = MyMin(gradeTable[row, column], studentMin);
					studentMax = MyMax(gradeTable[row, column], studentMax);
					studentTotal[column] += gradeTable[row, column];

				}
				//compute student average score, round to 2 decimal places
				double studentAverage = Math.Round(studentTotal[column] / (numScores * 1.00D), 2);
				
				//final report for each student
				Console.WriteLine($"Student {column+1} minimum score: {studentMin}");
				Console.WriteLine($"Student {column+1} maximum score: {studentMax}");
				Console.WriteLine($"Student {column+1} average score: {studentAverage}");
				Console.WriteLine("--------------------------------");

				//compute minimum, maximum, runningTotal scores for whole class
				classMin = MyMin(studentMin, classMin);
				classMax = MyMax(studentMax, classMax);
				classTotal += studentTotal[column];
			}
			
			//compute class average score, round to 2 decimal places
			double classAverage = Math.Round((classTotal / (numStudents * numScores * 1.00D)), 2);

			//final report for class
			Console.WriteLine($"Class minimum score: {classMin}");
			Console.WriteLine($"Class maximum score: {classMax}");
			Console.WriteLine($"Class average score: {classAverage}");
    }
  }
}