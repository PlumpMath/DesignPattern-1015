using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public class GuanDongFactory : AbstractFactory
    {
        public override YaBo CreateYaBo()
        {
            return new GuanDongYaBo();
        }

        public override YaJia CreateYaJia()
        {
            return new GuanDongYaJia();
        }
    }
}
