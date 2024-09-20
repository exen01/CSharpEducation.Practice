using System.Collections;

namespace Practice7.Task4;

public class MyDictionary : IEnumerator
{
  public Dictionary<string, int> Items { get; set; }
  private int _current = -1;

  public MyDictionary(Dictionary<string, int> items)
  {
    Items = items;
  }

  public bool MoveNext()
  {
    if (_current >= Items.Count - 1) return false;
    _current++;
    return true;
  }

  public void Reset() => _current = -1;

  public object? Current
  {
    get
    {
      if (_current == -1 || _current >= Items.Count)
      {
        throw new InvalidOperationException();
      }

      return Items.ElementAt(_current);
    }
  }
}