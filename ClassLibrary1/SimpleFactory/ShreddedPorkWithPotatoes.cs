using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.SimpleFactory
{
    public class ShreddedPorkWithPotatoes : Food
    {
        public override void Print()
        {
            Console.WriteLine("土豆肉丝");
        }
    }
}
