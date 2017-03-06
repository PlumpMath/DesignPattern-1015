using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FacadePattern
{
    /// <summary>
    /// 选课子系统
    /// </summary>
    public class RegisterCourse
    {
        /// <summary>
        /// 判断课程是否可选
        /// </summary>
        /// <param name="courseName"></param>
        /// <returns></returns>
        public bool CheckAvailable(string courseName)
        {
            return true;
        }
    }
}
