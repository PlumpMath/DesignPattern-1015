using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.IteratorPattern
{
    /// <summary>
    /// 抽象聚合类
    /// </summary>
    public interface IListCollection
    {
        Iterator GetIterator();
    }
}
