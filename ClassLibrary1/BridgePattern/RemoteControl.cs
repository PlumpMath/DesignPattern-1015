using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.BridgePattern
{
    /// <summary>
    /// 抽象概念中的遥控器，扮演抽象化角色
    /// </summary>
    public class RemoteControl
    {
        private TV _implementor;

        public TV Implementor
        {
            get { return _implementor; }
            set { _implementor = value; }
        }

        public virtual void On()
        {
            _implementor.On();
        }

        public virtual void Off()
        {
            _implementor.Off();
        }

        public virtual void TurnChannel()
        {
            _implementor.TurnChannel();
        }
    }
}
