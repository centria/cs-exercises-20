namespace Exercise
{
  using System;
  public class Program
  {
    public static void Main(string[] args)
    {
      Die die = new Die(6);

      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(die.ThrowDie());
      }
    }
  }
}
