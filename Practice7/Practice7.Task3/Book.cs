namespace Practice7.Task3;

public class Book: IComparable<Book> 
{
  public string Title { get; set; }
  public string Author { get; set; }
  
  public Book(string title, string author)
  {
    Title = title;
    Author = author;
  }

  public int CompareTo(Book? other)
  {
    var titleComparison = string.Compare(Title, other.Title, StringComparison.Ordinal);
    return titleComparison;
  }
}