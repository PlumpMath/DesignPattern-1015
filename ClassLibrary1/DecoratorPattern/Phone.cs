using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.DecoratorPattern
{
    /// <summary>
    /// 手机抽象类,即装饰者模式中的抽象组件类
    /// </summary>
    public abstract class Phone
    {
        public abstract void Print();
    }
}
