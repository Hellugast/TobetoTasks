using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobetoTask6_OOP2.Entities;

namespace TobetoTask6_OOP2
{
    public class Repository<T> : IRepository<T> where T : Shape
    {

        List<Shape> shapes = new List<Shape>();

        public Repository()
        {
            shapes.Add(new Circle(6));
            shapes.Add(new Rectangle(15, 20));
            shapes.Add(new CorneredCircle("bab"));

            

        }

        public void GetAll()
        {
            foreach (var shape in shapes)
            {
                shape.AreaCalculate();
            }
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}

