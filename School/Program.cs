using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Student
    {
        private double gpa;
        public string Name { get; set; }
        public int StudentId { get; private set; }
        public int NumberOfCredits { get; set; }

        public Student(string name, int studentId,
                int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public double Gpa
        {
            get { return gpa; }
            internal set { gpa = value; }
        }

    }

    public class Course
    {
        string title { get; set; }
        string instructor { get; set; }
        public List<Student> Students { get; private set; } = new List<Student>();

        public Student(string name, int studentId,
                int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
    }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public double Gpa
        {
            get { return gpa; }
            internal set { gpa = value; }
        }

    }
}
