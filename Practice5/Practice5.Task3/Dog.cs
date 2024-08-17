namespace Practice5.Task3
{
  internal class Dog : Animal
  {
    public Dog(string name, int age) : base(name, age)
    {
      Console.WriteLine("Dog was created.");
    }

    public override void MakeSound()
    {
      Console.WriteLine("Woof!");
    }
  }
}
