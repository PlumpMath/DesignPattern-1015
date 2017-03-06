using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 指挥创建过程类
    /// </summary>
    public class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartCpu();
            builder.BuildPartMainBoard();
        }
    }
}
