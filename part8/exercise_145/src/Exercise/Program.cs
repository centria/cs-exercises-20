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
      LicensePlate li4 = new LicensePlate("D", "B WQ-432");
      LicensePlate li5 = new LicensePlate("D", "B WQ-433");

      VehicleRegistry register = new VehicleRegistry();

      register.Add(li1, "Arto");
      register.Add(li2, "Arto");
      register.Add(li3, "Jürgen");
      register.Add(li4, "Jürgen");
      register.Add(li5, "Jürgen");

      Console.WriteLine("Plates:");
      register.PrintLicensePlates();

      Console.WriteLine("Owners:");
      register.PrintOwners();
    }
  }
}
