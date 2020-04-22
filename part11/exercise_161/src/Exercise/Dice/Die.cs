namespace Exercise
{
  using System;
  public class Die
  {
    private Random random;
    private int numberOfFaces;

    public Die(int numberOfFaces)
    {
      this.random = new Random();
      // Initialize the value of numberOfFaces here
    }
    public int ThrowDie()
    {
      // generate a random number which may be any number
      // between one and the number of faces, and then return it
      return 0;
    }
  }
}