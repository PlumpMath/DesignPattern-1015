using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FlyweightPattern
{
    /// <summary>
    /// 具体享元类，
    /// </summary>
    public class ConcreteFlyweight : Flyweight
    {
        /// <summary>
        /// 内部状态
        /// </summary>
        private string intrinsicstate;

        public ConcreteFlyweight(string innerState)
        {
            this.intrinsicstate = innerState;
        }

        public override void Operation(int extrinsicstate)
        {
            
        }
    }
}
