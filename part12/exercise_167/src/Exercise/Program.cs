namespace Exercise
{
  // using something...

  public class Program
  {
    public static void Main(string[] args)
    {

      List<int> integerList = new List<int>();
      List<string> stringList = new List<string>();

      string str = "This needs a using!";
      string another = "This does not need using!";
      stringList.Add(str);
      stringList.Add(another);

      Regex rgx = new Regex("needs");

      foreach (string sentence in stringList) {
        if (rgx.IsMatch(sentence)) {
          Console.WriteLine(sentence);
        }
      }

      Random rnd = new Random();
      for (int i = 0; i < 1000; i++)
      {
        integerList.Add(rnd.Next(1, 10001));
      }
      int largest = integerList.Max();
      int smallest = integerList.Min();
      Console.WriteLine(largest);
      Console.WriteLine(smallest);
    }
  }
}
