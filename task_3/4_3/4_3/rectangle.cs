using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_3
{
    class rectangle
    {
        public double length;
        public double width;
        public double c()
        {
            return 2 * (this.width + this.length);
        }
        public double s()
        {
            return this.width * this.length;
        }
    }
}
