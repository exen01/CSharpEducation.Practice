namespace Practice7.Task5;

public class Matrix
{
  public int[,] Data { get; set; }

  public Matrix(int[,] data)
  {
    Data = data;
  }

  public int this[int row, int column]
  {
    get => Data[row, column];
    set => Data[row, column] = value;
  }
}