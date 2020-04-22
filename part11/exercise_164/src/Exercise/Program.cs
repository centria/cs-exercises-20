namespace Exercise
{
  using System;
  using System.Collections.Generic;
  public class Program
  {
    public static void Main(string[] args)
    {
      TemperatureSensor temperatureSensor = new TemperatureSensor();
      temperatureSensor.SetOn();
      Console.WriteLine(temperatureSensor.Read());
    }
  }
}
