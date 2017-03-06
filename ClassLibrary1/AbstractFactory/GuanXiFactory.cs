using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public class GuanXiFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new GuanXiYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new GuanXiYaJia();
        }
    }
}
