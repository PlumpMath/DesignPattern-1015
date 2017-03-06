using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.CompositePattern
{
    /// <summary>
    /// 复杂图形
    /// </summary>
    public class ComplexGraphics : Graphics
    {
        private IList<Graphics> _list = new List<Graphics>();

        public ComplexGraphics(string name)
            : base(name)
        {
        }

        public override void Add(Graphics g)
        {
            _list.Add(g);
        }

        public override void Draw()
        {
            foreach (var g in _list)
            {
                g.Draw();
            }
        }

        public override void Remove(Graphics g)
        {
            _list.Remove(g);
        }
    }
}
