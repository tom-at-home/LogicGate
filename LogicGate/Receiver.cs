using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGate
{
    class Receiver : IInput1
    {

        IOutput input;

        public void ConnectInput1(IOutput output)
        {
            this.input = output;
        }

        public void showResult()
        {
            Console.WriteLine(input.GetResult());
        }
    }
}
