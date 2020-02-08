using System;
using System.IO;
using exercise_105;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestExampleCount()
    {
      Statistics statistics = new Statistics();
      statistics.AddNumber(3);
      statistics.AddNumber(5);
      statistics.AddNumber(1);
      statistics.AddNumber(2);

      Assert.AreEqual(4, statistics.count, "Remember to raise the count!");
    }

    [Test]
    public void TestExampleSum()
    {
      Statistics statistics = new Statistics();
      statistics.AddNumber(3);
      statistics.AddNumber(5);
      statistics.AddNumber(1);
      statistics.AddNumber(2);

      Assert.AreEqual(11, statistics.sum, "Remember to raise the sum!");
    }

    [Test]
    public void TestLargerCount()
    {
      Statistics statistics = new Statistics();
      statistics.AddNumber(37);
      statistics.AddNumber(-45);
      statistics.AddNumber(21);
      statistics.AddNumber(444);
      statistics.AddNumber(444);
      statistics.AddNumber(444);
      statistics.AddNumber(444);
      statistics.AddNumber(444);
      statistics.AddNumber(444);

      Assert.AreEqual(9, statistics.count, "Remember to raise the count!");
    }

        [Test]
    public void TestLargerSum()
    {
      Statistics statistics = new Statistics();
      statistics.AddNumber(37);
      statistics.AddNumber(-45);
      statistics.AddNumber(21);
      statistics.AddNumber(444);
      statistics.AddNumber(444);
      statistics.AddNumber(444);
      statistics.AddNumber(444);
      statistics.AddNumber(444);
      statistics.AddNumber(444);

      Assert.AreEqual(2677, statistics.sum, "Remember to raise the sum!");
    }

  }
}
