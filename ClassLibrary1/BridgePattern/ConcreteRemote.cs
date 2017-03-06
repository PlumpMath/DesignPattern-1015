using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.BridgePattern
{
    /// <summary>
    /// 具体遥控器
    /// </summary>
    public class ConcreteRemote : RemoteControl
    {
        public override void TurnChannel()
        {
            base.TurnChannel();
        }
    }
}
