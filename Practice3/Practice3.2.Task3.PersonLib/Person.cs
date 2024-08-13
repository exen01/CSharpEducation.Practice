namespace Practice3._2.Task3.PersonLib
{
  public class Person
  {
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
      Name = name;
      Age = age;
    }

    public void Print()
    {
      Console.WriteLine($"Имя: {Name}, возраст: {Age}");
    }
  }
}
