namespace Practice7.Task5;

class Program
{
  static void Main(string[] args)
  {
    Matrix matrix = new Matrix(new int[,]
    {
      { 1, 2, 3 },
      { 4, 5, 6 }
    });

    Console.WriteLine(matrix[0, 0]);
    matrix[0, 0] = 1000;
    Console.WriteLine(matrix[0, 0]);
  }
}