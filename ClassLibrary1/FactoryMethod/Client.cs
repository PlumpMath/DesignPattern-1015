using DesignPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    public class Client
    {
        public void Eat()
        {
            Creator creator1 = new TomatoScrambledEggsFactory();
            Creator creator2 = new ShreddedPorkWithPotatoesFactory();

            Food food1 = creator1.CreateFoodFactory();
            Food food2 = creator2.CreateFoodFactory();

        }
    }
}
