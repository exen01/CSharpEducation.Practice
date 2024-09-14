namespace Practice7.Task1;

class Program
{
  static void Main(string[] args)
  {
    ListStorage<int> intList = new ListStorage<int>([1, 2, 3, 4, 5, 6, 7, 8, 9]);

    Console.WriteLine(intList.Count);
    intList.Add(10);
    Console.WriteLine(intList.Get(9));
  }
}