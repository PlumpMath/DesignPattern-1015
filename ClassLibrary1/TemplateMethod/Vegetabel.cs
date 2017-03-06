using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.TemplateMethod
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class Vegetabel
    {
        public void CookVegetabel()
        {
            this.PourOil();
            this.HeatOil();
            this.PourVegetabel();
            this.StirFry();
        }

        /// <summary>
        /// 倒油
        /// </summary>
        public void PourOil()
        {

        }

        /// <summary>
        /// 把油烧热
        /// </summary>
        public void HeatOil()
        {

        }
        
        /// <summary>
        /// 倒菜，具体倒什么菜看具体实现类
        /// </summary>
        public abstract void PourVegetabel();

        /// <summary>
        /// 开始翻炒
        /// </summary>
        public void StirFry()
        {

        }
    }
}
