using AbstractFactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Factories
{
    class CasualClothesFactory: IClothesFactory
    {
        public IShirt CreateShirt()
        {
            return new TShirt();
        }
        public ITrousers CreateTrousers()
        {
            return new Jeans();
        }
    }
}
