namespace Practice3._2.Task2
{
  using Practice3._2.Task1.MathLib;
  using Practice3._2.Task3.PersonLib;

  internal class Program
  {
    static void Main(string[] args)
    {
      MathHelper mathHelper = new MathHelper();
      int a = 5;
      int b = 10;

      Console.WriteLine(mathHelper.Addition(a, b));
      Console.WriteLine(mathHelper.Subtraction(a, b));
      Console.WriteLine(mathHelper.Division(a, b));
      Console.WriteLine(mathHelper.Multiplication(a, b));

      Person person = new Person("Kirill", 22);
      person.Print();

      Person person1 = new Person("Some name", 33);
      person1.Print();
    }
  }
}
