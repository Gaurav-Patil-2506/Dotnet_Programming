/*Write a class Supervisor with following members:
int subbordinates; (Number of assistants)

Provide following functionality:
Default constructor
Parameterized constructor
Properties: Subbordinates
Accept() method to accept data from console.
Print() method to print data to console.
string ToString(); method to return data of object in string format

Hint: class must be inherited from Employee class so that designation is fixed i.e.
    “Supervisor”*/

using Assignment_8;

namespace Assignment_10
{
    class Supervisor : Employee
    {
        private int subbordinates;

        public int Subbordinates
        {
            get { return subbordinates; }
            set { subbordinates = value; }
        }

        //default constructor
        public Supervisor()
        {
            Designation = "Supervisor";
        }

        //parameterized constructor
        public Supervisor(int subbordinates)
        {
            Designation = "Supervisor";
            Subbordinates = subbordinates;
        }

        //override the Accept method of base class in which the designation is fixed as "Supervisor"
        public override void Accept()
        {
            Console.WriteLine("Enter salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Designation = "Supervisor";
            Console.WriteLine("Enter department: ");
            Console.WriteLine("HR = 1");
            Console.WriteLine("IT = 2");
            Console.WriteLine("Finance = 3");
            Console.WriteLine("Marketing = 4");
            Dept = (DepartmentType)Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number of Subbordinates: ");
            Subbordinates = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Department: " + Dept);
            Console.WriteLine("Number of Subbordinates: " + Subbordinates);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Supervisor supervisor = new Supervisor();
            supervisor.Accept();
            supervisor.Print();
        }
    }
}
