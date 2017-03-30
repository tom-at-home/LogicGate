using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGate
{
    class Receiver : IInput1
    {

        bool result;

        public void ConnectInput1(IOutput output)
        {
            result = output.GetResult();
        }

        public void showResult()
        {
            Console.WriteLine(result);
        }
    }
}
