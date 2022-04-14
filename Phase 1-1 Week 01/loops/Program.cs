Console.WriteLine("User: Enter the number of feet (as a whole number), then press ENTER.");
int feet = Convert.ToInt32(Console.ReadLine());

while (feet < 0) {
    Console.WriteLine("Oops! Invalid input. Please enter number of feet as a positive integer.");
    feet = Convert.ToInt32(Console.ReadLine());
};

int inches = feet * 12;

//Console.WriteLine(feet + " feet equals " + inches + " inches.");
//Console.WriteLine(string.Concat(feet, " feet equals ", inches, " inches."));
Console.WriteLine($"{feet} feet equals {inches} inches.!!");