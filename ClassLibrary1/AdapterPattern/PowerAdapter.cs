using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AdapterPattern
{
    /// <summary>
    /// 适配器类
    /// 适配器类提供三孔插头的接口，实际上调用两孔插头的方法
    /// </summary>
    public class PowerAdapter : TwoHole, IThreeHole
    {
        public void Request()
        {
            this.SpecificalRequest();
        }
    }
}
