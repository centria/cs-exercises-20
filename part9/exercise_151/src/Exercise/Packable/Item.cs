namespace Exercise
{
  using System;
  public class Item
  {

    public string name { get; set; }
    public int weight { get; set; }
    public Item(string name, int weight)
    {
      this.name = name;
      this.weight = weight;
    }

    public Item(string name) : this(name, 0)
    {
    }

    public override bool Equals(object compared)
    {
      if (this == compared)
      {
        return true;
      }

      // if the compared object is null or not of type Item, the objects are not equal
      if ((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }
      else
      {
        // convert the object to a Item object
        Item comparedItem = (Item)compared;

        // if the values of the object variables are equal, the objects are, too
        return this.name == comparedItem.name;
      }
    }

    public override int GetHashCode()
    {
      return this.name.GetHashCode();
    }
  }
}