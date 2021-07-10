using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class poly
    {

        public static void main()
        {
            polymorphism p1 = new polymorphism();
            p1.Add(16, 43f);
            p1.Add(5.8f, 10);
        }
    }
        class polymorphism
        {


            public void Add(float a, int b)
            {
                Console.WriteLine(a + b);
            }


            public void Add(int a, float b)
            {
                Console.WriteLine(a + b);
            }

        public int Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            return result;
        }



        }


    }

