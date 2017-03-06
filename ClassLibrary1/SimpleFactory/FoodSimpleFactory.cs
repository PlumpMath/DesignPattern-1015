using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.SimpleFactory
{
    /// <summary>
    /// 菜谱简单工厂
    /// </summary>
    public class FoodSimpleFactory
    {
        public static Food CreateFood(string type)
        {
            Food food = null;
            switch (type)
            {
                case "西红柿鸡蛋":
                    food = new TomatoScrambledEggs();
                    break;
                case "土豆肉丝":
                    break;
            }
            return food;
        }
    }
}
