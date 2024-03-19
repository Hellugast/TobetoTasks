using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TobetoTask6_OOP2.Entities;

namespace TobetoTask6_OOP2
{
    internal interface IRepository<T>
    {
        void GetAll();
        void Create();
        void Update();
        void Delete();

    }
}
