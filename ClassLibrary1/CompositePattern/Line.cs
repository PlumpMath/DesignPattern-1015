using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.CompositePattern
{
    /// <summary>
    /// 简单图形类  线
    /// </summary>
    public class Line : Graphics
    {
        public Line(string name) 
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
