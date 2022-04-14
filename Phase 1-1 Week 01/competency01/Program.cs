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

		//ask and save student grades; return total sum
		static int GatherGrades (int loop, string category) {
			//set variable for running sum
			int sum = 0;
			
			//set low and high (for validation)
			int lo = 0;
			int hi = 100;

			//Report which category we're gathering grades for
			Console.WriteLine($"Category: {category} Grades");

			//loop through each grade
			for (int j = 0; j < loop; j++) {
					//ask and save grade
					string question = $"{category} Grade {j+1} of {loop} (Between 0 and 100)";
					int grade = WriteReadInt(question);

					//validate grade is >= lo && <= hi
					int validate = ValidateInput(grade, lo, hi);

					//if answer's out of range, ask again
					while (validate != 1) {
						Console.WriteLine("Woops, wrong input.");
						grade = WriteReadInt(question);
						validate = ValidateInput(grade, lo, hi);
					}

					//Running sum of grade
					sum += grade;
				}

			return sum;
		}

		//calculate average score for individual grade category
		static double CalculateAverage (int sum, int loop) {
			return (sum / loop) * 1.00;
		}

		//calculate weighted average for individual grade category
		static double CalculateWeighedAverage (double grade, double weight) {
			return (grade * weight) * 1.00;
		}

		//letter grade table
		static char GetLetterGrade (double grade) {
			if (grade >= 90.0) {
				return 'A';
			} else if (grade >=80.0 && grade < 90.0) {
				return 'B';
			} else if (grade >=70.0 && grade < 80.0) {
				return 'C';
			} else if (grade >=60.0 && grade < 70.0) {
				return 'D';
			} else
				return 'F';
		}

    static void Main(string[] args)
    {
			//
			//===HOW MANY STUDENTS SECTION===
			//
			//prompt user for number of students; save results as int
			string question = "How many students? (1 or more)";
			int outerLoop = WriteReadInt(question);
			//validate int is 1 or greater
			int validate = ValidateInput(outerLoop, 1);

			//if answer's out of range, ask again
			while (validate != 1) {
				Console.WriteLine("Woops, wrong input.");
				outerLoop = WriteReadInt(question);
				validate = ValidateInput(outerLoop, 1);
			}

			//loop through each student
			for (int i = 0; i < outerLoop; i++) {
				//
				//ASK FOR STUDENT NAME
				//
				//ask and save student name
				question = $"Name of Student {i+1}";
				string studentName = WriteReadStr(question);

				//CE potentially add validation if empty string; couldn't figure out on first attempt

				//
				//===HOMEWORK SECTION===
				//
				//get homework grades and set to total homework sum
				int innerloop = 5;
				string gradeType = "Homework";
				int sum = GatherGrades(innerloop, gradeType);
				
				//calculate homework average
				double avgHomework = CalculateAverage(sum, innerloop);

				//compute weighted homework average
				double weightedHomework = CalculateWeighedAverage(avgHomework, (innerloop * 0.1));

				//
				//===QUIZ SECTION===
				//
				//get quiz grades and set to total quiz sum
				innerloop = 3;
				gradeType = "Quiz";
				sum = GatherGrades(innerloop, gradeType);

				//calculate quiz average
				double avgQuiz = CalculateAverage(sum, innerloop);

				//compute weighted quiz average
				double weightedQuiz = CalculateWeighedAverage(avgQuiz, (innerloop * 0.1));

				//
				//===EXAM SECTION===
				//
				//get exam grades and set to total exam sum
				innerloop = 2;
				gradeType = "Exam";
				sum = GatherGrades(innerloop, gradeType);

				//calculate exam average
				double avgExam = CalculateAverage(sum, innerloop);

				//compute weighted exam average
				double weightedExam = CalculateWeighedAverage(avgExam, (innerloop * 0.1));

				//
				//===FINAL MATHS + REPORT===
				//
				//compute total weighted average, rounded to 2 decimal places
				double totalAvg = Math.Round((weightedHomework + weightedQuiz + weightedExam), 2);

				//letter grade (def method)
				char letterGrade = GetLetterGrade(totalAvg);

				//final report
				Console.WriteLine("==============================");
				Console.WriteLine($"Compute grades for {studentName}");
				Console.WriteLine($"Homework Average: {avgHomework}");
				Console.WriteLine($"Quiz Average: {avgQuiz}");
				Console.WriteLine($"Exam Average: {avgExam}");
				Console.WriteLine($"Final Average: {totalAvg}");
				Console.WriteLine($"Final Grade: {letterGrade}");
				Console.WriteLine("==============================");
			}
    }
  }
}