using System;
using System.IO;
using static System.Linq.Enumerable;


namespace exercise_119
{
  class Program
  {
    public static void Main(string[] args)
    {
      Timer timer = new Timer();
      Console.WriteLine(timer);
      foreach (int i in Range(0,100)) {
        timer.Advance();
      }
      Console.WriteLine(timer);

      foreach (int i in Range(0,5899)) {
        timer.Advance();
      }
      Console.WriteLine(timer);

      timer.Advance();
      Console.WriteLine(timer);
      
      timer.Advance();
      Console.WriteLine(timer);
    }
  }
}
