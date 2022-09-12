using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CviceniPV12._09
{
    internal class Cviceni
    {
        static void Main(string[] args)
        { 
            Interval inter = new Interval(3, 9);
            Interval inter2 = new Interval(11, 21);
            Console.WriteLine(inter);
            Console.WriteLine(inter.Numfind(5));
        }
    }
}
