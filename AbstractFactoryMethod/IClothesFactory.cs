using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod
{
    interface IClothesFactory
    {
        IShirt CreateShirt();

        ITrousers CreateTrousers();
    }
}
