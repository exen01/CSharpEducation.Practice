using System.Collections;

namespace Practice7.Task4;

public class MyList : IEnumerable
{
  public List<int> Items { get; set; }

  public MyList(List<int> items)
  {
    Items = items;
  }

  public IEnumerator GetEnumerator()
  {
    return Items.GetEnumerator();
  }
}