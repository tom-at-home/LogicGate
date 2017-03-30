using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGate
{
    class And : IInput1, IInput2, IOutput
    {
        bool i1;
        bool i2;

        public void ConnectInput1(IOutput output)
        {
            i1 = output.GetResult();
        }

        public void ConnectInput2(IOutput output)
        {
            i2 = output.GetResult();
        }

        public bool GetResult()
        {
            if (i1 == true && i2 == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
