using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Inheritance
{
    public class Vehicle
    {
        public Vehicle()
        {
            BrandName = "Sipa";
        }
        public string BrandName { get; set; }

        public void GetInfo()
        {
            Console.WriteLine("it is about Inheritance");
        }
    }
}
