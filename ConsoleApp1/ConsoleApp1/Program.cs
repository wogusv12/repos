using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IRactangle
    {
        void Area(int width, int height);
    }
    interface ITriangle
    {
        void Area(int width, int height);
    }
    class shape : IRactangle, ITriangle
    {

        void IRactangle.Area(int width, int height)
        {
            Console.WriteLine("Rectangle Area :" + width * height);
        }

        void ITriangle.Area(int width, int height)
        {
            Console.WriteLine("Triangle Area : " + width * height / 2);
        }

    }
    class Program
        
     {
     /*   static void Main(string[] args)
        {
            shape s = new shape();
            ((IRactangle)s).Area(10, 10);
            ((ITriangle)s).Area(20, 20);

            ITriangle t = s;
            IRactangle r = s;
            r.Area(30, 30);
            t.Area(30, 30);
        }
        */
    }
}
