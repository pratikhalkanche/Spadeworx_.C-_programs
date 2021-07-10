using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class MethodOverriding
    {
         static void main()
            {

            Bank b = new Bank();
            b.Roi();


            Bank b1 = new ICICI();
            b1.Roi();

            ICICI b2 = new ICICI();
            b2.Roi();


            }
    }

    class Bank 
    {
        public virtual float Roi()
        {
            float irr = 4.5f;
            Console.WriteLine(irr);
            return irr;

        }
    }


    class ICICI : Bank
    {

        public override  float Roi()
        {
            float ir= 7.5f;
            Console.WriteLine(ir);
            return ir;

        }

    }

}

