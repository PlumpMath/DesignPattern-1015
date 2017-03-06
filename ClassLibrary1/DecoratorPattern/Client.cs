using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.DecoratorPattern
{
    public class Client
    {
        public void F()
        {
            Phone phone = new ApplePhone();

            Sticker applePhoneWithSticker = new Sticker(phone);

        }
    }
}
