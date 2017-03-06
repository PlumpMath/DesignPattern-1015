using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.IteratorPattern
{
    public class Client
    {
        public void F()
        {
            Iterator iterator;
            IListCollection list = new ConcreteList();
            iterator = list.GetIterator();

            while (iterator.MoveNext())
            {
                int i = (int)iterator.GetCurrent();
                iterator.Next();
            }
        }
    }
}
