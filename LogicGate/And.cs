using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGate
{
    class And : IInput1, IInput2, IOutput
    {
        IOutput input1;
        IOutput input2;

        public void ConnectInput1(IOutput output)
        {
            this.input1 = output;
        }

        public void ConnectInput2(IOutput output)
        {
            this.input2 = output;
        }

        public bool GetResult()
        {
            if (input1.GetResult() == true && input2.GetResult() == true)
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
