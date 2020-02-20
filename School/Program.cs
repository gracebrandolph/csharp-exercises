using System;
using System.Collections.Generic;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello World!");
        }
    }

    public class Student
    {

        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

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

        public Student(string name)
            : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        public void AddGrade(int courseCredits, double grade)
        {
            double qualityScore = Gpa * NumberOfCredits;
            qualityScore += grade * courseCredits;
            NumberOfCredits += courseCredits;
            Gpa = qualityScore / NumberOfCredits;
        }

        public string GetGradeLevel()
        {
            string gradeLevel = "freshman";

            if(NumberOfCredits >= 30 && NumberOfCredits <= 59)
            {
                gradeLevel = "sophomore";
            }
            else if (NumberOfCredits >= 60 && NumberOfCredits <= 89)
            {
                gradeLevel = "junior";
            }
            else if (NumberOfCredits >= 90)
            {
                gradeLevel = "senior";
            }

            return gradeLevel;
        }

        public override String ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(Object o)
        {

            if (o == this)
            {
                return true;
            }

            if (o == null)
            {
                return false;
            }

            if (o.GetType() != GetType())
            {
                return false;
            }

            Student studentObj = o as Student;
            return StudentId == studentObj.StudentId;
        }

        public override int GetHashCode()
        {
            return StudentId;
        }
    }

    public class Course
    {
        string Title { get; set; }
        string Instructor { get; set; }
        int CourseCode { get; set; }
        public List<Student> Students { get; private set; } = new List<Student>();

        public Course(string title, string instructor, int code)
        {
            Title = title;
            Instructor = instructor;
            CourseCode = code;
        }

        public void AddStudent(Student newStudent)
        {
            Students.Add(newStudent);
        }

        public List<Student> GetStudentList()
        {
            return Students;
        }

        public override String ToString()
        {
            string classList = "";
            classList = CourseCode + " " + Title + "\n" + Instructor + "\n";
            
            foreach(Student s in Students)
            {
                classList += s.Name + "\n";
            }

            return classList;
        }

        public override bool Equals(Object o)
        {

            if (o == this)
            {
                return true;
            }

            if (o == null)
            {
                return false;
            }

            if (o.GetType() != GetType())
            {
                return false;
            }

            Course courseObj = o as Course;
            return CourseCode == courseObj.CourseCode;
        }
        public override int GetHashCode()
        {
            return CourseCode;
        }
    }
}
