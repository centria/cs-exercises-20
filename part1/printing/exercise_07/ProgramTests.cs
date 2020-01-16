using System;
using System.IO;
using exercise_07;
using NUnit.Framework;

namespace ProgramTests
{
    [TestFixture]
    public class TestProgram
    {
        [Test]
        public void TestExercise07()
        {
            using (StringWriter sw = new StringWriter())
            {
                // Save a reference to the standard output.
                TextWriter stdout = Console.Out;

                // Redirect standard output to variable.
                Console.SetOut(sw);

                var input = new StringReader("Are you printing the string?");
                Console.SetIn(input);

                // Call student's code
                Program.Main(null);

                // Restore the original standard output.
                Console.SetOut(stdout);

                // Assert
                Assert.AreEqual("Give input!\nAre you printing the string?\nAre you printing the string?\nAre you printing the string?\n", sw.ToString().Replace("\r\n", "\n"), "Remember to ask for input and print it!");
            }
        }
    }
}