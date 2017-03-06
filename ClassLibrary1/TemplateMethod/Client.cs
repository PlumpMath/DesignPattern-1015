using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    public class Client
    {
        public void F()
        {
            ChineseCabbage chinessCabbage = new ChineseCabbage();
            chinessCabbage.CookVegetabel();
        }
    }
}
