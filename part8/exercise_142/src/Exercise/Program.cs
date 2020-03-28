using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      IOU mattsIOU = new IOU();
      mattsIOU.ChangeDebt("Arthur", 51);
      mattsIOU.ChangeDebt("Arthur", 30);

      Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));

      mattsIOU.ChangeDebt("Arthur", -30);

      Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));

      mattsIOU.ChangeDebt("Arthur", -80);

      Console.WriteLine(mattsIOU.HowMuchDoIOweTo("Arthur"));
    }
  }
}
