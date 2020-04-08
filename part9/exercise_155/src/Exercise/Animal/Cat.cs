namespace Exercise
{
  using System;
  public class Cat : Animal, INoiseCapable
  {

    public Cat() : this("")
    {
    }

    public Cat(string name) : base(name)
    {
    }

    public void Purr()
    {
    }
    public void MakeNoise()
    {
    }

  }
}