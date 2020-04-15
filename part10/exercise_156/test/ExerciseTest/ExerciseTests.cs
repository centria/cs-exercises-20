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
        List<Human> humans = new List<Human>();
        humans.Add(new Human("Merja", 500));
        humans.Add(new Human("Pertti", 80));
        humans.Add(new Human("Matti", 150000));
        humans.Sort();
        humans.ForEach(Console.WriteLine);
        Console.SetOut(stdout);
        string example = "Matti 150000\nMerja 500\nPertti 80\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The example should work as such!");
      }
    }

    [Test]
    public void OtherPeopleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        List<Human> humans = new List<Human>();
        humans.Add(new Human("Marja", 500));
        humans.Add(new Human("Perttu", 800));
        humans.Add(new Human("Matti", 1500000));
        humans.Sort();
        humans.ForEach(Console.WriteLine);
        Console.SetOut(stdout);
        string example = "Matti 1500000\nPerttu 800\nMarja 500\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The CompareTo should work on other people, too!");
      }
    }


    [Test]
    public void ShouldWorkOnMultiplePeople()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        List<Human> humans = new List<Human>();
        humans.Add(new Human("Merja", 500));
        humans.Add(new Human("Pertti", 80));
        humans.Add(new Human("Matti", 150000));
        humans.Add(new Human("Marja", 500));
        humans.Add(new Human("Perttu", 800));
        humans.Add(new Human("Matti", 1500000));
        humans.Sort();
        humans.ForEach(Console.WriteLine);
        Console.SetOut(stdout);
        string example = "Matti 1500000\nMatti 150000\nPerttu 800\nMerja 500\nMarja 500\nPertti 80\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The CompareTo should work on other people, too!");
      }
    }


  }
}
