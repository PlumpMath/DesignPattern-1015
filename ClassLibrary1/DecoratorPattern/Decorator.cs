using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.DecoratorPattern
{
    /// <summary>
    /// 装饰抽象类，要让装饰完全替代抽象组件，所以要集成Phone
    /// </summary>
    public class Decorator : Phone
    {
        private Phone _phone;

        public Decorator(Phone phone)
        {
            _phone = phone;
        }

        public override void Print()
        {
            if (_phone != null)
            {
                _phone.Print();
            }
        }
    }
}
