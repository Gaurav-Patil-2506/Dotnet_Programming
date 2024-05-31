
/*
Write class Date with following members:
int day; int month; int year;

Provide following functionality:
Default constructor
Parameterized constructor
Properties: Day, Month and Year
AcceptDate() method to accept data from console.
PrintDate() method to print data to console.
bool IsValid(); method to check validity of date.
string ToString(); method to return data of object in string format.

Also provide a static member function that returns difference between two date
objects in number of years.
Overload “-” operator to perform the same job.
*/

using System;

namespace Assignment_6
{
    public class Date
    {
        
        private int _day;
        private int _month;
        private int _year;

        public int Day
        {
            get { return _day; }
            set
            {
                //accepting the date only it is between 1 and 31
                if (value < 1 || value > 31)
                    throw new Exception("Invalid day");
                _day = value;
            }
        }

        public int Month
        {
            get { return _month; }
            set
            {
                //accepting the month only it is between 1 and 12
                if (value < 1 || value > 12)
                    throw new Exception("Invalid month");
                _month = value;
            }
        }

        public int Year
        {
            get { return _year; }

            //accepting the year only it is greater than 1
            set
            {
                if (value < 1)
                    throw new Exception("Invalid year");
                _year = value;
            }
        }


        // Default constructor
        public Date()
        {
            Day = 1;
            Month = 1;
            Year = 1;
        }

        // Parameterized constructor
        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // AcceptDate() method
        public void AcceptDate()
        {
            Console.WriteLine("Enter Day");
            this.Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month");
            this.Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year");
            this.Year = Convert.ToInt32(Console.ReadLine());
        }


        // PrintDate() method
        public void PrintDate()
        {
            Console.WriteLine("Date: " + Day + "/" + Month + "/" + Year);
        }

        public bool IsValid()
        {
            if (Day < 1 || Day > 31 || Month < 1 || Month > 12)
                return false;

            // Array to store number of days in each month
            int[] daysInMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            if (Month == 2)
            {
                // Check for leap year, no of days in feb will be 29 if it is a leap year
                // or 28 if it is not a leap year
                if ((Year % 4 == 0 && Year % 100 != 0) || Year % 400 == 0)
                    daysInMonth[2] = 29;
                else
                    daysInMonth[2] = 28;
            }

            return Day <= daysInMonth[Month];
        }

        public override string ToString()
        {
            return Day + "/" + Month + "/" + Year;
        }

        // Static member function to calculate difference in years
        public static int CalculateYearsDifference(Date date1, Date date2)
        {
            int yearsDifference = date2.Year - date1.Year;

            if (date1.Month > date2.Month || (date1.Month == date2.Month && date1.Day > date2.Day))
                yearsDifference--;

            return yearsDifference;
        }

        // Overloading "-" operator
        public static Date operator -(Date date1, Date date2)
        {
            int yearsDifference = Date.CalculateYearsDifference(date1, date2);
            return new Date(1, 1, yearsDifference);
        }
        
        public static int AgeCalculator(Date birthDate)
        {
            int yearsDifference = Date.CalculateYearsDifference(birthDate, new Date(20, 5, 2024));
            return yearsDifference;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            // Creating a sample Date instance and print it 
            Date date1 = new Date(28, 12, 2000);
            Console.WriteLine("Date 1: " + date1.ToString());
            Console.WriteLine("Is Date 1 valid? " + date1.IsValid());

            Console.WriteLine();

            // Accept a new date from console
            Console.WriteLine("Enter a new date (dd mm yyyy): ");
            int day = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int year = Convert.ToInt32(Console.ReadLine());
            Date date2 = new Date(day, month, year);
            Console.WriteLine("Date 2: " + date2.ToString());
            Console.WriteLine("Is Date 2 valid? " + date2.IsValid());

            Console.WriteLine();

            // Calculate and print the difference in years
            int yearsDifference = Date.CalculateYearsDifference(date1, date2);
            Console.WriteLine("Years difference between Date 1 and Date 2: " + yearsDifference);

            Console.WriteLine();

            // Overload "-" operator
            Date date3 = date1 - date2;
            Console.WriteLine("Date 3: (The difference between the date)" + date3.ToString());
            Console.WriteLine("Is Date 3 valid? " + date3.IsValid());
        }
    }

}


