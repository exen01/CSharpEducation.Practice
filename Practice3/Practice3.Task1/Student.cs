namespace Practice3.Task1
{
    internal class Student
    {
        private string name;
        private int age;

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"Студент {this.name}, возраст {this.age}");
        }
    }
}
