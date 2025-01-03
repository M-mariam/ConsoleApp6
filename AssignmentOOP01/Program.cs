using System;
using System.Security.Cryptography;
using System.Transactions;

namespace AssignmentOOP01
{
    // Q2

    enum security
    {
        guest,
        developer,
        secretary,
        DPA


    }

    struct HiringDate
    {
        public int Day;
        public int Month;
        public int Year;
        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

    }
    enum Gender
    {
        M = 1,
        F = 2,
        Male = 1,
        Female = 2
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public security security { get; set; }
        public int Salary { get; set; }
        public HiringDate HiringDate { get; set; }
        public Gender Gender { get; set; }

        public Employee(int id, string name, security security, int salary, HiringDate hiringDate, Gender gender)
        {
            Id = id;
            Name = name;
            this.security = security;
            Salary = salary;
            HiringDate = hiringDate;
            Gender = gender;
        }


        public override string ToString()
        {
            return $"id: {Id}, Name: {Name}, Gender: {Gender},SecurityLevel {security},Salary: {Salary:C}, HringDate {HiringDate}";

        }
        public static int SortByHiringDate(Employee E01, Employee E02)
        {
            DateTime date01 = new DateTime(E01.HiringDate.Year);
            DateTime date02 = new DateTime(E02.HiringDate.Year);
            return date01.CompareTo(date02);
        }
    }
   
    internal class Program
    {


        static void Main(string[] args)
        {
            // Part 01
            #region Q1
            //1.Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Console.WriteLine("Enter x1 Value");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter y1 Value");
            //double y1 = double.Parse(Console.ReadLine());
            //Point P01 = new Point(x1, y1);
            //Console.WriteLine("Enter x2 Value");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter y2 Value");
            //double y2 = double.Parse(Console.ReadLine());
            //Point P02 = new Point(x2, y2);
            //static double CalculateDistance(Point p1, Point p2)
            //{
            //    double deltaX = p2.X - p1.X;
            //    double deltaY = p2.Y - p1.Y;
            //    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            //}
            //double result = CalculateDistance(P01, P02);
            //Console.WriteLine($"The distance betwenn X and Y is {result}");
            #endregion
            #region Q2
            // Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] person = new Person[3];
            //for(int i=0; i<person.Length; i++)
            //{
            //    Console.WriteLine($"Enter the name of person {i+1}" );
            //    string name = Console.ReadLine();
            //    Console.WriteLine($"Enter the age of person {i + 1}");
            //    int age = int.Parse(Console.ReadLine());
            //    person[i] = new Person(name, age);
            //}

            //Person OldestPerson = person[0];
            //foreach(Person p in person)
            //{
            //    if(p.Age > OldestPerson.Age)
            //    {
            //        OldestPerson = p;
            //    }
            //}

            //Console.WriteLine($"The oldest Person is {OldestPerson.Name}");


            #endregion
            // Part 02
            #region Q3   
            Employee[] employees = new Employee[3];
            employees[0] = new Employee(1, "mariam", security: security.guest,15000, new HiringDate { Day = 1, Month = 5, Year = 2000 }, gender: Gender.F);
            employees[1] = new Employee(2, "Mohamed", security: security.developer, 15000, new HiringDate { Day = 1, Month = 5, Year = 2020 }, gender: Gender.M);
            employees[2] = new Employee(3, "Ahmed", security: security.DPA,15000, new HiringDate { Day = 1, Month = 5, Year = 2010 }, gender: Gender.M);

            Console.WriteLine(employees[0]);
            foreach(Employee E in employees)
            {
                Console.WriteLine(E);
            }
            // Sort by Hiring Date
            Array.Sort(employees, Employee.SortByHiringDate);
            foreach (Employee E in employees)
            {
                Console.WriteLine(E);
            }
            int boxingCount = 0;
            int unboxingCount = 0;
            foreach (Employee E in employees)
            {
                object o01 = E; // boxing
                Employee o02 = (Employee)o01; // unboxing

                boxingCount ++;
                unboxingCount++;
            }
            Console.WriteLine("Boxing Count: " + boxingCount);
            Console.WriteLine("Unboxing Count: " + unboxingCount);
        
        #endregion


    }
    }
}
