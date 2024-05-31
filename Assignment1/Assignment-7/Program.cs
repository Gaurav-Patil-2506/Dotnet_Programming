/*Write a class Person with following members:
string name; bool gender; Date birth;
string address;

Provide following functionality:
Default constructor
Parameterized constructor
Properties: Name, Gender, Birth, Address and Age(Read Only)
Accept() method to accept data from console.
Print() method to print data to console.
string ToString(); method to return data of object in string format.

Hint: Class will contain Date object for birth and Age will be calculated using
static method in Date class*/


using System;
using Assignment_6;

namespace Assignment_7
{

    public class Person
    {
        private string _name;
        private bool _gender;
        private Date _birth;
        private string _address;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public bool Gender
        {
            get { return _gender; }
            set
            {
                _gender = value;
            }
        }

        public Date Birth
        {
            get { return _birth; }
            set
            {
                if (!value.IsValid())
                    throw new Exception("Invalid birth date");
                _birth = value;
            }
        }

        public string Address
        {
            get { return _address; }
            set
            {
                _address = value;
            }
        }

        public int Age
        {
            get
            {
                int yearsDifference = Date.AgeCalculator(_birth);
                return yearsDifference;
            }
        }

        public Person()
        {
            this._name = "";
            this._gender = false;
            this._birth = new Date();
            this._address = "";
        }

        public Person(string name, bool gender, Date birth, string address)
        {
            this._name = name;
            this._gender = gender;
            this._birth = birth;
            this._address = address;
        }

        public void Accept()
        {
            Console.WriteLine("Enter name: ");
            this._name = Console.ReadLine();

            Console.WriteLine("Enter gender (true for Male, false for Female): ");
            this._gender = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter date of birth (dd mm yyyy): ");
            this._birth.AcceptDate();

            Console.WriteLine("Enter address: ");
            this._address = Console.ReadLine();
        }

        public void Print()
        {
            Console.WriteLine("Name: " + _name);
            Console.WriteLine("Gender: " + (_gender ? "Male" : "Female"));
            Console.WriteLine("Birth Date: " + _birth.ToString());
            Console.WriteLine("Address: " + _address);
        }

        public override string ToString()
        {
            return _name + ", " + (_gender ? "Male" : "Female") + ", " + _birth.ToString() + ", " + _address;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Accept();
            Console.WriteLine();
            person.Print();

            Console.WriteLine();
            Console.WriteLine("Calculating your age.....");
            Console.WriteLine("Your age is : " + person.Age);
            
        }
    }
}

