using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FacadePattern
{
    /// <summary>
    /// 外观类
    /// </summary>
    public class RegistrationFacade
    {
        private RegisterCourse _registerCourse;
        private NotifyStudent _notifyStudent;

        public RegistrationFacade()
        {
            _registerCourse = new RegisterCourse();
            _notifyStudent = new NotifyStudent();
        }

        /// <summary>
        /// 选课操作
        /// </summary>
        /// <param name="courceName"></param>
        /// <param name="studentName"></param>
        /// <returns></returns>
        public bool RegisterCourse(string courceName,string studentName)
        {
            if (!_registerCourse.CheckAvailable(courceName))
            {
                return false;
            }
            return _notifyStudent.Notify(studentName);
        }
    }
}
