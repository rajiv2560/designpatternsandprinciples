using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LSP_Follow
{
    public class LSPFollowTest
    {
        [Test]
        public void VerifyAreaOfShape()
        {
            var shapes = new List<Shape>
            {
                new Rectangle { Height = 4, Width = 6 },
                new Square { Side = 3 }
            };

            var areas = new List<int>();

            foreach (var shape in shapes)
            {
                areas.Add(shape.Area());
            }

            Assert.AreEqual(24, areas[0]);
            Assert.AreEqual(9, areas[1]);
        }
    }
}
