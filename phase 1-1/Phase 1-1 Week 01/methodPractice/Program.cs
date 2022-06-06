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

    //print to console and get user response
    static int[] WriteReadArr(string output) {
        Console.WriteLine(output);
        string input = Console.ReadLine();
        int[] nums = StringToInt(input);
        return nums;
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

            //keep asking if dataset number's outside range
            while (validate == 0) {
                Console.WriteLine("Woops! Incorrect input.");
                datasetRange = WriteRead(question);
                //validate
                validate = ValidateInput(datasetRange, 1, 10);
            } 
            
            //break loop if user opts to quit
            if (datasetRange == -1) {
                break;
            }
            
            //if dataset number's inside range
            //basic entry instructions
            Console.WriteLine("User, enter SPEED (mph) and TIME (hrs) (ex: '20 2' or '55 7')");
            
            //ask user for mph and time
            for (int j = 0; j < datasetRange; j++) {
                question = $"Enter dataset {j+1}:";
                int[] nums = WriteReadArr(question);
                
                //validate user input
                int validateSpeed = ValidateInput(nums[0], 1, 90);
                int validateTime = ValidateInput(nums[1], 1, 12);
                Console.WriteLine($"validateSpeed: {validateSpeed}, validateTime: {validateTime}");
                
                //keep asking if input's out of range
                while (validateSpeed == 0 || validateTime == 0) {
                    Console.WriteLine("Woops! Incorrect input.");
                    nums = WriteReadArr(question);
                    //validate user input
                    validateSpeed = ValidateInput(nums[0], 1, 90);
                    validateTime = ValidateInput(nums[1], 1, 12);
                }

                Console.WriteLine($"mph: {nums[0]}, hrs: {nums[1]}");
            }
        }
    }  
  }
}