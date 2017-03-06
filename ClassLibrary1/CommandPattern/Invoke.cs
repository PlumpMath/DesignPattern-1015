using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.CommandPattern
{
    /// <summary>
    /// 教官，负责调用命令对象执行命令
    /// </summary>
    public class Invoke
    {
        private Command _command;

        public Invoke(Command command)
        {
            _command = command;
        }

        public void ExcuteCommand()
        {
            _command.Action();
        }
    }
}
