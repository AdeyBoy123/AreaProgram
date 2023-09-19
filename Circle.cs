using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProgram
{
    internal class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area()
        {
            return Math.PI * this.radius * this.radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * this.radius;
        }
    }
}
