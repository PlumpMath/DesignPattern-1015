using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.DecoratorPattern
{
    /// <summary>
    /// 手机挂件
    /// </summary>
    public class Accessories : Decorator
    {
        public Accessories(Phone phone) 
            : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();
            AddAccessories();
        }

        public void AddAccessories()
        {

        }
    }
}
