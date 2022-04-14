/*
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
    static int ValidateInput (int userInput, int low, int high) {
        //special case if user wants to quit
        if (userInput == -1) {
            return 1;
        }
        //if incorrect 
        else if (userInput < low || userInput > high) {
            return 0;
        } 
        //if correct
        else {
            return 1;
        }
    }
      
      //convert raw user input string into array of numbers (eg: "20 2" becomes {20, 2})
      static int[] StringToInt(string userInput) {
        string[] words = userInput.Split(' ');
        int[] nums = {0, 0};
        nums[0] = Convert.ToInt16(words[0]);
        nums[1] = Convert.ToInt16(words[1]);
        return nums;
      }
    static void Main(string[] args)
    {
        //loop through till user quits
        while (true) {
            //ask user for dataset input and save answer
            string question = "User, how many datasets do you want to enter? (Up to 10 at a time; type '-1' to quit.)";
            int datasetRange = WriteRead(question);

            //validate
            int validate = ValidateInput(datasetRange, 1, 10);

            //if dataset number's outside range
            if (datasetRange < -2 || datasetRange == 0 || datasetRange > 10) {
                Console.WriteLine("Woops! Incorrect input.");
                datasetRange = WriteRead(question);
            } 
            //break loop if user opts to quit
            else if (datasetRange == -1) {
                break;
            }
            //if dataset number's inside range
            else if (datasetRange > 0 && datasetRange <= 10) {
                //basic entry instructions
                Console.WriteLine("User, enter MPH and TIME (hrs) (ex: '20 2' or '25 7')");
                
                //ask user for mph and time
                for (int j = 0; j < datasetRange; j++) {
                    Console.WriteLine($"User: Enter dataset {j+1}:");
                    string userInput = Console.ReadLine();
                    int[] nums = StringToInt(userInput);
                    Console.WriteLine($"mph: {nums[0]}, hrs: {nums[1]}");
                }
            }
        }
    }  
  }
}
*/