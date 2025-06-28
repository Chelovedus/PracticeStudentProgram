using System;

namespace StudentAppPractice
{
    public class Student
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public double AverageGrade { get; private set; }
        public string StudentId { get; private set; }

        public Student(string name, int age, double averageGrade, string studentId)
        {
            Name = name;
            Age = age;
            AverageGrade = averageGrade;
            StudentId = studentId;
        }

        public void SetName(string name) => Name = name;
        public void SetAge(int age) => Age = age;
        public void SetAverageGrade(double averageGrade) => AverageGrade = averageGrade;
        public void SetStudentId(string studentId) => StudentId = studentId;

        public void DisplayInfo()
        {
            Console.WriteLine("Информация о студенте:");
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Возраст: {Age}");
            Console.WriteLine($"Средний балл: {AverageGrade}");
            Console.WriteLine($"Идентификатор: {StudentId}");
            Console.WriteLine($"Успеваемость: {GetPerformance()}");
            Console.WriteLine();
        }

        public string GetPerformance()
        {
            if (AverageGrade > 8) return "Отлично";
            if (AverageGrade >= 6) return "Хорошо";
            if (AverageGrade >= 4) return "Удовлетворительно";
            return "Неудовлетворительно";
        }

        public static void DisplayHeaderProgram()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("Студенческая информационная система");
            Console.WriteLine("===================================");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Student.DisplayHeaderProgram();
            var students = new List<Student>
            {
                new Student("Сорокин Роман", 20, 8.5, "Student001"),
                new Student("Кирюшин Матвей", 19, 5.8, "Student002"),
                new Student("Паршенин Владислав", 20, 9.3, "Student003")
            };

            foreach (var student in students)
            {
                student.DisplayInfo();
            }

            Console.WriteLine("Нажмите Enter для выхода...");
            Console.ReadLine();
        }
    }
}
