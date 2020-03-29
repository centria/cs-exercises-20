using System;
using System.Collections.Generic;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      LicensePlate li1 = new LicensePlate("FI", "ABC-123");
      LicensePlate li2 = new LicensePlate("FI", "UXE-465");
      LicensePlate li3 = new LicensePlate("D", "B WQ-431");

      List<LicensePlate> finnishPlates = new List<LicensePlate>();
      finnishPlates.Add(li1);
      finnishPlates.Add(li2);

      LicensePlate newLi = new LicensePlate("FI", "ABC-123");
      if (!finnishPlates.Contains(newLi))
      {
        finnishPlates.Add(newLi);
      }
      Console.WriteLine("Finnish: ");
      foreach (LicensePlate plate in finnishPlates)
      {
        Console.WriteLine(plate);
      }

      Dictionary<LicensePlate, string> owners = new Dictionary<LicensePlate, string>();
      owners.Add(li1, "Arto");
      owners.Add(li3, "Jürgen");

      Console.WriteLine("Owners:");
      Console.WriteLine(owners[new LicensePlate("FI", "ABC-123")]);
      Console.WriteLine(owners[new LicensePlate("D", "B WQ-431")]);
    }
  }
}
