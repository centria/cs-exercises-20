using System;
using System.IO;
using exercise_99;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {


    [Test]
    public void TestDecreasingCounterSection1()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        DecreasingCounter tester = new DecreasingCounter(3);
        tester.Decrement();
        tester.PrintValue();

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("value: 2\n", sw.ToString().Replace("\r\n", "\n"), "Section 1: Value should decrease by 1 with Decrement!");
      }
    }

    [Test]
    public void TestDecreasingCounterSection2()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        DecreasingCounter tester = new DecreasingCounter(3);
        tester.Decrement();
        tester.Decrement();
        tester.Decrement();
        tester.Decrement();
        tester.Decrement();
        tester.PrintValue();

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("value: 0\n", sw.ToString().Replace("\r\n", "\n"), "Section 2: Value should not go below 0!");
      }
    }

        [Test]
    public void TestDecreasingCounterSection3()
    {
      using (StringWriter sw = new StringWriter())
      {
        // Save a reference to the standard output.
        TextWriter stdout = Console.Out;

        // Redirect standard output to variable.
        Console.SetOut(sw);

        DecreasingCounter tester = new DecreasingCounter(3);
        tester.PrintValue();
        tester.Reset();
        tester.PrintValue();

        // Restore the original standard output.
        Console.SetOut(stdout);

        // Assert
        Assert.AreEqual("value: 3\nvalue: 0\n", sw.ToString().Replace("\r\n", "\n"), "Section 3: Reset should set the value to 0!");
      }
    }

  }
}
