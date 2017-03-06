using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.CommandPattern
{
    /// <summary>
    /// 具体命令类
    /// </summary>
    public class ConcreteCommand : Command
    {

        public ConcreteCommand(Receiver receive)
            : base(receive)
        {
        }

        public override void Action()
        {
            _receive.Run();
        }
    }
}
