using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.FacadePattern
{
    public class Client
    {
        private static RegistrationFacade registrationFacade = new RegistrationFacade();

        public void F()
        {
            if (registrationFacade.RegisterCourse("", ""))
            {

            }
        }
    }
}
