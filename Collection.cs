using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System .Collections;


namespace firstproject
{
    class Collection
    {
        static void main(string []args)
        {

            ArrayList l1 = new ArrayList();
            l1.Add(10);
            l1.Add(20);
            l1.Add(25);


            foreach (object x in l1 )
                {
                Console.WriteLine(x);
                }
        }
    }
}
