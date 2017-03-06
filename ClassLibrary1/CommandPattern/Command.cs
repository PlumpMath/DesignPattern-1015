using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.CommandPattern
{
    /// <summary>
    /// 命令抽象类
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// 命令的接收者
        /// </summary>
        protected Receiver _receive;

        public Command(Receiver receive)
        {
            _receive = receive;
        }

        /// <summary>
        /// 命令执行方法
        /// </summary>
        public abstract void Action();
    }
}
