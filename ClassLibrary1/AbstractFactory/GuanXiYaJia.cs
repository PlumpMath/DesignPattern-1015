using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public class GuanXiYaJia : YaJia
    {
        public override void Print()
        {
            Console.Write("广西鸭架");
        }
    }
}
