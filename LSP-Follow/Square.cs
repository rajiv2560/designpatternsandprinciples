using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Follow
{
    public class Square : Shape
    {
        public int Side;
        public override int Area()
        {
            return Side * Side;
        }
    }
}
