// DO NOT TOUCH THIS FILE!

namespace Exercise
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      int input = 0;
      try
      {
        input = Convert.ToInt32(Console.ReadLine());
      }
      catch
      {
        input = 0;
      }
      for (int i = 0; i <= input; i++)
      {
        Console.WriteLine(i);
      }
    }
  }
}
