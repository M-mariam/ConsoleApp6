using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal struct Point
    {
        // attribute , property, method, event
       public int X; //4 
       public int Y; //4

        // Constructor : Special Method
        // 1. named like struct
        // 2. no Return Type
        // CLR: generate parameterless Constructor
        // Will intialized the attributes with the defaulf value
        //public Point()
        //{
        //    X = default;
        //    Y = default;
        //}
        //public Point()
        //{
        //    X = 8;
        //    Y = 8;
        //}
        // .net 6
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void PrintPoint()
        {
            Console.WriteLine($"{X}, {Y}");
        }
        //public override string ToString()
        //{
        //    return $"{X}, {Y}";
        //}
    }
}
