using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.PrototypePattern
{
    public class Client
    {
        public void F()
        {
            MonkeyKingPrototype protoType = new ConcretePrototype("MonkeyKing");

            MonkeyKingPrototype prototype1 = protoType.Clone();
            MonkeyKingPrototype prototype2 = protoType.Clone();
        }
    }
}
