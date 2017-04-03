using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGate
{
    class Not : IInput1, IOutput
    {
        IOutput input1;

        public void ConnectInput1(IOutput output)
        {
            this.input1 = output;
        }

        public bool GetResult()
        {       
            if(input1.GetResult() == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
