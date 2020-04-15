

namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      List<Human> humans = new List<Human>();
      humans.Add(new Human("Merja", 500));
      humans.Add(new Human("Pertti", 80));
      humans.Add(new Human("Matti", 150000));

      // Sorts the list when your ComparedTo works
      // Sort uses CompareTo internally
      humans.Sort();
      humans.ForEach(Console.WriteLine);

    }
  }
}
