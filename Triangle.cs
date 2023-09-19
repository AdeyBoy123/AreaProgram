using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaProgram
{
    internal class Triangle
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double Area()
        {
            double semiPerimeter = (this.sideA + this.sideB + this.sideC) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - this.sideA) * (semiPerimeter - this.sideB) * (semiPerimeter - this.sideC));
            return area;
        }

        public double Perimeter()
        {
            return this.sideA + this.sideB + this.sideC;
        }
    }
}
