﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.IteratorPattern
{
    /// <summary>
    /// 迭代具体实现类
    /// </summary>
    public class ConcreteIterator : Iterator
    {
        private ConcreteList _list;
        private int _index;

        public ConcreteIterator(ConcreteList list)
        {
            _list = list;
            _index = 0;
        }

        public object GetCurrent()
        {
            return _list.GetElement(_index);
        }

        public bool MoveNext()
        {
            if (_index <= _list.Length)
            {
                return true;
            }
            return false;
        }

        public void Next()
        {
            if (_index < _list.Length)
            {
                _index++;
            }
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
