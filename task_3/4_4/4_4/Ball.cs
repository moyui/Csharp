using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_4
{
    class Ball
    {
        public double R;
        public double s()
        {
            return 4 * Math.PI * Math.Pow(this.R, 2);
        }
        public double v()
        {
            return 4.0 / 3 * Math.PI * Math.Pow(this.R, 3);
        }
    }
}
