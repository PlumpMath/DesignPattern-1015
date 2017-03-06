using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    public class Client2
    {
        public void GetComputer()
        {
            Director director = new Director();
            Builder builder1 = new Builder1();
            Builder builder2 = new Builder2();

            director.Construct(builder1);
            director.Construct(builder2);

            Computer computer1 = builder1.GetComputer();
            Computer computer2 = builder2.GetComputer();
        }
    }
}
