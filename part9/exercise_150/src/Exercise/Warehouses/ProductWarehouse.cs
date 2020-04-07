namespace Exercise
{
  public class ProductWarehouse : Warehouse
  {

    public string productName;

    public ProductWarehouse(string productName, int capacity) : base(capacity)
    {

    }

    public override string ToString()
    {
      return "";
    }
  }
}