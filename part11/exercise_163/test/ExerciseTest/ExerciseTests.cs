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
    public void TestTooOld()
    {
      Assert.Throws<ArgumentException>(() => new Person("Matthew", 140), "Age outside range should throw an ArgumentException!");
    }

    [Test]
    public void TestTooYoung()
    {
      Assert.Throws<ArgumentException>(() => new Person("Matthew", -140), "Age outside range should throw an ArgumentException!");
    }

    [Test]
    public void TestNullForName()
    {
      Assert.Throws<ArgumentException>(() => new Person(null, 40), "Name null should throw an ArgumentException!");
    }

    [Test]
    public void TestEmptyName()
    {
      Assert.Throws<ArgumentException>(() => new Person("", 40), "Empty should throw an ArgumentException!");
    }

    [Test]
    public void TestTooLongName()
    {
      Assert.Throws<ArgumentException>(() => new Person("Matthew Michael Bartholomew, Son of Matthew Jameson Junior Junior", 40), "Empty should throw an ArgumentException!");
    }

  }
}
