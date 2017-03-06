using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.ProxyPattern
{
    /// <summary>
    /// 真实主题角色
    /// </summary>
    public class RealBuyPerson : Person
    {
        public override void BuyProduct()
        {
            throw new NotImplementedException();
        }
    }
}
