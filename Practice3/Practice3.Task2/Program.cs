namespace Practice3.Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kirill", 22);
            student.AvgScore = 5;
            student.PrintStudent();
        }
    }
}
