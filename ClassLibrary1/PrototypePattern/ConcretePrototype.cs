using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.PrototypePattern
{
    public class ConcretePrototype : MonkeyKingPrototype
    {
        public ConcretePrototype(string id)
            : base(id)
        {

        }

        /// <summary>
        /// 浅拷贝
        /// </summary>
        /// <returns></returns>
        public override MonkeyKingPrototype Clone()
        {
            return (MonkeyKingPrototype)this.Clone();
        }
    }
}
