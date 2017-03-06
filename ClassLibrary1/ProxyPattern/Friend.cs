using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.ProxyPattern
{
    /// <summary>
    /// 代理角色
    /// </summary>
    public class Friend : Person
    {
        RealBuyPerson realBuyPerson;

        public override void BuyProduct()
        {
            if(realBuyPerson == null)
            {
                realBuyPerson = new RealBuyPerson();
                this.PreBuyProduct();
                realBuyPerson.BuyProduct();
                this.PostBuyProduct();
            }
        }

        public void PreBuyProduct()
        {

        }

        public void PostBuyProduct()
        {

        }
    }
}
