using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public class GuanDongYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("广东鸭架");
        }
    }
}
