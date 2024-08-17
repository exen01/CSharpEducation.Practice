namespace Practice5.Task3
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Animal animal = new Animal("A1", 10);
      Dog dog = new Dog("D1", 5);
      Cat cat = new Cat("C1", 3);
      Parrot parrot = new Parrot("P1", 2, "red");

      List<Animal> animals = [animal, cat, parrot, dog];

      foreach (var animalItem in animals)
      {
        if (animalItem is Parrot parrotItem)
        {
          parrot.MakeSound();
          parrotItem.MakeSound("some word");
        }
        else
        {
          animalItem.MakeSound();
        }
      }
    }
  }
}
