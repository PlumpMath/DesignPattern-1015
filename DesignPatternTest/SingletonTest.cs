using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DesignPattern.Singleton;

namespace DesignPatternTest
{
    [TestClass]
    public class SingletonTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var obj1 = Singleton.GetInstance();
            var obj2 = Singleton.Instance;

            Assert.AreNotEqual(obj1, obj2);
        }
    }
}
