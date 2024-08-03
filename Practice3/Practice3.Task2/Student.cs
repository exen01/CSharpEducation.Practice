namespace Practice3.Task2
{
    internal class Student
    {
        private string name;
        private int age;
        private double avgScore;
        public double AvgScore
        {
            get { return avgScore; }
            set
            {
                if (value >= 0 && value <= 5)
                {
                    avgScore = value;
                }
                else
                {
                    throw new ArgumentException("Средний балл должен быть в диапазоне от 1 до 5");
                }
            }
        }

        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void PrintStudent()
        {
            Console.WriteLine($"Студент {name}, возраст {age}, средний балл {avgScore}");
        }

    }
}
