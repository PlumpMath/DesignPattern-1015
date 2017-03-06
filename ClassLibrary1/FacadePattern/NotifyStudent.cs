using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FacadePattern
{
    /// <summary>
    /// 通知学生系统
    /// </summary>
    public class NotifyStudent
    {
        /// <summary>
        /// 通知学生
        /// </summary>
        /// <param name="studentName"></param>
        /// <returns></returns>
        public bool Notify(string studentName)
        {
            return true;
        }
    }
}
