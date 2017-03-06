using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.CommandPattern
{
    public class Client
    {
        public void F()
        {
            Receiver receive = new Receiver();
            Command command = new ConcreteCommand(receive);

            Invoke invoke = new Invoke(command);
            invoke.ExcuteCommand();
        }
    }
}
