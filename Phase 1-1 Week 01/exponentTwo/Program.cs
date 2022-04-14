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
    static long PowerHelper (int myBase, int myExponent) {
        //initialize variable
        long runningTotal = 1;

        //compute base to the power of an exponent and return value
        for (int i = 0; i < myExponent; i++) {
            runningTotal = runningTotal * myBase;
        }
        return runningTotal;
    }

    //iterates through the range of exponents provided by the user
    static void Power (int myBase, int myExponentOne, int myExponentTwo) {
        //initialize counter
        int counter = myExponentTwo - myExponentOne + 1;
        
        //loop through the range of exponents
        for (int j = 0; j < counter; j++) {
            //compute base to the power of an exponent and print answer
            long runningAnswer = PowerHelper(myBase, myExponentOne);
            Console.WriteLine($"{myBase} ^ {myExponentOne} = {runningAnswer}");
             
            //iterate the exponent by 1
            myExponentOne += 1;
        }
    }

    static void Main(string[] args)
    {
        //loop through until user opts to quit
        while (true) {
            //ask user for base and save answer
            string question = "Enter base integer (1 or greater; or 0 to quit)";
            int baseAnswer = WriteRead(question);

            //validate that answer is larger than 0
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
            
            //ask user for first exponent and save answer
            question = "Enter first exponent integer (1 or greater)";
            int exponentFirstAnswer = WriteRead(question);

            //validate that answer is larger than 1
            validate = ValidateInput(exponentFirstAnswer, 1);

            //if answer's outside of range, ask again; else, move forward
            while (validate != 1) {
                Console.WriteLine("Woops, wrong input.");
                exponentFirstAnswer = WriteRead(question);
                validate = ValidateInput(exponentFirstAnswer, 1);
            }

            //ask user for second exponent and save answer
            question = "Enter second exponent integer (larger than first exponent)";
            int exponentSecondAnswer = WriteRead(question);

            //validate that answer is larger than first exponent
            validate = ValidateInput(exponentSecondAnswer, (exponentFirstAnswer+1));

            //if answer's outside of range, ask again; else, move forward
            while (validate != 1) {
                Console.WriteLine("Woops, wrong input.");
                exponentSecondAnswer = WriteRead(question);
                validate = ValidateInput(exponentSecondAnswer, (exponentFirstAnswer+1));
            }

            //perform each exponent calculation and print to user
            Power(baseAnswer, exponentFirstAnswer, exponentSecondAnswer);
        }
    }
  }
}