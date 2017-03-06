using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public class GuanXiYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("广西鸭脖");
        }
    }
}
