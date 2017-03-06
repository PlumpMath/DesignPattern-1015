using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    public class Builder2 : Builder
    {
        private Computer _computer = new Computer();

        public override void BuildPartCpu()
        {
            _computer.Add("cpu2");
        }

        public override void BuildPartMainBoard()
        {
            _computer.Add("mainboard2");
        }

        public override Computer GetComputer()
        {
            return _computer;
        }
    }
}
