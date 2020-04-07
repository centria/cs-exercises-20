namespace Exercise
{
  public class ProductWarehouseWithHistory : ProductWarehouse
  {
    public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance) : base(productName, capacity)
    {

    }

    public string History()
    {
      return "";
    }

    new public void AddToWarehouse(int amount)
    {

    }

    new public int TakeFromWarehouse(int amount)
    {
      return 0;
    }
  }
}