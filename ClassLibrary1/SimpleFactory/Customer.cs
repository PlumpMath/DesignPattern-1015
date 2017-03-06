using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.SimpleFactory
{
    public class Customer
    {
        public void Eat()
        {
            Food food1 = FoodSimpleFactory.CreateFood("西红柿鸡蛋");
            food1.Print();

            Food food2 = FoodSimpleFactory.CreateFood("土豆肉丝");
            food2.Print();
        }
    }
}
