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
        A a = new A();
        B b = new B();
        C c = new C();

        a.APrint();
        b.BPrint();
        c.CPrint();
        Console.SetOut(stdout);
        string example = "A\nB\nC\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The example should work!");
      }
    }

    [Test]
    public void ExampleWithInheritanceShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        C c = new C();

        c.APrint();
        c.BPrint();
        c.CPrint();
        Console.SetOut(stdout);
        string example = "A\nB\nC\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "C should inherit B should inherit A, and C should be able to use APrint, BPrint and CPrint.");
      }
    }


  }
}