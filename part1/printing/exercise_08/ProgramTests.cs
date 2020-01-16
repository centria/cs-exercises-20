using System;
using System.IO;
using exercise_08;
using NUnit.Framework;

namespace ProgramTests
{
    [TestFixture]
    public class TestProgram
    {
        [Test]
        public void TestExercise08()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var input = new StringReader("Ada");
                Console.SetIn(input);

                // Call student's code
                Program.Main(null);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.AreEqual("What is your name?\nHello Ada!\n", sw.ToString().Replace("\r\n", "\n"), "Remember to tell hello!");
            }
        }
    }
}