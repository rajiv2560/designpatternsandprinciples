using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Violation
{
    public class AreaCalculator
    {
        public static int CalculateArea(Rectangle rectangle)
        {
            return rectangle.Height * rectangle.Width;
        }

        public static int CalculateArea(Square square)
        {
            return square.Height * square.Height;
        }
    }
}
