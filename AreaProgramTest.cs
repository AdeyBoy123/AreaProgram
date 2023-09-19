using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AreaProgram
{
    [TestFixture]
    class AreaProgramTest
    {
        [Test]
        public void Circle_ReturnsCorrectArea()
        {
            Circle circle = new Circle(5);
            double area = circle.Area();
            Assert.AreEqual(78.53981633974483, area);
        }

        [Test]
        public void Circle_ReturnsCorrectPerimeter()
        {
            Circle circle = new Circle(5);
            double perimeter = circle.Perimeter();
            Assert.AreEqual(31.41592653589793, perimeter);
        }

        [Test]
        public void Rectangle_ReturnsCorrectArea()
        {
            Rectangle rectangle = new Rectangle(5, 10);
            double area = rectangle.Area();
            Assert.AreEqual(50, area);

        }

        [Test]
        public void Rectangle_ReturnsCorrectPerimeter()
        {
            Rectangle rectangle = new Rectangle(5, 10);
            double perimeter = rectangle.Perimeter();
            Assert.AreEqual(30, perimeter);
        }

        [Test]
        public void Triangle_ReturnsCorrectArea()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double area = triangle.Area();
            Assert.AreEqual(6, area);
        }

        [Test]
        public void Triangle_ReturnsCorrectPerimeter()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            double perimeter = triangle.Perimeter();
            Assert.AreEqual(12, perimeter);
        }
    }
}
