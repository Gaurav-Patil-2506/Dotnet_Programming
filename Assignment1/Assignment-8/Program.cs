/*
 
Write a class Employee with following members:
int id; (Auto Generated)
double salary; string designation;
enum DepartmentType dept;

Provide following functionality:
Default constructor
Parameterized constructor
Properties: Id, Salary, Designation, Dept

Accept() method to accept data from console.
Print() method to print data to console.
string ToString(); method to return data of object in string format.

Hint: class must be inherited from Person class. Use static count for auto
generating id.*/

using System.Transactions;
using Assignment_6;
using Assignment_7;

namespace Assignment_8
{

    public enum DepartmentType
    {
        //various departments in the company
        HR = 1,
        IT = 2,
        Finance = 3,
        Marketing = 4
    }

    public class Counter
    {
        private static int count = 0;
        private Counter()
        {

        }

        public static int GetCount()
        {
            count = count + 1;
            return count;   
        }
    }
    

    public class Employee : Person
    {
        //static field for auto generating id
        private int id;
        private double salary;
        private string designation;
        private DepartmentType dept;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public DepartmentType Dept
        {
            get { return dept; }
            set { dept = value; }
        }

        public Employee()
        {
           // id++;
           this.Id = Counter.GetCount();    
        }

        public Employee(double salary, string designation, DepartmentType dept) : this()
        {
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;

        }

        public Employee(double salary, DepartmentType dept, string designation)
        {
            this.salary = salary;
            this.designation = designation;
            this.dept = dept;
            // id++;
            this.Id = Counter.GetCount();
            //++id;
        }

        public virtual void Accept()
        {
            Console.WriteLine("Enter salary: ");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter designation: ");
            designation = Console.ReadLine();
            Console.WriteLine("Enter department: ");
            Console.WriteLine("HR = 1");
            Console.WriteLine("IT = 2");
            Console.WriteLine("Finance = 3");
            Console.WriteLine("Marketing = 4");
            dept = (DepartmentType)Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Print()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Salary: " + salary);
            Console.WriteLine("Designation: " + designation);
            Console.WriteLine("Department: " + dept);
        }

        public override string ToString()
        {
            return "ID: " + id + "\nSalary: " + salary + "\nDesignation: " + designation + "\nDepartment: " + dept;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            byte choice = 0;
            Employee employee = new Employee();

            do
            {
                Console.WriteLine("Enter the employees details:");
                employee.Accept();
                employee.Print();
                Console.WriteLine("\nDo you want to continue? (0/1)");
                choice = Convert.ToByte(Console.ReadLine());
            } 
            while (choice != 0);
            
        }
    }
}