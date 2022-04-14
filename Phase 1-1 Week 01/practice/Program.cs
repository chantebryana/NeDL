//prompt user 3 times for numbers between 1 and 10
//save those numbers into individual variables
Console.WriteLine("User: Enter a whole number between 0 and 11.");
int numOne = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("User: Enter another whole number between 0 and 11.");
int numTwo = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("User: Enter a final whole number between 0 and 11.");
int numThree = Convert.ToInt16(Console.ReadLine());

//use math methods to auto-find the following:
//largest
if (numOne >= numTwo && numOne >= numThree) {
    Console.WriteLine($"Largest number: {numOne}");
} else if (numTwo >= numOne && numTwo >= numThree) {
    Console.WriteLine($"Largest number: {numTwo}");
} else if (numThree >= numOne && numThree >= numTwo) {
    Console.WriteLine($"Largest number: {numThree}");
};
//smallest
if (numOne <= numTwo && numOne <= numThree) {
    Console.WriteLine($"Smallest number: {numOne}");
} else if (numTwo <= numOne && numTwo <= numThree) {
    Console.WriteLine($"Smallest number: {numTwo}");
} else if (numThree <= numOne && numThree <= numTwo) {
    Console.WriteLine($"Smallest number: {numThree}");
};
//average
double average = (numOne + numTwo + numThree) / 3.0;
Console.WriteLine($"Average number: {average}");