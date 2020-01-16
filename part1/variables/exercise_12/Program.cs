using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      Console.WriteLine("Give a number!");
      string userInput = Console.ReadLine();

      // Convert string to integer type
      int intValue = Convert.ToInt32(userInput);
      Console.WriteLine("You gave " + intValue);

    }
  }
}
