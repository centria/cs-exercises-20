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
    public void ExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
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
        Console.SetOut(stdout);
        string example = "3\n2\n1\n0\n0\n\n2\n1\n0\n0\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The example should work as such!");
      }
    }

    [Test]
    public void TripleTacoEatWorks()
    {
      using (StringWriter sw = new StringWriter())
      {
        TripleTacoBox trip = new TripleTacoBox();
        trip.Eat();
        Assert.AreEqual(2, trip.TacosRemaining(), "Eating a taco from Triple should reduce the amount by 1!");
      }
    }

    [Test]
    public void TripleTacoEatFourWorks()
    {
      using (StringWriter sw = new StringWriter())
      {
        TripleTacoBox trip = new TripleTacoBox();
        trip.Eat();
        trip.Eat();
        trip.Eat();
        trip.Eat();
        Assert.AreEqual(0, trip.TacosRemaining(), "Eating 4 tacos from Triple should reduce the amount by only 3!");
      }
    }

    [Test]
    public void HugeCustomShouldWork()
    {
      CustomTacoBox custom = new CustomTacoBox(20000);
      custom.Eat();
      Assert.AreEqual(19999, custom.TacosRemaining(), "Eating from CustomBox should reduce the amount of tacos by one!");
    }

    [Test]
    public void HugeCustomEatTooMuchShouldWork()
    {
      CustomTacoBox custom = new CustomTacoBox(20000);
      for (int i = 0; i < 100000; i++)
      {
        custom.Eat();
      }
      Assert.AreEqual(0, custom.TacosRemaining(), "Eating too many from CustomBox should reduce the amount of tacos to zero!");
    }

    [Test]
    public void ZeroCustomShouldWork()
    {
      CustomTacoBox custom = new CustomTacoBox(0);
      Assert.AreEqual(0, custom.TacosRemaining(), "Empty CustomBox should have zero tacos");
    }

        [Test]
    public void ZeroCustomEatShouldWork()
    {
      CustomTacoBox custom = new CustomTacoBox(0);
      custom.Eat();
      Assert.AreEqual(0, custom.TacosRemaining(), "Empty CustomBox should not have negative tacos after eating");
    }
  }

}
