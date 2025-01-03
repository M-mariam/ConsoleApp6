using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AssignmentOOP01
{
    internal struct Person
    {
            public  string Name { get; set; }
            public int Age { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

    }
}
