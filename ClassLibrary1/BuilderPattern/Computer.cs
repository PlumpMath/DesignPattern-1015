using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 电脑类
    /// </summary>
    public class Computer
    {
        /// <summary>
        /// 电脑组件集合
        /// </summary>
        private IList<string> _parts = new List<string>();

        /// <summary>
        /// 把单个组件放到电脑组件集合中
        /// </summary>
        /// <param name="part"></param>
        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("电脑组装完成");
        }
    }
}
