using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.CompositePattern
{
    /// <summary>
    /// 简单图形类 圆
    /// </summary>
    public class Circle : Graphics
    {
        public Circle(string name) 
            : base(name)
        {
        }

        public override void Add(Graphics g)
        {
        }

        public override void Draw()
        {
        }

        public override void Remove(Graphics g)
        {
        }
    }
}
