namespace Practice7.Task4;

class Program
{
  static void Main(string[] args)
  {
    MyList myList = new MyList([1,2,3,4,5,6]);
    foreach (var VARIABLE in myList)
    {
      Console.WriteLine(VARIABLE);
    }

    MyDictionary myDictionary = new MyDictionary(
      new Dictionary<string, int>
      {
        {"One", 1},
        {"Two", 2},
        {"Three", 3},
      });

    while (myDictionary.MoveNext())
    {
      Console.WriteLine(myDictionary.Current);
    }
  }
}