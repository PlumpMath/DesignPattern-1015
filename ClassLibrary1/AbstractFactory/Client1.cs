using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AbstractFactory
{
    public class Client1
    {
        public void Eat()
        {
            AbstractFactory guanxiFactory = new GuanXiFactory();
            YaBo guanxiYaBo = guanxiFactory.CreateYaBo();
            YaJia guanxiYaJia = guanxiFactory.CreateYaJia();

            AbstractFactory guandongFactory = new GuanDongFactory();
            YaBo guandongYaBo = guandongFactory.CreateYaBo();
            YaJia guandongYaJia = guandongFactory.CreateYaJia();
        }
    }
}
