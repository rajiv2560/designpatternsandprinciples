using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LSP_Violation
{

    public class LSPViolateTest
    {
       /*
         * In the both tests, we are creating:

            1.       The Object of Rectangle to find the area of the Rectangle
            2.       The Object of Square to find the area of the Square
        */
        [Test]
        public void VerifyRectangleArea()
        {
            var rectangle = new Rectangle { Height = 2, Width = 3 };
            var result = AreaCalculator.CalculateArea(rectangle);
            Assert.AreEqual(6, result);
        }

        [Test]
        public void VerifySquareArea()
        {
            var square = new Square { Height = 3 };
            var result = AreaCalculator.CalculateArea(square);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void VerifyAreaOfRectFromSquare()
        {
            Rectangle rectangle = new Square();
            rectangle.Height = 4;
            rectangle.Width = 6;
            var result = AreaCalculator.CalculateArea(rectangle);
            Assert.AreEqual(24, result);
        }
        // The above test would fail, because the expected result is 24, however the actual area calculated would be 36.

        // This is the problem. Eventhough the Square class is a subset of the Rectangle class, the Object of Rectangle class is not substitutable by
        // object of the Square class without causing a problem in the system. 
    }
}
