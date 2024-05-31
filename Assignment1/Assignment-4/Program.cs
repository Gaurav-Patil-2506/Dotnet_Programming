using System.Runtime.CompilerServices;

namespace Assignment_4
{
    struct Student
    {
        private string _name;
        private bool _gender;
        private int _age;
        private int _std;
        private char _div;
        private double _marks;


        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public int Std
        {
            get { return _std; }
            set { _std = value; }
        }

        public char Div
        {
            get { return _div; }
            set { _div = value; }
        }

        public double Marks
        {
            get { return _marks; }
            set { _marks = value; }
        }

        public Student() : this("", true, 0, 0, ' ', 0.0)
        {

        }

        public Student(string name, bool gender, int age, int std, char div, double marks)

        {
            this._name = name;
            this._gender = gender;
            this._age = age;
            this._std = std;
            this._div = div;
            this._marks = marks;
        }

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Student Name: ");
            _name = Console.ReadLine();

            Console.WriteLine("Enter Student Gender (true for Male, false for Female): ");
            _gender = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Student Age: ");
            _age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Standard: ");
            _std = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student Division: ");
            _div = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Enter Student Marks: ");
            _marks = Convert.ToDouble(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Gender: " + (_gender ? "Male" : "Female"));
            Console.WriteLine("Age: " + _age);
            Console.WriteLine("Standard: " + _std);
            Console.WriteLine("Division: " + _div);
            Console.WriteLine("Marks: " + _marks);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.AcceptDetails();
            student.PrintDetails();
        }
    }
}
