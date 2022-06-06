/*
using System;

namespace MyApplication
{
  class Program
  {
    //validate user input. 0 is wrong; 1 is right
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
    static int Power (int myBase, int myExponent) {
        //initialize variable
        int runningTotal = 1;

        //compute base to the power of an exponent and return value
        for (int i = 0; i < myExponent; i++) {
            runningTotal = runningTotal * myBase;
        }
        return runningTotal;
    }

    static void Main(string[] args)
    {
        int baseAnswer = 0;
        while (baseAnswer != -1) {

        }
        
        //ask user for base and save answer
        Console.WriteLine("Enter base integer (1 or greater)"); //; or -1 to quit
        baseAnswer = Convert.ToInt16(Console.ReadLine());

        //validate answer
        int validate = ValidateInput(baseAnswer, 1);

        //if answer's outside of range, ask again; else, move forward
        while (validate != 1) {
            Console.WriteLine("Woops, wrong input.");
            Console.WriteLine("Enter base integer (1 or greater)"); //; or -1 to quit
            baseAnswer = Convert.ToInt16(Console.ReadLine());
            validate = ValidateInput(baseAnswer, 1);
        }
        
        //ask user for exponent and save answer
        Console.WriteLine("Enter exponent integer (1 or greater)"); //; or -1 to quit
        int exponentAnswer = Convert.ToInt16(Console.ReadLine());

        //validate answer
        validate = ValidateInput(exponentAnswer, 1);

        //if answer's outside of range, ask again; else, move forward
        while (validate != 1) {
            Console.WriteLine("Woops, wrong input.");
            Console.WriteLine("Enter exponent integer (1 or greater)"); //; or -1 to quit
            exponentAnswer = Convert.ToInt16(Console.ReadLine());
            validate = ValidateInput(exponentAnswer, 1);
        }

        //perform exponent calculation and print to user
        int endResult = Power(baseAnswer, exponentAnswer);
        Console.WriteLine($"{baseAnswer} ^ {exponentAnswer} = {endResult}");
    }
  }
}
*/