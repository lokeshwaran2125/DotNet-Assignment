using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_constructor_
{
    class Student
    {
        //fields
        private string studentname;
        private int age;
        private string departments;
        private int marks;
        //constructor
        public Student(string name, int age, string departments, int marks)
        {
            studentname = name;
            StudentAge = age;
            StudentDepartments = departments;
            Studentmarks = marks;
        }
        //properties
        public string StudentName
        {
            get { return studentname; }
            set { studentname = value; }
        }
        public int StudentAge
        {
            get { return age; }
            set { age = value; }
        }
        public string StudentDepartments
        {
            get { return departments; }
            set { departments = value; }
        }
        public int Studentmarks
        {
            get { return marks; }
            set { marks = value; }
        }
        // method
        public void displaystudentdetails()
        {
            Console.WriteLine("Student Name: " + StudentName);
            Console.WriteLine("Student Age: " + StudentAge);
            Console.WriteLine("Student Departments: " + StudentDepartments);
            Console.WriteLine("Student Marks: " + Studentmarks);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("student details 1");
            Student details = new Student("loki", 21, "information technology", 85);
            details.displaystudentdetails();
            Console.WriteLine();
            Console.WriteLine("student details 2");
            Student details2 = new Student("sai", 21, "AIDS", 90);
            details2.displaystudentdetails();
            details2.Studentmarks = 95;

            Console.WriteLine("After Updating Marks:");
            Console.WriteLine("Marks: " + details2.Studentmarks);
        }
    }
}