using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal struct Employee
    {
        private int id;
        private string name;
        private double salary;
        // Applying Encapsulation Using Setter Getter Method
        // 1. Setter
        #region SetterGetter
        public void SetId(int id)
        {
            //if (name.Length >= 8 && name.Length <= 30)
                this.id = id;

        }
        //Getter
        public int GetId()
        {
            return id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return name;
        }
        public void SetSalary(double salary)
        {
            if (salary > 0)
                this.salary = salary;
        }
        public double GetSalary()
        {
            return salary;
        }
        public Employee(int id, string name, double salary)
        {
            //this.id = id;
            //this.name = name;
            //this.salary = salary;
            SetId(id);
            SetName(name);
            SetSalary(salary);
        }
        public override string ToString()
        {
            return $"id: {id}, name: {name}, salary: {salary}";
        }
        #endregion

        // 1. Full property
        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                if(value.Length >= 8 && value.Length<= 30)
                name = value;
            }
            get
            {
                return name;
            }
        }

        public double Salary
        {
            set
            {
                if(value > 0)
                salary = value;
            }
            get
            {
                return salary;
            }
        }
        // 2. Automic property : don't have to create the private attribute
        // without logic
        public string Address { set; get; }
    }
}
