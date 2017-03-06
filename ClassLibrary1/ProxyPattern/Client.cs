using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.ProxyPattern
{
    public class Client
    {
        public void F()
        {
            Person person = new Friend();
            person.BuyProduct();
        }
    }
}
