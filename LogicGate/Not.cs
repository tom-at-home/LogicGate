using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGate
{
    class Not : IInput1, IOutput
    {
        bool i1;

        public void ConnectInput1(IOutput output)
        {
            i1 = output.GetResult();
        }

        public bool GetResult()
        {
            if(i1 == true)
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
