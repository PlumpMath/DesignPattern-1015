using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 抽象建造者
    /// </summary>
    public abstract class Builder
    {
        /// <summary>
        /// 建造cpu
        /// </summary>
        public abstract void BuildPartCpu();

        /// <summary>
        /// 建造主板
        /// </summary>
        public abstract void BuildPartMainBoard();

        /// <summary>
        /// 获取组装好的电脑
        /// </summary>
        /// <returns></returns>
        public abstract Computer GetComputer();
    }
}
