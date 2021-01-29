using System;
using System.Collections.Generic;
using System.Text;

namespace Day5GameSalesSimulation
{
    interface IService
    {
        void Add(IObject obj);
        void Delete(IObject obj);
        void Update(IObject obj);
    }
}
