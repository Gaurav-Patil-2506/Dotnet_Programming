/*Write class Company with following members:
string name; string address;
LinkedList empList;
double salaryExpense; (Per month)

Provide following functionality:
Default constructor
Parameterized constructor
Properties: Name, Address, EmpList, SalaryExpense.

Accept () method to accept data from console.
Print () method to print data to console.
CalculateSalaryExpense() method to calculate salary expense per month.

 
public void AddEmployee(Employee e);
public bool RemoveEmployee(int id);
public LinkedListNode<Employee> FindEmployee(int id);
public override string ToString();
public void PrintEmployees();
 */

using Assignment_8;

namespace Assignment_12
{

    class Company
    {
        private string _name;
        private string _address;
        private LinkedList<Employee> _empList;
        private double _salaryExpense;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public LinkedList<Employee> EmpList
        {
            get { return _empList; }
            set { _empList = value; }
        }

        public double SalaryExpense
        {
            get { return _salaryExpense; }
            set { _salaryExpense = value; }
        }

        //default constructor
        public Company()
        {
            this._empList = new LinkedList<Employee>();
        }

        //parameterized constructor
        public Company(string name, string address, LinkedList<Employee> empList)
        {
            this._name = name;
            this._address = address;
            this._empList = empList;

        }

        public Company(string name, string address)
        {
            this._name = name;
            this._address = address;

        }

        public void Accept()
        {
            Console.WriteLine("Enter Company Name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Company Address: ");
            Address = Console.ReadLine();
            Console.WriteLine();
        }

        public void Print()
        {
            Console.WriteLine("Company Name: " + Name);
            Console.WriteLine("Company Address: " + Address);
            Console.WriteLine();
        }

        public void CalculateSalaryExpense()
        {
            double total = 0;
            foreach (Employee e in _empList)
            {
                total += e.Salary;
            }
            SalaryExpense = total;
        }

        public void AddEmployee(Employee e)
        {
            this._empList.AddLast(e);
        }

        public bool RemoveEmployee(int id)
        {
            LinkedListNode<Employee> node = FindEmployee(id);
            if (node != null)
            {
                this._empList.Remove(node);
                return true;
            }
            return false;
        }

        public LinkedListNode<Employee> FindEmployee(int id)
        {
            foreach (Employee e in _empList)
            {
                if (e.Id == id)
                {
                    return this._empList.Find(e);
                }
            }
            return null;
        }

        public override string ToString()
        {
            return "Company Name: " + Name + "\nCompany Address: " + Address + "\nSalary Expense: " + SalaryExpense;
        }

        public void PrintEmployees()
        {
            foreach (Employee e in _empList)
            {
                Console.WriteLine(e);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Company company = new Company();
            company.Accept();
            company.Print();

            Employee emp1 = new Employee(100000, DepartmentType.Finance, "Manager");
            company.AddEmployee(emp1);
            Employee emp2 = new Employee(200000, DepartmentType.IT, "Senior Developer");
            company.AddEmployee(emp2);
            Employee emp3 = new Employee(300000, DepartmentType.HR, "Human Resource");
            company.AddEmployee(emp3);
            Employee emp4 = new Employee(400000, DepartmentType.Marketing, "Marketing Head");
            company.AddEmployee(emp4);


            company.CalculateSalaryExpense();

            Console.WriteLine("\nPrinting the employees list");
            company.PrintEmployees();

            company.RemoveEmployee(3);

            Console.WriteLine("\nPrinting the employees list after removing an employee");
            company.PrintEmployees();
        }
    }
}
