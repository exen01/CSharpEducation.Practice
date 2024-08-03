namespace Practice3.Task9
{
    internal class Student
    {
        private string name;
        private int age;

        public string Name { get { return name; } set { name = value; } }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
