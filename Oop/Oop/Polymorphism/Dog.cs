using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Polymorphism
{
    public class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("Dog");
        }


        //Worng
        public void AnimalInfo()
        {
            Console.WriteLine("DogInfo");
        }
    }
}
