using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AdapterPattern
{
    /// <summary>
    /// 两个孔的插头，源角色：需要适配的类
    /// </summary>
    public abstract class TwoHole
    {
        public void SpecificalRequest()
        {
            Console.Write("我是两个孔插头");
        }
    }
}
