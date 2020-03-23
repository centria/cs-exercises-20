namespace Calculators
{
  public class Calculator
  {

    public int value { get; private set; }

    public Calculator()
    {
      this.value = 0;
    }

    public void Sum(int number)
    {
      this.value = this.value + number;
    }

    public void Substract(int number)
    {
      this.value -= number;
    }
  }
}
