namespace Practice7.Task2;

public class Person : ICloneable
{
  public string Name { get; set; }
  public int Age { get; set; }

  public Person(string name, int age)
  {
    Name = name;
    Age = age;
  }

  public object Clone() => new Person(Name, Age);
}