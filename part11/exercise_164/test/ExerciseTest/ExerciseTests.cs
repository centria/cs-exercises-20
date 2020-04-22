using System;
using System.IO;
using NUnit.Framework;
using Exercise;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ExerciseTest
{
  public class Tests
  {
    string target = "../../../";
    string current = Directory.GetCurrentDirectory();

    [SetUp]
    public void Init()
    {
      Directory.SetCurrentDirectory(target);
    }

    [TearDown]
    public void End()
    {
      Directory.SetCurrentDirectory(current);
    }

    [Test]
    public void StandardSensorShouldWork()
    {
      StandardSensor ten = new StandardSensor(10);
      Assert.AreEqual(true, ten.IsOn(), "StandardSensor should always be on!");
      Assert.AreEqual(10, ten.Read(), "StandardSensor should return its initial value with Read!");
      ten.SetOff();
      Assert.AreEqual(true, ten.IsOn(), "StandardSensor should always be on!");
    }

    [Test]
    public void TemperatureSensorShouldWork()
    {
      TemperatureSensor temperatureSensor = new TemperatureSensor();
      Assert.AreEqual(false, temperatureSensor.IsOn(), "TemperatureSensor should start off!");
      temperatureSensor.SetOn();
      Assert.AreEqual(true, temperatureSensor.IsOn(), "TemperatureSensor should turn on with SetOn()!");
      temperatureSensor.SetOff();
      Assert.AreEqual(false, temperatureSensor.IsOn(), "TemperatureSensor should turn off with SetOff()!");
      Assert.Throws<InvalidOperationException>(() => temperatureSensor.Read(), "TemperatureSensor should throw an InvalidOperationException if Read when off!");
    }

  }
}
