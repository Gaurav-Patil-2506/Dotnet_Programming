/*Create a reference of Student’s array in Main. Write a function CreateArray() to
allocate the array as per user’s requirement. Pass it to a function AcceptInfo() to
accept student information. Print the array using PrintInfo() function.Also write a
function ReverseArray() that reverse the array into a new array.Reprint the
modified array in Main.
Note: Do not return array from the function. All four functions mentioned above
should be static functions in Main()’s class*/

using System;

namespace Assignment_5
{

    class Student
    {
        private int _rollno;
        private string _name;
        private string _course;
        public int RollNo
        {
            get { return _rollno; }
            set { _rollno = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Course
        {
            get { return _course; }
            set { _course = value; }
        }

        public Student(int rollno, string name, string course)
        {
            _rollno = rollno;
            _name = name;
            _course = course;
        }

        public Student()
        {

        }

        public void Display()
        {
            Console.WriteLine($"Roll No: {_rollno}");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Course: {_course}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students:");
            int n = Convert.ToInt32(Console.ReadLine());

            Student[] students = CreateArray(n);
            AcceptInfo(students);
            Console.WriteLine();
            PrintInfo(students);
            Console.WriteLine();

            Student[] reversedArray = ReverseArray(students);
            PrintInfo(reversedArray);
        }

        static Student[] CreateArray(int n)
        {
            Student[] students = new Student[n];
            return students;
        }

        static void AcceptInfo(Student[] students)
        {

            for (int i = 0; i < students.Length; i++)
            {
                // create object of student, accept info and store in array
                students[i] = new Student();
                Console.WriteLine("Enter Roll No:");
                students[i].RollNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name:");
                students[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Course:");
                students[i].Course = Console.ReadLine();
                Console.WriteLine();
            }
        }

        static void PrintInfo(Student[] students)
        {
            Console.WriteLine("Students' IDs:");
            foreach (Student student in students)
            {
                student.Display();
            }
        }

        static Student[] ReverseArray(Student[] students)
        {
            Student[] reversedArray = new Student[students.Length];
            for (int i = 0; i < students.Length; i++)
            {
                reversedArray[i] = students[students.Length - 1 - i];
            }
            return reversedArray;
        }
    }
}