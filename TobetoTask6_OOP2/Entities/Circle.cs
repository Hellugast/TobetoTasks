using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobetoTask6_OOP2.Entities
{
    public class Circle : Shape, IDrawable
    {

        private double _radius;

        public double Radius
        {
            get { return _radius; }
            private set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Yarıçap sıfırdan büyük olmalı");
                }
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            _radius = radius;
        }
        public override void AreaCalculate()
        {
            Area = (Math.PI * _radius * _radius);
            Console.WriteLine(Area);
        }

        public void Draw()
        {
            Console.WriteLine("Daire başarıyla çizildi");
        }
    }
}
