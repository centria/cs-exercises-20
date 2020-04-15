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
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        Checker check = new Checker();

        Console.WriteLine(check.DayOfWeek("tue"));
        Console.WriteLine(check.DayOfWeek("tues"));

        Console.WriteLine(check.AllVowels("aeiouaaeeioiouoiaoueaiaeiou"));
        Console.WriteLine(check.AllVowels("aeiouaaeeioiouoKiaoueaiaeiou"));

        Console.WriteLine(check.TimeOfDay("23:23:59"));
        Console.WriteLine(check.TimeOfDay("00:00:60"));
        Console.SetOut(stdout);
        string comparison = "True\nFalse\nTrue\nFalse\nTrue\nFalse\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "The example should work as such!");
      }
    }


    [Test]
    public void FlippedExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);
        Checker check = new Checker();
        Console.WriteLine(check.DayOfWeek("tues"));
        Console.WriteLine(check.DayOfWeek("tue"));
        Console.WriteLine(check.AllVowels("aeiouaaeeioiouoKiaoueaiaeiou"));
        Console.WriteLine(check.AllVowels("aeiouaaeeioiouoiaoueaiaeiou"));
        Console.WriteLine(check.TimeOfDay("00:00:60"));
        Console.WriteLine(check.TimeOfDay("23:23:59"));
        Console.SetOut(stdout);
        string comparison = "False\nTrue\nFalse\nTrue\nFalse\nTrue\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "The example lines should work regardless of order");
      }
    }

    [Test]
    public void TestTimesOfDay()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);
        Checker check = new Checker();
        Console.WriteLine(check.TimeOfDay("23:59:59"));
        Console.WriteLine(check.TimeOfDay("00:00:00"));
        Console.WriteLine(check.TimeOfDay("00:00:01"));
        Console.WriteLine(check.TimeOfDay("12:00:00"));
        Console.WriteLine(check.TimeOfDay("15:47:47"));
        Console.WriteLine(check.TimeOfDay("24:00:00"));
        Console.SetOut(stdout);
        string comparison = "True\nTrue\nTrue\nTrue\nTrue\nFalse\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "The clock should work as a real clock");
      }
    }

    [Test]
    public void TestDaysOfWeek()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);
        Checker check = new Checker();
        Console.WriteLine(check.DayOfWeek("abc"));
        Console.WriteLine(check.DayOfWeek("tue"));
        Console.WriteLine(check.DayOfWeek("wed"));
        Console.WriteLine(check.DayOfWeek("thu"));
        Console.WriteLine(check.DayOfWeek("mon"));
        Console.WriteLine(check.DayOfWeek("fri"));
        Console.WriteLine(check.DayOfWeek("sun"));
        Console.WriteLine(check.DayOfWeek("sat"));

        Console.SetOut(stdout);
        string comparison = "False\nTrue\nTrue\nTrue\nTrue\nTrue\nTrue\nTrue\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "The weekdays should only be three letters long");
      }
    }

    [Test]
    public void TestWovels()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);
        Checker check = new Checker();

        Console.WriteLine(check.AllVowels("aeiouaaeeioiouoaaaaaaaaiaoueaiaeiou"));
        Console.WriteLine(check.AllVowels("aeiouaaeeioiouoiaoueaiaeiou"));
        Console.WriteLine(check.AllVowels("e"));
        Console.WriteLine(check.AllVowels("a"));
        Console.WriteLine(check.AllVowels("oi"));
        Console.WriteLine(check.AllVowels("u"));
        Console.WriteLine(check.AllVowels("eaaaa"));
        Console.WriteLine(check.AllVowels("aaaee"));
        Console.WriteLine(check.AllVowels("yyy"));
        Console.WriteLine(check.AllVowels("åå"));
        Console.WriteLine(check.AllVowels("ö"));
        Console.WriteLine(check.AllVowels("ä"));
        Console.SetOut(stdout);
        string comparison = "True\nTrue\nTrue\nTrue\nTrue\nTrue\nTrue\nTrue\nFalse\nFalse\nFalse\nFalse\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Only the wovels mentioned in the exercise should work");
      }
    }

    [Test]
    public void TestConsonants()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);
        Checker check = new Checker();

        Console.WriteLine(check.AllVowels("k"));
        Console.WriteLine(check.AllVowels("ka"));
        Console.WriteLine(check.AllVowels("ek"));
        Console.WriteLine(check.AllVowels("ask"));
        Console.WriteLine(check.AllVowels("oink"));
        Console.WriteLine(check.AllVowels("ut"));
        Console.WriteLine(check.AllVowels("eaaaa"));
        Console.WriteLine(check.AllVowels("aaaee"));
        Console.SetOut(stdout);
        string comparison = "False\nFalse\nFalse\nFalse\nFalse\nFalse\nTrue\nTrue\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Consonants are not vowels");
      }
    }
  }
}
