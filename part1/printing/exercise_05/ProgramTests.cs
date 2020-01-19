using System;
using System.IO;
using exercise_05;
using NUnit.Framework;

namespace ProgramTests
{
    [TestFixture]
    public class TestProgram
    {
        [Test]
        public void TestExercise05()
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
                Assert.AreEqual("Hello Ada Lovelace!\n", sw.ToString().Replace("\r\n", "\n"), "Check your code! The test requires exact match!");
            }
        }
    }
}