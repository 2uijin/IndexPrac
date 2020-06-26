using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexPrac
{
    class Product { 
        public int this[int i] {
            get { return i; }
            set { Console.WriteLine(i); }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            Console.WriteLine(p[3]);
        }
    }
}
