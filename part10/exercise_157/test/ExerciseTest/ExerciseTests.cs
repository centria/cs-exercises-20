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
      Student first = new Student("jamo");
      Student second = new Student("jamo1");
      Assert.AreEqual(-1, first.CompareTo(second), "The example should work as such!");
    }

    [Test]
    public void EqualNamesShouldWork()
    {
      Student first = new Student("jamo1");
      Student second = new Student("jamo1");
      Assert.AreEqual(0, first.CompareTo(second), "Same names should return 0");
    }

    [Test]
    public void OtherWayNamesShouldWork()
    {
      Student first = new Student("jamo1");
      Student second = new Student("jamo");
      Assert.AreEqual(1, first.CompareTo(second), "Example other way should return 1");
    }

    [Test]
    public void LeevingsShouldWork()
    {
      Student first = new Student("Jenna Elli-Noora Alexandra Jurvanen");
      Student second = new Student("Pikku Myy");
      Assert.AreEqual(-1, first.CompareTo(second), "Jenna Elli-Noora Alexandra Jurvanen should be before Pikku Myy");
    }

    [Test]
    public void LeevingsAlteredShouldWork()
    {
      Student first = new Student("Jenna Elli-Noora Alexandra Jurvanen");
      Student second = new Student("Jenna Elli-Noora Alexandra Jurvanen");
      Assert.AreEqual(0, first.CompareTo(second), "Same names should return 0");
    }

    [Test]
    public void NullShouldWork()
    {
      Student first = new Student(null);
      Student second = new Student("Jenna Elli-Noora Alexandra Jurvanen");
      Assert.AreEqual(1, second.CompareTo(first), "Null should always be first");
    }

  }
}
