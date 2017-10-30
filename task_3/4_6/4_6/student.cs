using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4_6
{
    class student
    {
        public String name = "高夕毓";
        public String num = "1513490428";
        public double yuwen;
        public double shuxue;
        public double yinyu;
        public String show() 
        {
            return this.name + " " + this.num + " " +  this.yuwen + " " + this.shuxue + " " + this.yinyu;
        }
    }
}
