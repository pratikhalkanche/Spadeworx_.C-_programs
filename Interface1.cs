using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    interface Interface1
    {
       public void A( )
        {
            Console.WriteLine("");   // why give not error for defination 
        }

    }

    interface simple1
    {


    }
    interface simple2
    {

    }

    interface simple3 : simple1,simple2
    {

    }

   public class Test :simple1,simple2,simple3
    { 
    
    }

    public abstract class Demo : Test,simple1, simple2,simple3

    { 
    
    }

    class Example 
    {
        static void main(String[] args)
        {

           // Example e;          // ref variable

            //e=new Demo()
            
            
            //   Interface1 i1 = new Interface1();

                            //    Demo d1 = new Demo();


            // declare method name give def inheritade  class and call method using obj of class
        }
    }


}
