using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.BridgePattern
{
    public class Client
    {
        public void F()
        {
            RemoteControl remoteControl = new ConcreteRemote();
            remoteControl.Implementor = new ChangHong();
            remoteControl.On();
        }
    }
}
