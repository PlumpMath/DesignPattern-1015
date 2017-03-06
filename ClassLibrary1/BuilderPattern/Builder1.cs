using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    public class Builder1 : Builder
    {
        private Computer _computer = new Computer();

        public override void BuildPartCpu()
        {
            _computer.Add("cpu1");
        }

        public override void BuildPartMainBoard()
        {
            _computer.Add("mainboard1");
        }

        public override Computer GetComputer()
        {
            return _computer;
        }
    }
}
