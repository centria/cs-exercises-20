using System;
using System.IO;
using exercise_44;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {
    [Test]
    public void TestExercise44Test1()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "2",
                "7"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "2 is less than 7.\n";
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Check you compare the right way!");
      }
    }

    [Test]
    public void TestExercise44Test2()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "2",
                "1"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "2 is greater than 1.\n";
        
        // Assert
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Check you compare the right way!");
      }
    }

    [Test]
    public void TestExercise44Test3()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        var data = String.Join(Environment.NewLine, new[]
        {
                "3",
                "3"
                });

        Console.SetIn(new System.IO.StringReader(data));

        // Call student's code
        Program.Main(null);

        // Restore the original standard output.
        Console.SetOut(stdout);
        string comparison = "3 is equal to 3.\n";
        
        // Assert
        Assert.AreEqual(comparison, sw.ToString().Replace("\r\n", "\n"), "Check you are calculating the sum correctly!");
      }
    }


  }
}