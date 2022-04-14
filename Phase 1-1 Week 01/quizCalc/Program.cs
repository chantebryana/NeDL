using System;

namespace MyApplication
{
  class Program
  {
    //prompt for user input and validate that user entered positive number for total quizzes
    //return validated quiz quantity
    static int GetValidInt (int low, string question) {
        //ask user how many quizzes; store in int variable
        Console.WriteLine(question);
        int userNumber = Convert.ToInt16(Console.ReadLine());

        //validate that user entered positive number
        while (userNumber <= low) {
            Console.WriteLine("Woops! Number out of range.");
            Console.WriteLine(question);
            userNumber = Convert.ToInt16(Console.ReadLine());
        }

        return userNumber;
    }
    
    //prompt for user input and validate that quiz scores are between 0 and 100
    //return validated quiz score
    static int GetValidInt (int low, int high, string question) {
        //ask and store individual quiz score
        Console.WriteLine(question);
        int scoreInt = Convert.ToInt16(Console.ReadLine());

        //validate that user entered quiz score between 0 and 100
        while (scoreInt > high || scoreInt < low) {
            Console.WriteLine("Woops! Number out of range.");
            Console.WriteLine(question);
            scoreInt = Convert.ToInt16(Console.ReadLine());
        }
        return scoreInt;
    }

    //method to find the maximum quiz score
    static int MyMax(int x, int y) {
        if (x > y) {
                y = x;
            }
        return y;
    }
    
    //method to find the minimum quiz score
    static int MyMin(int x, int y) {
        if (x < y) {
                y = x;
            }
        return y;
    }
    
    static void Main(string[] args)
    {
        //prompt for user input and validate that user entered positive number for total quizzes
        //return validated quiz quantity
        string question = "User: How many quizzes? (Positive number)";
        int quizQuantity = GetValidInt(0, question);

        //initialize maximum quiz score
        int max = -1;

        //initialize minimum quiz score
        int min = 101;

        //initialize variable to help calculate average score
        double sumOfScores = 0;

        //loop through the number of quizzes
        for (int i = 0; i < quizQuantity; i++) {

            //prompt for user input and validate that quiz scores are between 0 and 100
            //return validated quiz score
            question = $"Quiz Score {i+1} (0-100)";
            int quizScoreInt = GetValidInt(0, 100, question);

            //on-the-fly comparison of running maximum total
            max = MyMax(quizScoreInt, max);

            //one-the-fly comparison of running minimum total
            min = MyMin(quizScoreInt, min);

            //sum all the totals to help calculate average
            sumOfScores += quizScoreInt;
        };

        //calculate average score
        double average = sumOfScores / quizQuantity;

        //tell user what the maximum score is
        Console.WriteLine($"Highest quiz score: {max}");

        //tell user what the minimum score is
        Console.WriteLine($"Lowest quiz score: {min}");

        //tell user what average score is
        Console.WriteLine($"Average quiz score: {average}");
    }
  }
}
