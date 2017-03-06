using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FlyweightPattern
{
    /// <summary>
    /// 一个文本编辑器中会出现很多字面，
    /// 使用享元模式去实现这个文本编辑器的话，
    /// 会把每个字面做成一个享元对象。享元对象的内部状态就是这个字面，
    /// 而字母在文本中的位置和字体风格等其他信息就是它的外部状态。
    /// </summary>
    public class Client
    {
        public void F()
        {
            //定义外部状态，例如字母的位置等信息
            int externalstate = 10;

            FlyweightFactory flyweightFactory = new FlyweightFactory();

            Flyweight fa = flyweightFactory.GetFlyweight("A");
            if (fa != null)
            {
                fa.Operation(--externalstate);
            }

            Flyweight fb = flyweightFactory.GetFlyweight("B");
            if (fb != null)
            {
                fb.Operation(--externalstate);
            }

            Flyweight fd = flyweightFactory.GetFlyweight("D");
            if (fd != null)
            {
                fb.Operation(--externalstate);
            }
            else
            {
                flyweightFactory.hashTable.Add("D", new ConcreteFlyweight("D"));
            }
        }
    }
}
