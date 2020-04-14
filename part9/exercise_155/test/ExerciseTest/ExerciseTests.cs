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
    public void DogExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Dog dog = new Dog();
        Console.SetOut(sw);
        dog.Bark();
        dog.Eat();
        Dog fido = new Dog("Fido");
        fido.Bark();
        Console.SetOut(stdout);
        string example = "Dog barks\nDog eats\nFido barks\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The examples should work as such!");
      }
    }

    [Test]
    public void CatExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        Cat cat = new Cat();
        cat.Purr();
        cat.Eat();
        Cat garfield = new Cat("Garfield");
        garfield.Purr();
        Console.SetOut(stdout);
        string example = "Cat purrs\nCat eats\nGarfield purrs\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The examples should work as such!");
      }
    }

    [Test]
    public void NoisyExampleShouldWork()
    {
      using (StringWriter sw = new StringWriter())
      {
        TextWriter stdout = Console.Out;
        Console.SetOut(sw);
        INoiseCapable noisyDog = new Dog();
        noisyDog.MakeNoise();
        INoiseCapable noisyCat = new Cat("Garfield");
        noisyCat.MakeNoise();
        Cat c = (Cat)noisyCat;
        c.Purr();
        Console.SetOut(stdout);
        string example = "Dog barks\nGarfield purrs\nGarfield purrs\n";
        Assert.AreEqual(example, sw.ToString().Replace("\r\n", "\n"), "The examples should work as such!");
      }
    }

  }
}
