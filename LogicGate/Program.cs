using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGate
{
    class Program
    {
        static void Main(string[] args)
        {

            // Einfacher ODER-GATTER
            //Or or1 = new Or();
            //or1.ConnectInput1(new FalseProducer());
            //or1.ConnectInput2(new FalseProducer());

            //Receiver rec = new Receiver();
            //rec.ConnectInput1(or1);
            //rec.showResult();

            // Beispiel-Gatter aus der Aufgabe
            Not not1 = new Not();
            not1.ConnectInput1(new FalseProducer());

            And and1 = new And();
            and1.ConnectInput1(new TrueProducer());
            and1.ConnectInput2(not1);

            And and2 = new And();
            and2.ConnectInput1(new TrueProducer());
            and2.ConnectInput2(new TrueProducer());

            Xor xor1 = new Xor();
            xor1.ConnectInput1(new TrueProducer());
            xor1.ConnectInput2(new TrueProducer());

            And and3 = new And();
            and3.ConnectInput1(and1);
            and3.ConnectInput2(xor1);

            Receiver rec = new Receiver();
            rec.ConnectInput1(and3);
            rec.showResult();

        }
    }
}
