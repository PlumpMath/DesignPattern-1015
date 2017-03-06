using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.BridgePattern
{
    /// <summary>
    /// 电视机抽象类，提供抽象方法
    /// </summary>
    public abstract class TV
    {
        public abstract void On();

        public abstract void Off();

        public abstract void TurnChannel();
    }
}
