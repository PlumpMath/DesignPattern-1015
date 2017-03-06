using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.AdapterPattern
{
    public class Client
    {
        public void F()
        {
            IThreeHole threeHole = new PowerAdapter();
            threeHole.Request();
        }
    }
}
