using System;

namespace MyApplication
{
  class Program
  {
    //print to console and get user response
    static int WriteRead(string output) {
        Console.WriteLine(output);
        int input = Convert.ToInt16(Console.ReadLine());
        return input;
    }
    
    //validate user input
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

    //computes base to the power of an exponent (eg 2^3)
    static long Power (int myBase, int myExponent) {
        //initialize variable
        long runningTotal = 1;

        //compute base to the power of an exponent and return value
        for (int i = 0; i < myExponent; i++) {
            runningTotal = runningTotal * myBase;
        }
        return runningTotal;
    }

    static void Main(string[] args)
    {
        //loop through until user opts to quit
        while (true) {
            //ask user for base and save answer
            string question = "Enter base integer (1 or greater; or 0 to quit)";
            int baseAnswer = WriteRead(question);

            //validate answer
            int validate = ValidateInput(baseAnswer, 0);

            //if answer's outside of range, ask again; else, move forward
            while (validate != 1) {
                Console.WriteLine("Woops, wrong input.");
                baseAnswer = WriteRead(question);
                validate = ValidateInput(baseAnswer, 0);
            }

            //break loop if user opts to quit
            if (baseAnswer == 0) {
                break;
            }
            
            //ask user for exponent and save answer
            question = "Enter exponent integer (1 or greater)";
            int exponentAnswer = WriteRead(question);

            //validate answer
            validate = ValidateInput(exponentAnswer, 1);

            //if answer's outside of range, ask again; else, move forward
            while (validate != 1) {
                Console.WriteLine("Woops, wrong input.");
                exponentAnswer = WriteRead(question);
                validate = ValidateInput(exponentAnswer, 1);
            }

            //perform exponent calculation and print to user
            long endResult = Power(baseAnswer, exponentAnswer);
            Console.WriteLine($"{baseAnswer} ^ {exponentAnswer} = {endResult}");
        }
    }
  }
}