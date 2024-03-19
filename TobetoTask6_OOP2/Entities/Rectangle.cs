using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TobetoTask6_OOP2.Entities
{
    public class Rectangle : Shape, IDrawable
    {
        private int _height { get; set; }
        private int _width { get; set; }

        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;
        }
        public override void AreaCalculate()
        {
            Area = _width * _height;
            Console.WriteLine(Area);
        }

        public void Draw()
        {
            Console.WriteLine("Dikdörtgen başarıyla çizildi");
        }
    }
}
