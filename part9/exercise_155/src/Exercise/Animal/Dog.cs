namespace Exercise
{
  using System;
  public class Dog : Animal, INoiseCapable
  {

    public Dog() : this("")
    {
    }

    public Dog(string name) : base(name)
    {
    }

    public void Bark()
    {
    }
    public void MakeNoise()
    {
    }

  }
}