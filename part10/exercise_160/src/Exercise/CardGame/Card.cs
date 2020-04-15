namespace Exercise
{
  using System;
  public class Card : IComparable<Card>
  {
    public int value { get; }
    public Suit suit { get; }

    public Card(int value, Suit suit)
    {
      this.value = value;
      this.suit = suit;
    }

    public override string ToString()
    {
      return "";
    }

    public int CompareTo(Card another)
    {
      return 0;
    }
  }
}