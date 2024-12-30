using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal struct PhoneBook
    {
        String[] names;
        long[] numbers;

        public PhoneBook(int size)
        {
            names = new string[size];
            numbers = new long[size];
        }

        public long this[string name]
        {
            get
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        return numbers[i];
                }
                return -1;
            }
            set
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i] == name)
                        numbers[i] = value;
                }
            }

        }


        public void AddPerson(string name, long number,int Index )
        {
            names[Index] = name;
            numbers[Index] = number;
        }
        public long GetNumber(string name)
        {
            for(int i=0; i< names.Length; i++)
            {
                if (names[i] == name)
                    return numbers[i];                
            }
            return -1;
        }
        public void UpdateNumber(string name, long newNumber)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == name)
                    numbers[i] = newNumber;
            }
        }
    }
}
