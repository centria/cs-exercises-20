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
        StorageFacility facility = new StorageFacility();
        facility.Add("a14", "ice skates");
        facility.Add("a14", "ice hockey stick");
        facility.Add("a14", "ice skates");

        facility.Add("f156", "rollerblades");
        facility.Add("f156", "rollerblades");

        facility.Add("g63", "six");
        facility.Add("g63", "pi");

        foreach (string unit in facility.StorageUnits())
        {
          Console.WriteLine(unit);
        }
        foreach (string item in facility.Contents("a14"))
        {
          Console.WriteLine(item);
        }
        foreach (string item in facility.Contents("f156"))
        {
          Console.WriteLine(item);
        }
        facility.Remove("f156", "rollerblades");
        foreach (string item in facility.Contents("f156"))
        {
          Console.WriteLine(item);
        }
        facility.Remove("f156", "rollerblades");
        foreach (string unit in facility.StorageUnits())
        {
          Console.WriteLine(unit);
        }
        Console.SetOut(stdout);
        string example = "a14\nf156\ng63\nice skates\nice hockey stick\nice skates\nrollerblades\nrollerblades\nrollerblades\na14\ng63\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The example should work!");
      }
    }

    [Test]
    public void AddShouldAddAndContentsShouldFindIt()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        StorageFacility facility = new StorageFacility();
        facility.Add("a14", "ice skates");
        foreach (string item in facility.Contents("a14"))
        {
          Console.WriteLine(item);
        }

        Console.SetOut(stdout);
        string example = "ice skates\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "Adding an item should add it to the list, and it should be found with Contents!!");
      }
    }

    [Test]
    public void AddShouldAddAndRemoveShouldRemoveOnlyOne()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        StorageFacility facility = new StorageFacility();
        facility.Add("a14", "ice skates");
        facility.Add("a14", "ice skates");
        facility.Remove("a14", "ice skates");
        foreach (string item in facility.Contents("a14"))
        {
          Console.WriteLine(item);
        }

        Console.SetOut(stdout);
        string example = "ice skates\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "Remove should only remove one item!");
      }
    }


  }
}