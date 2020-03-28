namespace Exercise
{
  public class Book
  {
    public string name { get; set; }
    public string content { get; set; }
    public int published { get; set; }

    public Book(string name, int published, string content)
    {
      this.name = name;
      this.published = published;
      this.content = content;
    }

    public override string ToString()
    {
      return "Name: " + this.name + " (" + this.published + ")\n"
          + "Content: " + this.content;
    }

    public override bool Equals(object compared)
    {
      if (this == compared)
      {
        return true;
      }
      if ((compared == null) || !this.GetType().Equals(compared.GetType()))
      {
        return false;
      }
      else
      {
        Book comparedBook = (Book)compared;

        return
        this.name == comparedBook.name &&
        this.published == comparedBook.published &&
        this.content == comparedBook.content;
      }
    }

    public override int GetHashCode()
    {
      if (this.name == null)
      {
        return this.published;
      }
      return this.published + this.name.GetHashCode();
    }
  }
}
