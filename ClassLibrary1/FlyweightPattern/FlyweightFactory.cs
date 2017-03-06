using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FlyweightPattern
{
    /// <summary>
    /// 享元工厂，创建管理享元对象
    /// </summary>
    public class FlyweightFactory
    {
        public Hashtable hashTable = new Hashtable();

        public FlyweightFactory()
        {
            hashTable.Add("A", new ConcreteFlyweight("A"));
            hashTable.Add("B", new ConcreteFlyweight("B"));
            hashTable.Add("C", new ConcreteFlyweight("C"));
        }

        public Flyweight GetFlyweight(string key)
        {
            return hashTable[key] as Flyweight;
        }
    }
}
