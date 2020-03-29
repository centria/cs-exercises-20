using System;
using System.Collections.Generic;

namespace Exercise
{
  public class VehicleRegistry
  {
    private Dictionary<LicensePlate, string> owners = new Dictionary<LicensePlate, string>();
    public bool Add(LicensePlate licensePlate, string owner)
    {
      return false;
    }

    public string Get(LicensePlate licensePlate)
    {
      return "No such license";
    }

    public bool Remove(LicensePlate licensePlate)
    {
      return false;
    }

    public void PrintLicensePlates()
    {
      
    }

    public void PrintOwners()
    {

    }
  }
}