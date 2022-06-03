using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Polymorphism
{
    public class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("Animal");
        }

        public void AnimalInfo()
        {
            Console.WriteLine("BaseAnimalInfo");
        }
    }
}
