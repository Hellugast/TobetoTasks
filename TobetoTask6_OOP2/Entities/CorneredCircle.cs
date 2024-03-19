using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobetoTask6_OOP2.Entities
{
    public class CorneredCircle : Shape
    {
        private readonly string _name;

        public CorneredCircle(string name)
        {
            _name = name;
        }
        public override void AreaCalculate()
        {
            Area = 42;
            Console.WriteLine(Area);
        }
    }
}
