using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Abstraction
{
    public abstract class People
    {
        public abstract void ShowInfo();
        public void Sleep()
        {
            Console.WriteLine("Zzzzzz");
        }
    }
}
