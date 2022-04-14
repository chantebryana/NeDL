/*
// from https://docs.microsoft.com/en-us/dotnet/api/system.io.file?view=netframework-4.8

using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string path = @".\MyTest.txt";
        if (!File.Exists(path))
        {
            // Create a file to write to.
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }
        }

        // Open the file to read from.
        using (StreamReader sr = File.OpenText(path))
        {
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}

using System;

namespace MyApplication
{
  class Program
  {
    static int divide (int divisor) {
    	return 5 / divisor;
    }
    
    static void Main(string[] args)
    {
      try
      {
        int divisor = 0;
        Console.WriteLine(divide(divisor));
        
        int[] myNumbers = {1, 2, 3};
        Console.WriteLine(myNumbers[10]);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
      }    
    }
  }
}
*/