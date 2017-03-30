using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGate
{
    class FalseProducer : IOutput
    {
        public bool GetResult()
        {
            return false;
        }
    }
}
