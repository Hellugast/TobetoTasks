using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobetoTask6_OOP2.Entities
{
    public abstract class Shape
    {
        public double Area { get; set; }
        public abstract void AreaCalculate();
    }
}
