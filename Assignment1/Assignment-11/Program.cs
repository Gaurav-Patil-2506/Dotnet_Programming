/*Write a class WageEmp(Contract basis employee) with following members:
int hours; int rate; (Per hour basis)

Provide following functionality:
Default constructor
Parameterized constructor
Properties: Hours, Rate
Accept() method to accept data from console.
Print() method to print data to console.

string ToString(); method to return data of object in string format.
Hint: class must be inherited from Employee class so that designation is fixed i.e. “Wage”*/

using Assignment_8;

namespace Assignment_11
{

    class WageEmp : Employee
    {
        private int hours;
        private int rate;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Rate
        {
            get { return rate; }
            set { rate = value; }
        }

        //default constructor
        public WageEmp()
        {
            Designation = "Wage";
        }

        //parameterized constructor
        public WageEmp(int hours, int rate)
        {
            Designation = "Wage";
            Hours = hours;
            Rate = rate;
        }

        //override the Accept method of base class in which the designation is fixed as "Wage"
        public override void Accept()
        {
            Console.WriteLine("Enter salary: ");
            Salary = Convert.ToDouble(Console.ReadLine());
            Designation = "Wage";
            Console.WriteLine("Enter department: ");
            Console.WriteLine("HR = 1");
            Console.WriteLine("IT = 2");
            Console.WriteLine("Finance = 3");
            Console.WriteLine("Marketing = 4");
            Dept = (DepartmentType)Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Number of Hours: ");
            Hours = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Rate: ");
            Rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
        }

        public override void Print()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Salary: " + Salary);
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Department: " + Dept);
            Console.WriteLine("Hours: " + Hours);
            Console.WriteLine("Rate: " + Rate);
            Console.WriteLine("Earned income : Rs "+ hours*rate);
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            WageEmp wageEmp = new WageEmp();
            wageEmp.Accept();
            wageEmp.Print();
        }
    }
}
