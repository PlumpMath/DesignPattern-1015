using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPattern.SimpleFactory;

namespace DesignPattern.FactoryMethod
{
    public class ShreddedPorkWithPotatoesFactory : Creator
    {
        public override Food CreateFoodFactory()
        {
            return new ShreddedPorkWithPotatoes();
        }
    }
}
