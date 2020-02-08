using System;
using System.IO;
using exercise_103;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace ProgramTests
{
  [TestFixture]
  public class TestProgram
  {

    [Test]
    public void TestToStringBond() {
      Agent bond = new Agent("James", "Bond");

      Assert.AreEqual("My name is Bond. James Bond.", bond.ToString(), "Check the correct spelling!");
    }

    [Test]
    public void TestToStringBourne() {
      Agent bourne = new Agent("Jason", "Bourne");

      Assert.AreEqual("My name is Bourne. Jason Bourne.", bourne.ToString(), "Check the correct spelling!");
    }

        [Test]
    public void TestToStringDoctor() {
      Agent bourne = new Agent("Dr.", "Evil");

      Assert.AreEqual("My name is Evil. Dr. Evil.", bourne.ToString(), "Check the correct spelling!");
    }

  }
}
