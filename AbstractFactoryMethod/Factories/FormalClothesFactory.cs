using AbstractFactoryMethod.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryMethod.Factories
{
    class FormalClothesFactory: IClothesFactory
    {
        public IShirt CreateShirt()
        {
            return new FormalShirt();
        }
        public ITrousers CreateTrousers()
        {
            return new SuitTrosuers();
        }
    }
}
