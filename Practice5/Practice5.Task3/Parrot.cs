namespace Practice5.Task3
{
  internal class Parrot : Animal
  {
    public string Color { get; set; }

    public Parrot(string name, int age, string color) : base(name, age)
    {
      Color = color;
    }

    public new void MakeSound()
    {
      Console.WriteLine("Parrot is talking");
    }

    public void MakeSound(string words)
    {
      Console.WriteLine(words);
    }
  }
}
