using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.DecoratorPattern
{
    /// <summary>
    /// 贴膜
    /// </summary>
    public class Sticker : Decorator
    {
        public Sticker(Phone phone) 
            : base(phone)
        {
        }

        public override void Print()
        {
            base.Print();
            AddSticker();
        }

        public void AddSticker()
        {

        }
    }
}
