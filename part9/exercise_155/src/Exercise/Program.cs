using System;

namespace Exercise
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Dog dog = new Dog();
      dog.Bark();
      dog.Eat();

      Dog fido = new Dog("Fido");
      fido.Bark();

      Console.WriteLine();

      Cat cat = new Cat();
      cat.Purr();
      cat.Eat();

      Cat garfield = new Cat("Garfield");
      garfield.Purr();

      Console.WriteLine();

      INoiseCapable noisyDog = new Dog();
      noisyDog.MakeNoise();

      INoiseCapable noisyCat = new Cat("Garfield");
      noisyCat.MakeNoise();

      Cat c = (Cat)noisyCat;
      c.Purr();
    }
  }
}
