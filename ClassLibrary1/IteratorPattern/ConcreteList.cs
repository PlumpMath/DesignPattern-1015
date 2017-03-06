using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.IteratorPattern
{
    /// <summary>
    /// 具体聚合类
    /// </summary>
    public class ConcreteList : IListCollection
    {
        int[] collection;

        public ConcreteList()
        {
            collection = new int[] { 1, 2, 3, 4, 5, 6 };
        }

        public Iterator GetIterator()
        {
            throw new NotImplementedException();
        }

        public int Length
        {
            get { return collection.Length; }
        }

        public int GetElement(int index)
        {
            return collection[index];
        }
    }
}
