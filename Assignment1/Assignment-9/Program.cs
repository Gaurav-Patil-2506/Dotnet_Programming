/*Write a class Manager with following members:
double bonus;

Provide following functionality:
Default constructor
Parameterized constructor
Properties: Bonus
Accept() method to accept data from console.
Print() method to print data to console.
string ToString(); method to return data of object in string format.

Hint: class must be inherited from Employee class so that designation is fixed i.e.“Manager”.*/


using Assignment_7;
using Assignment_8;

namespace Assignment_9
{
    class Manager : Employee
    {
        private double bonus;

        public double Bonus
        {
            get { return bonus; }
            set { bonus = value; }
        }

        //defualt constructor
        public Manager()
        {
            Designation = "Manager";
        }

        //parameterized constructor
        public Manager(double bonus)
        {
            Designation = "Manager";
            Bonus = bonus;
        }

        //override the Accept method of base class in which the designation is fixed as "Manager"
        public override void Accept()
        {
            Console.WriteLine("Enter salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Designation = "Manager";
            Console.WriteLine("Enter department: ");
            Console.WriteLine("HR = 1");
            Console.WriteLine("IT = 2");
            Console.WriteLine("Finance = 3");
            Console.WriteLine("Marketing = 4");
            Dept = (DepartmentType)Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Bonus: ");
            Bonus = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Department: " + Dept);
            Console.WriteLine("Bonus: " + Bonus);
            Console.WriteLine();
        }

        public override string ToString()
        {
            return base.ToString() + "Bonus: " + Bonus;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Manager manager = new Manager();
            manager.Accept();
            manager.Print();
        }

    }
}
