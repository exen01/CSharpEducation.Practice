namespace Practice3.Task9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Kirill", 22);
            Console.WriteLine($"Студент {student.Name}");
            ChangeName(student);
            Console.WriteLine($"Студент {student.Name}");
        }

        static void ChangeName(Student student)
        {
            student.Name = "Аноним";
        }
    }
}
