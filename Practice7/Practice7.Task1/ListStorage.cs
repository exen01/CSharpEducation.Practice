namespace Practice7.Task1;

public class ListStorage<T> : IStorage<T>
{
  private readonly List<T> _list;

  public ListStorage(List<T> list)
  {
    _list = list;
  }

  public void Add(T item)
  {
    _list.Add(item);
  }

  public T Get(int index)
  {
    return _list[index];
  }

  public int Count => _list.Count;
}