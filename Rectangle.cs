using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProgram
{
    internal class Rectangle
    {
        private double height; 
        private double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }

        public double Area()
        {
            return this.height * this.width;
        }

        public double Perimeter()
        {
            return 2 * (this.height + this.width);
        }
    }
}
