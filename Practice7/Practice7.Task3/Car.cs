namespace Practice7.Task3;

public class Car : IComparer<Car>
{
  public string Make { get; set; }
  public string Model { get; set; }

  public Car(string make, string model)
  {
    Make = make;
    Model = model;
  }

  public int Compare(Car? x, Car? y)
  {
    if (ReferenceEquals(x, y)) return 0;
    if (y is null) return 1;
    if (x is null) return -1;
    var makeComparison = string.Compare(x.Make, y.Make, StringComparison.Ordinal);
    if (makeComparison != 0) return makeComparison;
    return string.Compare(x.Model, y.Model, StringComparison.Ordinal);
  }
}