namespace Exercise
{
  public class OneItemBox : Box
  {
    public OneItemBox()
    {
    }

    public override void Add(Item item)
    {
    }


    public override bool IsInBox(Item item)
    {
      return false;
    }
  }
}