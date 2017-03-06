using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.IteratorPattern
{
    /// <summary>
    /// 迭代器抽象类
    /// </summary>
    public interface Iterator
    {
        bool MoveNext();
        object GetCurrent();
        void Next();
        void Reset();
    }
}
