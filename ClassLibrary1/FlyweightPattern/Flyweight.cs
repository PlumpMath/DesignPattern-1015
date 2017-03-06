using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FlyweightPattern
{
    /// <summary>
    /// 抽象享元类，提供具体享元类具有的方法
    /// </summary>
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }
}
