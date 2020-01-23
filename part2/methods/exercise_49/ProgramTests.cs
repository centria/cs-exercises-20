using System;
using System.IO;
using exercise_49;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestFindMethodName()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "public static void PrintPhrase").Count;

      Assert.AreEqual(1, count, "You were supposed to create your own method!");
    }

    [Test]
    public void TestFindMethodPrint()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "Console.WriteLine").Count;

      Assert.AreEqual(1, count, "You were supposed to use WriteLine inside the method!");
    }

        [Test]
    public void TestFindMethodCall()
    {
      string code = File.ReadAllText("../../../Program.cs");
      int count = Regex.Matches(code, "PrintPhrase()").Count;

      Assert.AreEqual(2, count, "You were supposed to call PrintPhrase(); from your Main!");
    }


    [Test]
    public void TestExercise49()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("In a hole in the ground there lived a method\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match for printing!");
      }

    }
  }
}