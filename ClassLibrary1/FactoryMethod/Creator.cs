using DesignPattern.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FactoryMethod
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class Creator
    {
        public abstract Food CreateFoodFactory();
    }
}
