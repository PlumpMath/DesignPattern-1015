using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.Singleton
{
    /// <summary>
    /// 单例模式
    /// </summary>
    public class Singleton
    {
        /// <summary>
        /// 定义静态私有变量保存类的实例
        /// </summary>
        private static Singleton _instance;

        /// <summary>
        /// 定义一个标识确保线程同步
        /// </summary>
        private static readonly object locker = new object();

        /// <summary>
        /// 私有构造函数
        /// </summary>
        private Singleton()
        {

        }

        /// <summary>
        /// 获取唯一实例
        /// </summary>
        /// <returns></returns>
        public static Singleton GetInstance()
        {
            //当线程运行到此时，先判断实例是否存在，不存在则进入创建
            if (_instance == null)
            {
                //多线程运行时，锁定资源，待线程运行结束后释放
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }

        /// <summary>
        /// 属性访问单一实例
        /// </summary>
        public static Singleton Instance
        {
            get
            {
                //当线程运行到此时，先判断实例是否存在，不存在则进入创建
                if (_instance == null)
                {
                    //多线程运行时，锁定资源，待线程运行结束后释放
                    lock (locker)
                    {
                        if (_instance == null)
                        {
                            _instance = new Singleton();
                        }
                    }
                }
                return _instance;
            }
        }
    }
}
