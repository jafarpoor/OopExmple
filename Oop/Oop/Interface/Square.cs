using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop.Interface
{
    public class Square : IShape
    {
        public double Edge { get; set; }

        public Square(double edge)
        {
            Edge= edge;
        }
        public double GetArea()
        {
            return 4 * Edge;
        }
    }
}
