using System;

namespace ConsoleApp6
{
    //struct Employee
    //{
    //    int id;
    //    string name;
    //    double salary;
    //    int age;
    //}
    internal class Program
    {
        static void Main(string[] args)
        {
            #region struct
            Point P01;
            // Declare for obj (data) from type point
            // P01 : is a object
            // Allocate uninitialized 8 bytes at stack
            //Console.WriteLine(P01.X); XX // unassigned
            //P01.X = 10;
            //Console.WriteLine(P01.X);
            P01 = new Point();
            //new : used for select the constructor
            Console.WriteLine(P01.X); //0 default value in CLR
            P01 = new Point(1,5);
            Console.WriteLine(P01.X);
            Console.WriteLine(P01.Y);
            //P01.PrintPoint();
            //Console.WriteLine(P01.ToString()); //NameSpace
            //Console.WriteLine(P01.ToString()); 
            #endregion
            #region OOP
            // OOP: Programming Paradigm 
            // Class : bLUEpRINT OF THE oBJECT
            // Object : Specific Instance From Class
            // 4 Pillard 
            // 1. Encapsulation 
            // 2. Inheritance
            // 3. Polymorphism
            // 4. Abstraction 
            #endregion
            #region Encapsulation
            // With Class Or Struct 
            // Separate The Data (attributes) Definiation From its use
            // Struct => Employee
            Employee E01 = new Employee(1 ,"mariam", 1500);
            //E01.id = 1;
            //E01.name = "Mariam";
            //E01.salary = 15000;
            // acess data direct 
            // -> End user access data itselt 
            // --> No data Validation 
            // ---> No read only filed 
            // *** Apply Encapsulation
            // 1. Make all Data Private
            // 2. Acess Data through :
            // 2.1 Setter Getter Method
            // 2.2 Properties
            //E01.SetId(1);
            //E01.SetName("ahmmed");
            //Console.WriteLine(E01.GetId());
            Console.WriteLine(E01);

            // Properties
            // 1. Full property 
            // acess private atriute
            Employee E02 = new Employee();
            E02.Id = 12;
            E02.Name = "Mariam Mohamed";
            E02.Salary = 12000;
            E02.Address = "Alexandria";
            Console.WriteLine(E02.Id);
            // 2. Automatic Property
            // 3. Special Property (Indexer)
             /// this
            // Phonebook
            PhoneBook phonbook = new PhoneBook(3);
            phonbook.AddPerson("mariam", 1555, 0);
            phonbook.AddPerson("ali", 1888, 1);
            phonbook.AddPerson("mohamed", 1985, 2);
            //Console.WriteLine(phonbook.GetNumber("ahmed")); // -1
            //phonbook.UpdateNumber("mariam", 111);
            //Console.WriteLine(phonbook.GetNumber("mariam"));
            // indexer
            Console.WriteLine(phonbook["mariam"]);
            //phonbook["mariam"] = 1111;
            #endregion
        }
    }
}
