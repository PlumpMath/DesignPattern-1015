using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.SimpleFactory
{
    /// <summary>
    /// 西红柿炒蛋类
    /// </summary>
    public class TomatoScrambledEggs : Food
    {
        public override void Print()
        {
            Console.WriteLine("西红柿鸡蛋");
        }
    }
}
