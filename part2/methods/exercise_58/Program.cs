using System;

namespace exercise_58
{
  class Program
  {
    public static void Main(String[] args)
    {
      int answer = Smallest(2, 7);
      Console.WriteLine("Smallest: " + answer);
    }

    // Write your method here:
    public static int Smallest(int number1, int number2)
    {
      if (number1 < number2) {
        return number1;
      }
      return number2;
    }
  }
}
