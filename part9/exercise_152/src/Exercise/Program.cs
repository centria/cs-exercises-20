using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      TripleTacoBox trip = new TripleTacoBox();
      Console.WriteLine(trip.TacosRemaining());
      trip.Eat();
      Console.WriteLine(trip.TacosRemaining());
      trip.Eat();
      Console.WriteLine(trip.TacosRemaining());
      trip.Eat();
      Console.WriteLine(trip.TacosRemaining());
      // Try to eat one too much
      trip.Eat();
      Console.WriteLine(trip.TacosRemaining());

      Console.WriteLine();

      CustomTacoBox custom = new CustomTacoBox(2);
      Console.WriteLine(custom.TacosRemaining());
      custom.Eat();
      Console.WriteLine(custom.TacosRemaining());
      custom.Eat();
      Console.WriteLine(custom.TacosRemaining());
      // Try to eat one too much
      custom.Eat();
      Console.WriteLine(custom.TacosRemaining());
    }
  }
}
