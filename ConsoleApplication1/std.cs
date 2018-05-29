using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class std
    {
        private int ID;
        private string name;
        public int age;

        public std()
        {
            Console.WriteLine("constructor 1");
        }
        public std(int agein)
        {
            Console.WriteLine("Constructor 2 with age");
        }
    }
}
