using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      SimpleDate d = new SimpleDate(1, 2, 2000);
      Console.WriteLine(d.Equals("heh"));
      Console.WriteLine(d.Equals(new SimpleDate(5, 2, 2012)));
      Console.WriteLine(d.Equals(new SimpleDate(1, 2, 2000)));
    }
  }
}
