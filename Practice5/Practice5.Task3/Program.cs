namespace Practice5.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Animal animal = new Animal();
      Dog dog = new Dog();
      Cat cat = new Cat();

      animal.MakeSound();
      dog.MakeSound();
      cat.MakeSound();
    }
  }
}
