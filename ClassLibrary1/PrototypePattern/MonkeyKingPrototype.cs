using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.PrototypePattern
{
    /// <summary>
    /// 孙悟空原型
    /// </summary>
    public abstract class MonkeyKingPrototype
    {
        public string Id { get; set; }

        public MonkeyKingPrototype(string id)
        {
            this.Id = id;
        }

        /// <summary>
        /// 克隆方法
        /// </summary>
        /// <returns></returns>
        public abstract MonkeyKingPrototype Clone();
    }
}
